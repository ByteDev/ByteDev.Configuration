using System;
using System.Collections.Specialized;
using System.Globalization;
using ByteDev.Configuration.ConfigSection;
using Moq;
using NUnit.Framework;

namespace ByteDev.Configuration.UnitTests.ConfigSection
{
    [TestFixture]
    public class ConfigSettingsProviderTest
    {
        protected const string SectionName = "SectionName";
        protected const string SettingName = "SettingName";

        protected ConfigSettingsProvider ClassUnderTest;

        private Mock<IConfigSectionProvider> _configSectionProvider;

        protected void SetUpTest()
        {
            _configSectionProvider = new Mock<IConfigSectionProvider>();

            ClassUnderTest = new ConfigSettingsProvider(_configSectionProvider.Object);
        }

        protected void WhenSectionDoesNotExist()
        {
            _configSectionProvider.Setup(p => p.GetSection(SectionName)).Returns((NameValueCollection)null);
        }

        protected void WhenSectionExists(NameValueCollection section)
        {
            _configSectionProvider.Setup(p => p.GetSection(SectionName)).Returns(section);
        }

        protected void WhenSectionIsEmpty()
        {
            _configSectionProvider.Setup(p => p.GetSection(SectionName)).Returns(new NameValueCollection());
        }

        protected enum DummyEnum
        {
            SectionName,
            SettingName
        }

        [TestFixture]
        public class GetString : ConfigSettingsProviderTest
        {
            [SetUp]
            public void SetUp()
            {
                SetUpTest();
            }

