using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GallowayTech.Configuration
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
