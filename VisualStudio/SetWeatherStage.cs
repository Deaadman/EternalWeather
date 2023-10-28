namespace EternalWeather;

internal class SetWeatherStage
{
    internal static void WeatherStageChange()
    {
        WeatherStageSettings selectedWeather = Utils.Settings.Instance.ChooseWeatherStage;

        if (selectedWeather == WeatherStageSettings.Default)
        {
            ForceDefaultWeather(GameManager.GetWeatherTransitionComponent());
            return;
        }

        WeatherStage actualWeatherStage = WeatherStageEnumMapping(Utils.Settings.Instance.ChooseWeatherStage);
        GameManager.GetWeatherTransitionComponent().ForceUnmanagedWeatherStage(actualWeatherStage, 0f);
    }

    private static void ForceDefaultWeather(WeatherTransition wt)
    {
        wt.ActivateDefaultWeatherSet();
    }

    private static WeatherStage WeatherStageEnumMapping(WeatherStageSettings wss)
    {
        return wss switch
        {
            WeatherStageSettings.Default => WeatherStage.Undefined,
            WeatherStageSettings.Clear => WeatherStage.Clear,
            WeatherStageSettings.LightFog => WeatherStage.LightFog,
            WeatherStageSettings.DenseFog => WeatherStage.DenseFog,
            WeatherStageSettings.PartlyCloudy => WeatherStage.PartlyCloudy,
            WeatherStageSettings.Cloudy => WeatherStage.Cloudy,
            WeatherStageSettings.LightSnow => WeatherStage.LightSnow,
            WeatherStageSettings.HeavySnow => WeatherStage.HeavySnow,
            WeatherStageSettings.Blizzard => WeatherStage.Blizzard,
            _ => throw new ArgumentException($"Unsupported weather stage: {wss}"),
        };
    }
}