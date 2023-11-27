using BepInEx;

namespace InfiniteDemand
{
    [BepInPlugin("net.johnytoxic.infinitedemand", "Infinite Demand Mod", "1.0.0")]
    public class InfiniteDemandMod : BaseUnityPlugin
    {
        private void Awake()
        {
            var harmony = new HarmonyLib.Harmony("net.johnytoxic.infinitedemand");
            harmony.PatchAll();
        }
    }
}
