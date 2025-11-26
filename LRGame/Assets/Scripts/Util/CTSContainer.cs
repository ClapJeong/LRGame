using System;
using System.Threading;
using UnityEngine;

public class CTSContainer : IDisposable
{
  public CancellationTokenSource cts;
  public CancellationToken token => cts.Token;

  public CTSContainer()
  {
    cts = new CancellationTokenSource();
  }

  public void Dispose()
  {
    if (cts != null)
    {
      cts.Cancel();
      cts.Dispose();
      cts = null;
    }
  }

  public void Cancel(bool regenerate = false)
  {
    if(cts != null)
    {
      cts.Cancel();
      cts.Dispose();
    }

    cts = null;
    if(regenerate)
      cts = new CancellationTokenSource();
  }
}
