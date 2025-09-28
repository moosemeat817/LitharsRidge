using ModSettings;

namespace LitharsRidge
{
    internal class LitharsRidge : JsonModSettings
    {

        [Name("Enable Lithar's Ridge")]
        [Description("Enables the mod")]
        public bool litharEnabled = false;

        [Name("Add Lookout Tower")]
        [Description("Add Lookout Tower to Lithar's Ridge")]
        public bool litharTower = false;

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