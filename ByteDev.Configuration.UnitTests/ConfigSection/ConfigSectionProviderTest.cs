using System;
using ByteDev.Configuration.ConfigSection;
using NUnit.Framework;

namespace ByteDev.Configuration.UnitTests.ConfigSection
{
    [TestFixture]
    public class ConfigSectionProviderTest
    {
        private ConfigSectionProvider _classUnderTest;

        [SetUp]
        public void SetUp()
        {
            _classUnderTest = new ConfigSectionProvider();
        }

        [TestFixture]
        public class GetSection : ConfigSectionProviderTest
        {
            [Test]
            public void WhenSectionNameIsNull_ThenThrowException()
            {
                Assert.Throws<ArgumentException>(() => _classUnderTest.GetSection(null));
            }

            [Test]
            public void WhenSectionNameIsEmpty_ThenThrowException()
            {
                Assert.Throws<ArgumentException>(() => _classUnderTest.GetSection(string.Empty));
            }
        }
    }
}