// Decompiled with JetBrains decompiler
// Type: Banan.AllCamo
// Assembly: Banan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB8E417-3176-4768-8D1F-FED9FCF290D0
// Assembly location: D:\SteamLibrary\steamapps\common\BloonsTD6\Mods\AllCamo.dll

using MelonLoader;
using System;

namespace Banan
{
  public class AllCamo : MelonMod
  {
    public virtual void OnApplicationStart() => MelonLogger.Msg(ConsoleColor.Green, "Camo Loaded!");
  }
}
