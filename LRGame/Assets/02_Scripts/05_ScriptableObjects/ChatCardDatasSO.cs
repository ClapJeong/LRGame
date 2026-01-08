using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "ChatCardDatasSO", menuName = "SO/ChatCardDatas")]
public class ChatCardDatasSO : ScriptableObject
{
  private readonly Dictionary<ChatCardEnum.ID, ChatCardData> dataMap = new();

  public float Duration;
  [SerializeField] public List<ChatCardData> datas = new();
  
  public ChatCardData GetData(ChatCardEnum.ID type)
  {
    if(dataMap.TryGetValue(type, out var existData))
      return existData;
    else
    {
      var data = datas.FirstOrDefault(data => data.id == type);
      dataMap[type] = data;
      return data;
    }
  }
}
