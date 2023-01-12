using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Bloons;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using Il2CppAssets.Scripts.Utils;
using HarmonyLib;
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
