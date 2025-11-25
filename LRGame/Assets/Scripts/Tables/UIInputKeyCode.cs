using UnityEngine;

[System.Serializable]
public class UIInputActionPaths
{
  [Header("[ Left ]")]
  [SerializeField] private KeyCode leftUp;
  public string LeftUpPath => InputActionPaths.ParshPath(leftUp);

  [SerializeField] private KeyCode leftRight;
  public string LeftRightPath => InputActionPaths.ParshPath(leftRight);

  [SerializeField] private KeyCode leftDown;
  public string LeftDownPath => InputActionPaths.ParshPath(leftDown);

  [SerializeField] private KeyCode leftLeft;
  public string LeftLeftPath => InputActionPaths.ParshPath(leftLeft);

  [Header("[ Right ]")]
  [SerializeField] private KeyCode rightUp;
  public string RightUPPath => InputActionPaths.ParshPath(rightUp);

  [SerializeField] private KeyCode rightRight;
  public string RightRightPath => InputActionPaths.ParshPath(rightRight);

  [SerializeField] private KeyCode rightDown;
  public string RightDownPath => InputActionPaths.ParshPath(rightDown);

  [SerializeField] private KeyCode rightLeft;
  public string RightLeftPath => InputActionPaths.ParshPath(rightLeft);
}