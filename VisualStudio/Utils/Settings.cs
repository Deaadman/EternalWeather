namespace EternalWeather.Utils;

internal class Settings : JsonModSettings
{
    internal static Settings Instance { get; } = new();

    [Name("Weather Stage")]
    [Description("Select which weather stage will be infinite.")]
    public WeatherStageSettings ChooseWeatherStage = WeatherStageSettings.Default;

    internal static void OnLoad()
    {
        Instance.AddToModSettings(BuildInfo.GUIName);
        Instance.RefreshGUI();
    }

    protected override void OnConfirm()
    {
        SetWeatherStage.WeatherStageChange();
    }
}