using Colossal.Logging;
using Game;
using Game.Modding;

namespace InfiniteDemand
{
    public class InfiniteDemandMod : IMod
    {
        public static ILog log = LogManager.GetLogger($"{nameof(InfiniteDemand)}.{nameof(InfiniteDemandMod)}").SetShowsErrorsInUI(false);

        public void OnLoad(UpdateSystem updateSystem)
        {
            log.Info(nameof(OnLoad));

            var harmony = new HarmonyLib.Harmony("net.johnytoxic.infinitedemand");
            harmony.PatchAll();
        }

        public void OnDispose()
        {
            log.Info(nameof(OnDispose));
        }
    }
}
