using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TMPro;
using UnityEngine;

public static class TMPExtension
{
  private abstract class TextSet
  {
    protected const char BackSlash = '\\';
    protected const char EscapeToken = 'n';

    public bool IsCompleted { get; protected set; }

    public abstract void Step(StringBuilder stb);
    public abstract void AppendAll(StringBuilder stb);
  }

  private class ContentTextSet : TextSet
  {
    private readonly string content;

    private int stringIndex = 0;

    public ContentTextSet(string content)
    {
      this.content = content; 
    }

    public override void Step(StringBuilder stb)
    {
      if (IsCompleted)
      {
        stb.Append(content);
        return;
      }

      var index = Mathf.Min(stringIndex, content.Length - 1);
      var c = content[index];
      if(c == BackSlash && index < content.Length - 1)
      {
        stringIndex += content[index + 1] switch
        {
          EscapeToken => 2,
          _ => 1,
        };
      }
      else
      {
        stringIndex += 1;
      }

      var target = content[..Mathf.Min(stringIndex, content.Length)];
      stb.Append(target);

      IsCompleted = stringIndex >= content.Length;
    }

    public override void AppendAll(StringBuilder stb)
    {
      stb.Append(content);
    }
  }

  private class RichTextSet : TextSet
  {
    private readonly string openingTag;
    private readonly string content;
    private readonly string closingTag;

    private int stringIndex = 0;

    public RichTextSet(string openingTag, string closingTag, string content)
    {
      this.openingTag = openingTag;
      this.closingTag = closingTag;
      this.content = content;
    }

    public override void Step(StringBuilder stb)
    {
      if (IsCompleted)
      {
        AppendAll(stb);
        return;
      }

      stb.Append(openingTag);

      var index = Mathf.Min(stringIndex, content.Length - 1);
      var c = content[index];
      if (c == BackSlash && index < content.Length - 1)
      {
        stringIndex += content[index + 1] switch
        {
          EscapeToken => 2,
          _ => 1,
        };
      }
      else
      {
        stringIndex += 1;
      }

      var target = content[..Mathf.Min(stringIndex, content.Length)];
      stb.Append(target);

      stb.Append(closingTag);

      IsCompleted = stringIndex >= content.Length;
    }

    public override void AppendAll(StringBuilder stb)
    {
      stb.Append(openingTag);
      stb.Append(content);
      stb.Append(closingTag);
    }
  }

  private class RichWithSetsTextSet : TextSet
  {
    private readonly string openingTag;
    private readonly List<TextSet> textSets;
    private readonly string closingTag;

    private int listIndex;

    public RichWithSetsTextSet(string openeingTag, List<TextSet> textSets, string closingTag)
    {
      this.openingTag = openeingTag;
      this.textSets = textSets;
      this.closingTag = closingTag;
    }

    public override void Step(StringBuilder stb)
    {
      stb.Append(openingTag);

      for (int i = 0; i < listIndex; i++)
        textSets[i].AppendAll(stb);

      if (listIndex < textSets.Count)
      {
        textSets[listIndex].Step(stb);

        if (textSets[listIndex].IsCompleted)
          listIndex++;
      }

      IsCompleted = listIndex >= textSets.Count;
      stb.Append(closingTag);
    }

    public override void AppendAll(StringBuilder stb)
    {
      stb.Append(openingTag);
      foreach (var ts in textSets)
        ts.AppendAll(stb);
      stb.Append(closingTag);
    }
  }

  private enum ParsingState
  {
    Contenting,
    OpenningTag,
    ClosingTag,
  }
  private const char TagBegin = '<';
  private const char Slash = '/';
  private const char TagEnd = '>';

  public static async UniTask TypeRichTextAsync(this TextMeshProUGUI tmp, float interval, CancellationToken token)
  {
    var text = tmp.text;
    if(TryParseTextSets(text, out var textSets))
    {
      try
      {
        var stb = new StringBuilder(text.Length);
        foreach (var textSet in textSets)
        {
          var innerSTB = new StringBuilder();
          while (!textSet.IsCompleted)
          {
            token.ThrowIfCancellationRequested();

            innerSTB.Clear();
            textSet.Step(innerSTB);

            tmp.text = stb.ToString() + innerSTB.ToString();
            await UniTask.WaitForSeconds(interval, false, PlayerLoopTiming.Update, token);
          }

          textSet.AppendAll(stb);
        }
      }
      finally
      {
        tmp.text = text;
      }
    }
    else
    {
      tmp.text = text;
    }
  }

  private static bool TryParseTextSets(string text, out List<TextSet> textSets)
  {
    textSets = new List<TextSet>();
    var parsingState = ParsingState.Contenting;
    var tagCount = 0;

    StringBuilder content = new();
    StringBuilder opening = new();
    StringBuilder closing = new();

    for (int i = 0; i < text.Length; i++)
    {
      var currentChar = text[i];
      switch (currentChar)
      {
        case TagBegin:
          {
            if (i + 1 >= text.Length)
              throw new Exception("RichText 태그 형식 오류: '<' 뒤에 문자가 없음");

            var isOpeneingTag = text[i + 1] != Slash;
            if(isOpeneingTag && tagCount == 0)
            {
              if (content.Length > 0)
                textSets.Add(new ContentTextSet(content.ToString()));

              ClearSTBs();

              tagCount++;
              parsingState = ParsingState.OpenningTag;
              opening.Append(currentChar);
            }
            else if(isOpeneingTag && tagCount > 0)
            {
              tagCount++;
              content.Append(currentChar);
            }
            else if(!isOpeneingTag && tagCount == 1)
            {
              tagCount--;
              parsingState = ParsingState.ClosingTag;
              closing.Append(currentChar);
            }
            else if(!isOpeneingTag && tagCount > 1)
            {
              tagCount--;
              content.Append(currentChar);
            }
          }
          break;

        case TagEnd:
          {
            AppendCurrent(currentChar);            

            if(parsingState == ParsingState.ClosingTag)
            {
              var openingTag = opening.ToString();
              var contentString = content.ToString();
              var closingTag = closing.ToString();

              bool hasTextSets = TryParseTextSets(contentString, out var innerTextSets);
              if (hasTextSets)
                textSets.Add(new RichWithSetsTextSet(openingTag, innerTextSets, closingTag));
              else
                textSets.Add(new RichTextSet(openingTag, contentString, closingTag));

              ClearSTBs();
            }

            parsingState = ParsingState.Contenting;
          }
          break;

        default:
          {
            AppendCurrent(currentChar);
          }
          break;
      }
    }

    if (content.Length > 0)
      textSets.Add(new ContentTextSet(content.ToString()));

    if (parsingState != ParsingState.Contenting)
      throw new System.Exception($"{text} 여기 태그 쌍 빠져있음!");

    return true;

    void ClearSTBs()
    {
      opening.Clear();
      content.Clear();
      closing.Clear();
    }

    void AppendCurrent(char targetChar)
    {
      switch (parsingState)
      {
        case ParsingState.Contenting: content.Append(targetChar); break;
        case ParsingState.OpenningTag: opening.Append(targetChar); break;
        case ParsingState.ClosingTag: closing.Append(targetChar); break;
      }

    }
  }
}
