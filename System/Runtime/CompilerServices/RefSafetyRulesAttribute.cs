// Decompiled with JetBrains decompiler
// Type: System.Runtime.CompilerServices.RefSafetyRulesAttribute
// Assembly: Banan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB8E417-3176-4768-8D1F-FED9FCF290D0
// Assembly location: D:\SteamLibrary\steamapps\common\BloonsTD6\Mods\AllCamo.dll

using Microsoft.CodeAnalysis;
using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
  [CompilerGenerated]
  [Embedded]
  [AttributeUsage(AttributeTargets.Module, AllowMultiple = false, Inherited = false)]
  internal sealed class RefSafetyRulesAttribute : Attribute
  {
    public readonly int Version;

    public RefSafetyRulesAttribute([In] int obj0) => this.Version = obj0;
  }
}
