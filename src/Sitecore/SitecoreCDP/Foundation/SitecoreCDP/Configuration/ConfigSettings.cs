namespace Foundation.SitecoreCDP.Configuration
{
    public static class ConfigSettings
    {
        public static string ClientKey => GetSetting(Constants.ClientKey);
        public static string StreamAPITarget => GetSetting(Constants.StreamAPITarget);
        public static string CookieDomain => GetSetting(Constants.CookieDomain);
        public static string POS => GetSetting(Constants.POS);
        public static string WebFlowTarget => GetSetting(Constants.WebFlowTarget);
        public static string Channel => GetSetting(Constants.Channel);
        public static string TypeVisit => GetSetting(Constants.TypeVisit);
        public static string TypeIdentity => GetSetting(Constants.TypeIdentity);
        public static string Currency => GetSetting(Constants.Currency);
        public static string ExperienceId => GetSetting(Constants.ExperienceId);
        public static string OfferExperienceId => GetSetting(Constants.OfferExperienceId);
        public static string APIEndpoint => GetSetting(Constants.APIEndpoint);
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