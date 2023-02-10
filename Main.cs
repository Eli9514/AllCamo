using MelonLoader;
using AllCamo;
using BTD_Mod_Helper;
using HarmonyLib;
using Il2CppAssets.Scripts.Simulation.Bloons;
using Il2CppAssets.Scripts.Unity.Display;
using Il2CppAssets.Scripts.Unity.UI_New.InGame;


[assembly: MelonInfo(typeof(AllCamo.Main), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace AllCamo;

[HarmonyPatch]
public class Main : BloonsTD6Mod
{
    [HarmonyPatch(typeof(Factory.__c__DisplayClass21_0), nameof(Factory.__c__DisplayClass21_0._CreateAsync_b__0))]
    [HarmonyPrefix]
    static bool Factory_CreateAsync()
    {
        return false;
    }
}
