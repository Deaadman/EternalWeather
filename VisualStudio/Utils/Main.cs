namespace EternalWeather.Utils;

public class Main : MelonMod
{
    public override void OnInitializeMelon()
    {
        Settings.OnLoad();
    }
}