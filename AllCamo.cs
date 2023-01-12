using MelonLoader;
using System;

namespace Banan
{
  public class AllCamo : MelonMod
  {
    public virtual void OnApplicationStart() => MelonLogger.Msg(ConsoleColor.Green, "Camo Loaded!");
  }
}
