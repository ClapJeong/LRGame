using UnityEngine;

[System.Serializable]
public class PlayerHPData
{
  [SerializeField] private int maxHP;
  public int MaxHP => maxHP;
}