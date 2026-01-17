using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

namespace LR.Table.Dialogue
{
  [System.Serializable]
  public class DialogueCondition: IDirtyPatcher
  {
    public enum CheckState
    {
      Equal,
      Without,
    }

    private UnityAction onDirty;

    public string TargetSubName
    {
      get => this.targetSubName;
      set
      {
        if (targetSubName == value)
          return;

        targetSubName = value;
        onDirty?.Invoke();        
      }
    }
    public int LeftKey
    {
      get => this.leftKey;
      set
      {
        if (leftKey == value)
          return;

        leftKey = value;
        onDirty?.Invoke();        
      }
    }
    public int LeftCheckState
    {
      get => this.leftCheckState;
      set
      {
        if (leftCheckState == value)
          return;

        leftCheckState = value;
        onDirty?.Invoke();
      }
    }
    public int RightKey
    {
      get => this.rightKey;
      set
      {
        if (rightKey == value)
          return;

        rightKey = value;
        onDirty?.Invoke();        
      }
    }
    public int RightCheckState
    {
      get => this.rightCheckState;
      set
      {
        if (rightCheckState == value)
          return;

        rightCheckState = value;
        onDirty?.Invoke();
      }
    }


    [SerializeField] private string targetSubName;
    [SerializeField] private int leftKey;
    [SerializeField] private int leftCheckState;
    [SerializeField] private int rightKey;
    [SerializeField] private int rightCheckState;

    public DialogueCondition( UnityAction onDirty)
    {
      this.onDirty = onDirty;
    }

    public bool IsCondition(string subName, int leftKey, int rightKey)
    {
      if (this.targetSubName != subName)
        return false;
      
      var isLeft = (CheckState)leftCheckState switch
      {
        CheckState.Equal => this.leftKey == leftKey,
        CheckState.Without => this.leftKey != leftKey,
        _ => throw new System.NotImplementedException(),
      };
      if (isLeft == false)
        return false;

      var isRight = (CheckState)rightCheckState switch
      {
        CheckState.Equal => this.rightKey == rightKey,
        CheckState.Without => this.rightKey != rightKey,
        _ => throw new System.NotImplementedException(),
      };
      if(isRight == false) 
        return false;

      return true;
    }

    public void SetOnDirty(UnityAction onDirty)
        => this.onDirty = onDirty;
  }
}