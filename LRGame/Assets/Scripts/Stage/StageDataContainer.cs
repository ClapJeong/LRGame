using System.Collections.Generic;
using UnityEngine;

public class StageDataContainer : MonoBehaviour
{
  [SerializeField] private Transform leftPlayerBeginTransform;
  public Transform LeftPlayerBeginTransform => leftPlayerBeginTransform;

  [SerializeField] private Transform rightPlayerBeginTransform;
  public Transform RightPlayerBeginTransform => rightPlayerBeginTransform;

  [Space(5)]
  [SerializeField] private GameObject staticObstacle;
  public GameObject StaticObstacle => staticObstacle;

  [Space(5)]
  [SerializeField] private List<TriggerTileBase> triggerTiles;
  public List<TriggerTileBase> TriggerTiles=> triggerTiles;

  [Space(5)]
  [SerializeField] private List<DynamicObstacleBase> dynamicObstacles;
  public List<DynamicObstacleBase> DynamicObstacles => dynamicObstacles;
}
