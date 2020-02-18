using ByteDev.Configuration.ConfigSection;
using NUnit.Framework;

namespace ByteDev.Configuration.Net461.PackageTests
{
    [TestFixture]
    public class ConfigSettingsProviderTests
    {
        [Test]
        public void WhenSettingExists_ThenReturnValue()
        {
            var sectionProvider = new ConfigSectionProvider();

            var sut = new ConfigSettingsProvider(sectionProvider);

            var result = sut.GetBool("EnableAssessmentOnStart", "Health");

            Assert.That(result, Is.True);
        }
    }
}
