namespace Foundation.SitecoreCDP.Configuration
{
    public static class ConfigSettings
    {
        public static string ClientKey => GetSetting(Constants.ClientKey);
        public static string StreamAPITarget => GetSetting(Constants.StreamAPITarget);
        public static string CookieDomain => GetSetting(Constants.CookieDomain);
        public static string POS => GetSetting(Constants.POS);
        public static string WebFlowTarget => GetSetting(Constants.WebFlowTarget);
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