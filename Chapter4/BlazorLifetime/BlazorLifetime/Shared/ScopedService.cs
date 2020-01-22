using System;

namespace BlazorLifetime.Shared
{
  public class ScopedService
  {
    public Guid Guid { get; set; }

    public ScopedService()
      => Guid = Guid.NewGuid();
  }

}
