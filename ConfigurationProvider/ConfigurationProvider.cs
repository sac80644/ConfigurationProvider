using System.Configuration;

namespace Configuration
{
    public class ConfigurationProvider : IConfigurationProvider
    {
        public string GetAppSettings(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public string GetConnectionString(string key)
        {
            return GetConnectionStringSettings(key).ToString();
        }

        public ConnectionStringSettings GetConnectionStringSettings(string key)
        {
            return ConfigurationManager.ConnectionStrings[key];
        }
    }
}
