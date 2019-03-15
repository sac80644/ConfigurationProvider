using System;
using GallowayTech.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTestConfigurationProviderTests
{
    [TestClass]
    public class ConfigurationProviderTest
    {
        private IConfigurationProvider provider;

        [TestInitialize]
        public void Setup()
        {
            provider = new ConfigurationProvider();
        }

        [TestMethod]
        public void GetAppSettings()
        {
            string expected = "sac80644";
            string result = provider.GetAppSettings("username");
            Assert.IsTrue(expected == result);
        }

        [TestMethod]
        public void GetConnectionString()
        {
            string expected = @"(localdb)\MSSQLLocalDB";
            string result = provider.GetConnectionString("datasource");
            Assert.IsTrue(expected == result);
        }
    }
}
