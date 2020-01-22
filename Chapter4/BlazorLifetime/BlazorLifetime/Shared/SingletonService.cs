using System;

namespace BlazorLifetime.Shared
{
  public class SingletonService
  {
    public Guid Guid { get; set; }

    public SingletonService()
      => Guid = Guid.NewGuid();
  }
}
