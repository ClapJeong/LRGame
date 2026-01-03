using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

[CreateAssetMenu(fileName = "ChatCardDatasSO", menuName = "SO/ChatCardDatas")]
public class ChatCardDatasSO : ScriptableObject
{
  public Dictionary<ChatCardType, ChatCardData> datas = new();
}
