using ModSettings;

namespace LitharsRidge
{
    internal class LitharsRidgeSettings : JsonModSettings
    {
        [Name("Enable Lithar's Ridge")]
        [Description("Enables the mod functionality")]
        public bool litharEnabled = false;

        [Name("Relocate Prepper Cache")]
        [Description("Move Prepper Cache to the backside of Lithar's Ridge")]
        public bool litharHatch = false;
    }

    internal static class Settings
    {
        public static LitharsRidgeSettings options;

        public static void OnLoad()
        {
            if (options == null)
            {
                options = new LitharsRidgeSettings();
                options.AddToModSettings("Lithar's Ridge", MenuType.Both);
            }
        }
    }
}