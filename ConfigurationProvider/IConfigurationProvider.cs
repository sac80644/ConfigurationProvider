using System.Configuration;

namespace GallowayTech.Configuration
{
    public interface IConfigurationProvider
    {
        string GetAppSettings(string key);
        string GetConnectionString(string key);
        ConnectionStringSettings GetConnectionStringSettings(string key);
    }
}
