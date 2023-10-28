using MelonLoader;

namespace InfiniteDemand
{
    public class InfiniteDemandMod : MelonMod
    {
        public override void OnInitializeMelon()
        {
            var harmony = new HarmonyLib.Harmony("net.johnytoxic.infinitedemand");
            harmony.PatchAll();
        }
    }
}
