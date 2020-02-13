using System;
using ByteDev.Configuration.ConnectionSettings;
using NUnit.Framework;

namespace ByteDev.Configuration.UnitTests.ConnectionSettings
{
    [TestFixture]
    public class ConnectionSettingsProviderTest
    {
        [TestFixture]
        public class GetConnectionSettings : ConnectionSettingsProviderTest
        {
            private ConnectionSettingsProvider _sut;

            [SetUp]
            public void SetUp()
            {
                _sut = new ConnectionSettingsProvider();
            }

            [Test]
            public void WhenKeyIsNull_ThenThrowException()
            {
                Assert.Throws<ArgumentException>(() => _sut.GetConnectionSettings(null));
            }

            [Test]
            public void WhenKeyIsString_ThenThrowException()
            {
                Assert.Throws<ArgumentException>(() => _sut.GetConnectionSettings(string.Empty));
            }

            [Test]
            public void WhenKeyDoesNotExist_ThenReturnNull()
            {
                var result = _sut.GetConnectionSettings("keyDoesNotExist");

                Assert.That(result, Is.Null);
            }

            [Test]
            public void WhenKeyExists_ThenReturnValue()
            {
                var result = _sut.GetConnectionSettings("MyDb");

                Assert.That(result.ConnectionString, Is.EqualTo("Data Source=.;Initial Catalog=MyDb;Integrated Security=True"));
            }
        }
    }
}