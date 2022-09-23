namespace SitecoreCDP.Configuration
{
    public static class ConfigSettings
    {
        public static string GetSetting(string settingName, string defaultValue = null)
        {
            var settingValue = Sitecore.Configuration.Settings.GetSetting(settingName);

            if (string.IsNullOrEmpty(settingValue))
            {
                settingValue = defaultValue;
            }
            return settingValue;
        }
    }
}