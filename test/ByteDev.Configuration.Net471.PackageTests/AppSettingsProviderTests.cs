using ByteDev.Configuration.AppSettings;
using NUnit.Framework;

namespace ByteDev.Configuration.Net471.PackageTests
{
    [TestFixture]
    public class AppSettingsProviderTests
    {
        [Test]
        public void WhenSettingExists_ThenReturnValue()
        {
            var sut = new AppSettingsProvider();

            var result = sut.GetInt("ClientRetries");

            Assert.That(result, Is.EqualTo(5));
        }
    }
}