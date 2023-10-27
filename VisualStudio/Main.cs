namespace EternalBlizzard;

public class Main : MelonMod
{
    [HarmonyPatch(typeof(PlayerManager), nameof(PlayerManager.TeleportPlayerAfterSceneLoad))]
    private class ForceWeatherStageBlizzard
    {
        private static void Postfix()
        {
            GameManager.GetWeatherTransitionComponent().ForceUnmanagedWeatherStage(WeatherStage.Blizzard, 0f);
        }
    }
}