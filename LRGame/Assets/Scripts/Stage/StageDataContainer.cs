using System.Collections.Generic;
using System.Linq;
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
  [SerializeField] private Transform triggerTileRoot;
  public List<TriggerTileViewBase> TriggerTiles=> triggerTileRoot.GetComponentsInChildren<TriggerTileViewBase>().ToList();

  [Space(5)]
  [SerializeField] private Transform dynamicObstacleRoot;
  public List<DynamicObstacleBase> DynamicObstacles => dynamicObstacleRoot.GetComponentsInChildren<DynamicObstacleBase>().ToList();
}
