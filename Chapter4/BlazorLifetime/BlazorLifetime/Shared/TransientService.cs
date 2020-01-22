using System;

namespace BlazorLifetime.Shared
{
  public class TransientService
  {
    public Guid Guid { get; set; }

    public TransientService()
      => Guid = Guid.NewGuid();
  }

}
