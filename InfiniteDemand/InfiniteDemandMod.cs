using HarmonyLib;

namespace InfiniteDemand
{
    public class InfiniteDemandMod
    {
        public static void Setup()
        {
            var harmony = new Harmony("net.johnytoxic.infinitedemand");
            harmony.PatchAll();
        }
    }
}
