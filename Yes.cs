// Decompiled with JetBrains decompiler
// Type: Banan.Yes
// Assembly: Banan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3FB8E417-3176-4768-8D1F-FED9FCF290D0
// Assembly location: D:\SteamLibrary\steamapps\common\BloonsTD6\Mods\AllCamo.dll

using Assets.Scripts.Models;
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Models.Bloons.Behaviors;
using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Models.Towers.Behaviors.Abilities;
using Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using Assets.Scripts.Models.Towers.Weapons;
using Assets.Scripts.Utils;
using HarmonyLib;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;


#nullable enable
namespace Banan
{
  [HarmonyPatch(typeof (GameModelLoader), "Load")]
  internal class Yes
  {
    [HarmonyPostfix]
    public static void Patch(GameModel __result)
    {
      foreach (TowerModel tower in (Il2CppArrayBase<TowerModel>) __result.towers)
      {
        tower.display = new PrefabReference()
        {
          guidRef = ""
        };
        foreach (Il2CppObjectBase il2CppObjectBase in ((IEnumerable<Model>) tower.behaviors).Where<Model>((Func<Model, bool>) (x => ((object) x).GetType() == typeof (AttackModel))))
        {
          foreach (WeaponModel weapon in (Il2CppArrayBase<WeaponModel>) il2CppObjectBase.Cast<AttackModel>().weapons)
            weapon.projectile.display = new PrefabReference()
            {
              guidRef = ""
            };
        }
        foreach (Il2CppObjectBase il2CppObjectBase in ((IEnumerable<Model>) tower.behaviors).Where<Model>((Func<Model, bool>) (x => ((object) x).GetType() == typeof (AirUnitModel))))
          il2CppObjectBase.Cast<AirUnitModel>().display = new PrefabReference()
          {
            guidRef = ""
          };
        foreach (Il2CppObjectBase il2CppObjectBase1 in ((IEnumerable<Model>) tower.behaviors).Where<Model>((Func<Model, bool>) (x => ((object) x).GetType() == typeof (AbilityModel))))
        {
          foreach (Il2CppObjectBase il2CppObjectBase2 in ((IEnumerable<Model>) il2CppObjectBase1.Cast<AbilityModel>().behaviors).Where<Model>((Func<Model, bool>) (x => ((object) x).GetType() == typeof (ActivateAttackModel))))
            ((Il2CppArrayBase<WeaponModel>) ((Il2CppArrayBase<AttackModel>) il2CppObjectBase2.Cast<ActivateAttackModel>().attacks)[0].weapons)[0].projectile.display = new PrefabReference()
            {
              guidRef = ""
            };
        }
      }
      foreach (BloonModel bloon in (Il2CppArrayBase<BloonModel>) __result.bloons)
      {
        bloon.display = new PrefabReference()
        {
          guidRef = ""
        };
        bloon.disallowCosmetics = true;
        foreach (DamageStateModel damageDisplayState in (Il2CppArrayBase<DamageStateModel>) bloon.damageDisplayStates)
          damageDisplayState.displayPath = new PrefabReference()
          {
            guidRef = ""
          };
      }
    }
  }
}
