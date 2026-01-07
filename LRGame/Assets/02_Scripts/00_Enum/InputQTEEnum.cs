using System;
public class InputQTEEnum
{
  public enum UIType
  {
    QTEDefault,
  }

  public enum QTEFaiResultType
  {
    None,
    DecreaseOnlyCount, 
    DecreaseCountWithFail,
    FailSequence,    
  }
}
