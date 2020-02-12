using ByteDev.Configuration.ConnectionSettings;
using NUnit.Framework;

namespace ByteDev.Configuration.Net471.PackageTests
{
    [TestFixture]
    public class ConnectionSettingsProviderTests
    {
        [Test]
        public void WhenConnectionExists_ThenReturnSetting()
        {
            var sut = new ConnectionSettingsProvider();

            var result = sut.GetConnectionSettings("MyDb");

            Assert.That(result.ConnectionString, Is.EqualTo("Data Source=.;Initial Catalog=MyDb;Integrated Security=True"));
        }
    }
}