            [Test]
            public void WhenSectionDoesNotExist_ThenThrowException()
            {
                WhenSectionDoesNotExist();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSettingDoesNotExist_ThenThrowException()
            {
                WhenSectionIsEmpty();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSetting_ThenReturnSetting()
            {
                const string value = "http://localhost";
                var section = new NameValueCollection { { SettingName, value } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.EqualTo(value));
            }

            private string Act()
            {
                return ClassUnderTest.GetString(SettingName, SectionName);
            }
        }

        [TestFixture]
        public class GetChar : ConfigSettingsProviderTest
        {
            [SetUp]
            public void SetUp()
            {
                SetUpTest();
            }

            [Test]
            public void WhenSectionDoesNotExist_ThenThrowException()
            {
                WhenSectionDoesNotExist();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithNonCharValue_ThenThrowException()
            {
                var section = new NameValueCollection { { SettingName, "notChar" } };

                WhenSectionExists(section);

                Assert.Throws<UnexpectedConfigValueTypeException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithCharValue_ThenReturnChar()
            {
                const string value = "X";
                var section = new NameValueCollection { { SettingName, value } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.TypeOf<char>());
                Assert.That(result, Is.EqualTo(Convert.ToChar(value)));
            }

            private char Act()
            {
                return ClassUnderTest.GetChar(SettingName, SectionName);
            }
        }

        [TestFixture]
        public class GetByte : ConfigSettingsProviderTest
        {
            [SetUp]
            public void SetUp()
            {
                SetUpTest();
            }

            [Test]
            public void WhenSectionDoesNotExist_ThenThrowException()
            {
                WhenSectionDoesNotExist();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithNonByteValue_ThenThrowException()
            {
                var section = new NameValueCollection { { SettingName, "1000" } };

                WhenSectionExists(section);

                Assert.Throws<UnexpectedConfigValueTypeException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithByteValue_ThenReturnByte()
            {
                const string value = "5";
                var section = new NameValueCollection { { SettingName, value } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.TypeOf<byte>());
                Assert.That(result, Is.EqualTo(Convert.ToByte(value)));
            }

            private byte Act()
            {
                return ClassUnderTest.GetByte(SettingName, SectionName);
            }
        }
        
        [TestFixture]
        public class GetShort : ConfigSettingsProviderTest
        {
            [SetUp]
            public void SetUp()
            {
                SetUpTest();
            }

            [Test]
            public void WhenSectionDoesNotExist_ThenThrowException()
            {
                WhenSectionDoesNotExist();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithNonShortValue_ThenThrowException()
            {
                var section = new NameValueCollection { { SettingName, "X" } };

                WhenSectionExists(section);

                Assert.Throws<UnexpectedConfigValueTypeException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithShortValue_ThenReturnShort()
            {
                var section = new NameValueCollection { { SettingName, "3" } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.EqualTo(3));
            }

            private short Act()
            {
                return ClassUnderTest.GetShort(SettingName, SectionName);
            }
        }
        
        [TestFixture]
        public class GetInt : ConfigSettingsProviderTest
        {
            [SetUp]
            public void SetUp()
            {
                SetUpTest();
            }

            [Test]
            public void WhenSectionDoesNotExist_ThenThrowException()
            {
                WhenSectionDoesNotExist();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithNonIntValue_ThenThrowException()
            {
                var section = new NameValueCollection { { SettingName, "X" } };

                WhenSectionExists(section);

                Assert.Throws<UnexpectedConfigValueTypeException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithIntValue_ThenReturnInt()
            {
                var section = new NameValueCollection { { SettingName, "3" } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.EqualTo(3));
            }

            private int Act()
            {
                return ClassUnderTest.GetInt(SettingName, SectionName);
            }
        }

        [TestFixture]
        public class GetLong : ConfigSettingsProviderTest
        {
            [SetUp]
            public void SetUp()
            {
                SetUpTest();
            }

            [Test]
            public void WhenSectionDoesNotExist_ThenThrowException()
            {
                WhenSectionDoesNotExist();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithNonIntValue_ThenThrowException()
            {
                var section = new NameValueCollection { { SettingName, "X" } };

                WhenSectionExists(section);

                Assert.Throws<UnexpectedConfigValueTypeException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithLongValue_ThenReturnInt()
            {
                var section = new NameValueCollection { { SettingName, "3" } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.EqualTo(3));
            }

            private long Act()
            {
                return ClassUnderTest.GetLong(SettingName, SectionName);
            }
        }

        [TestFixture]
        public class GetBool : ConfigSettingsProviderTest
        {
            [SetUp]
            public void SetUp()
            {
                SetUpTest();
            }

            [Test]
            public void WhenSectionDoesNotExist_ThenThrowException()
            {
                WhenSectionDoesNotExist();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithNonBoolValue_ThenThrowException()
            {
                var section = new NameValueCollection { { SettingName, "X" } };

                WhenSectionExists(section);

                Assert.Throws<UnexpectedConfigValueTypeException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithTrueValue_ThenReturnTrue()
            {
                var section = new NameValueCollection { { SettingName, "true" } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.True);
            }

            [Test]
            public void WhenSectionExistsWithSettingWithFalseValue_ThenReturnFalse()
            {
                var section = new NameValueCollection { { SettingName, "false" } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.False);
            }

            private bool Act()
            {
                return ClassUnderTest.GetBool(SettingName, SectionName);
            }
        }

        [TestFixture]
        public class GetFloat : ConfigSettingsProviderTest
        {
            [SetUp]
            public void SetUp()
            {
                SetUpTest();
            }

            [Test]
            public void WhenSectionDoesNotExist_ThenThrowException()
            {
                WhenSectionDoesNotExist();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithNonFloatValue_ThenThrowException()
            {
                var section = new NameValueCollection { { SettingName, "X" } };

                WhenSectionExists(section);

                Assert.Throws<UnexpectedConfigValueTypeException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithFloatValue_ThenReturnFloat()
            {
                var section = new NameValueCollection { { SettingName, "3.4" } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.EqualTo(3.4f));
            }

            private float Act()
            {
                return ClassUnderTest.GetFloat(SettingName, SectionName);
            }
        }

        [TestFixture]
        public class GetDouble : ConfigSettingsProviderTest
        {
            [SetUp]
            public void SetUp()
            {
                SetUpTest();
            }

            [Test]
            public void WhenSectionDoesNotExist_ThenThrowException()
            {
                WhenSectionDoesNotExist();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithNonDoubleValue_ThenThrowException()
            {
                var section = new NameValueCollection { { SettingName, "X" } };

                WhenSectionExists(section);

                Assert.Throws<UnexpectedConfigValueTypeException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithDoubleValue_ThenReturnDouble()
            {
                var section = new NameValueCollection { { SettingName, "1.123456789123456" } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.EqualTo(1.123456789123456d));
            }

            private double Act()
            {
                return ClassUnderTest.GetDouble(SettingName, SectionName);
            }
        }

        [TestFixture]
        public class GetDecimal : ConfigSettingsProviderTest
        {
            private const decimal ValidDecimal = 1.123456789123456789123456789m;

            [SetUp]
            public void SetUp()
            {
                SetUpTest();
            }

            [Test]
            public void WhenSectionDoesNotExist_ThenThrowException()
            {
                WhenSectionDoesNotExist();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithNonDecimalValue_ThenThrowException()
            {
                var section = new NameValueCollection { { SettingName, "X" } };

                WhenSectionExists(section);

                Assert.Throws<UnexpectedConfigValueTypeException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithGetDecimalValue_ThenReturnGetDecimal()
            {
                var section = new NameValueCollection { { SettingName, ValidDecimal.ToString(CultureInfo.InvariantCulture) } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.EqualTo(ValidDecimal));
            }

            private decimal Act()
            {
                return ClassUnderTest.GetDecimal(SettingName, SectionName);
            }
        }

        [TestFixture]
        public class GetUri : ConfigSettingsProviderTest
        {
            private readonly Uri _validAbsoluteUri = new Uri("http://www.google.com/");

            [SetUp]
            public void SetUp()
            {
                SetUpTest();
            }

            [Test]
            public void WhenSectionDoesNotExist_ThenThrowException()
            {
                WhenSectionDoesNotExist();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithNonUriValue_ThenThrowException()
            {
                var section = new NameValueCollection { { SettingName, "X" } };

                WhenSectionExists(section);

                Assert.Throws<UnexpectedConfigValueTypeException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithAbsoluteUriValue_ThenReturnUri()
            {
                var section = new NameValueCollection { { SettingName, _validAbsoluteUri.ToString() } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.EqualTo(_validAbsoluteUri));
            }

            private Uri Act()
            {
                return ClassUnderTest.GetUri(SettingName, SectionName);
            }
        }

        [TestFixture]
        public class GetGuid : ConfigSettingsProviderTest
        {
            private const string ValidGuidWithBrackets = "{9DDC5329-2219-45EB-AACB-9842A9335128}";

            private readonly Guid _validGuid = new Guid("9DDC5329-2219-45EB-AACB-9842A9335128");

            [SetUp]
            public void SetUp()
            {
                SetUpTest();
            }

            [Test]
            public void WhenSectionDoesNotExist_ThenThrowException()
            {
                WhenSectionDoesNotExist();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSettingWithNonGuidValue_ThenThrowException()
            {
                var section = new NameValueCollection { { SettingName, "X" } };

                WhenSectionExists(section);

                Assert.Throws<UnexpectedConfigValueTypeException>(() => Act());
            }

            [Test]
            public void WhenSettingWithValidGuidValue_ThenReturnGuid()
            {
                var section = new NameValueCollection { { SettingName, _validGuid.ToString() } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.EqualTo(_validGuid));
            }            
            
            [Test]
            public void WhenSettingWithValidGuidWithBracketsValue_ThenReturnGuid()
            {
                var section = new NameValueCollection { { SettingName, ValidGuidWithBrackets } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.EqualTo(_validGuid));
            }

            private Guid Act()
            {
                return ClassUnderTest.GetGuid(SettingName, SectionName);
            }
        }
    }
}