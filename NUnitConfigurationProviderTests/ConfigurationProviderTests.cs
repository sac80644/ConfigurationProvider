using System;
using GallowayTech.Configuration;
using NUnit.Framework;


namespace NUnitConfigurationProviderTests
{
    [TestFixture]
    public class ConfigurationProviderTest
    {
        private IConfigurationProvider provider;

        [SetUp]
        public void Setup()
        {
            provider = new ConfigurationProvider();
        }

        [Test]
        public void GetAppSettings()
        {
            string expected = "sac80644";
            string result = provider.GetAppSettings("username");
            Assert.That(expected == result);
        }

        [Test]
        public void GetConnectionString()
        {
            string expected = @"(localdb)\MSSQLLocalDB";
            string result = provider.GetConnectionString("datasource");
            Assert.That(expected == result);
        }
    }
}
