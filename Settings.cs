using ModSettings;

namespace LitharsRidge
{
    internal class LitharsRidge : JsonModSettings
    {

        [Name("Enable Lithar's Ridge")]
        [Description("Enables the mod")]
        public bool litharEnabled = false;



    }

    internal static class Settings
    {
        public static LitharsRidge options;

        public static void OnLoad()
        {
            options = new LitharsRidge();
            options.AddToModSettings("Lithar's Ridge", MenuType.Both);
        }
    }

}