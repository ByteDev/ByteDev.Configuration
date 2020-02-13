using System;
using ByteDev.Configuration.ConfigSection;
using NUnit.Framework;

namespace ByteDev.Configuration.UnitTests.ConfigSection
{
    [TestFixture]
    public class ConfigSectionProviderTest
    {
        private ConfigSectionProvider _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new ConfigSectionProvider();
        }

        [TestFixture]
        public class GetSection : ConfigSectionProviderTest
        {
            [Test]
            public void WhenSectionNameIsNull_ThenThrowException()
            {
                Assert.Throws<ArgumentException>(() => _sut.GetSection(null));
            }

            [Test]
            public void WhenSectionNameIsEmpty_ThenThrowException()
            {
                Assert.Throws<ArgumentException>(() => _sut.GetSection(string.Empty));
            }

            [Test]
            public void WhenSectionNameDoesNotExist_ThenReturnNull()
            {
                var result = _sut.GetSection("sectionDoesNotExist");

                Assert.That(result, Is.Null);
            }
        }
    }
}