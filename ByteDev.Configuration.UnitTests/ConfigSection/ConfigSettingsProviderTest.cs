﻿using System;
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
            public void WhenSectionDoesNotExist_ShouldThrowException()
            {
                WhenSectionDoesNotExist();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSettingDoesNotExist_ShouldThrowException()
            {
                WhenSectionIsEmpty();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSetting_ShouldReturnSetting()
            {
                const string value = "http://localhost";
                var section = new NameValueCollection { { SettingName, value } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.EqualTo(value));
            }

            [Test]
            public void WhenArgsAreEnums_AndSectionSettingExists_ShouldReturnSetting()
            {
                const string value = "http://localhost";
                var section = new NameValueCollection { { SettingName, value } };

                WhenSectionExists(section);

                var result = ClassUnderTest.GetString(DummyEnum.SettingName, DummyEnum.SectionName);

                Assert.That(result, Is.EqualTo(result));
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
            public void WhenSectionDoesNotExist_ShouldThrowException()
            {
                WhenSectionDoesNotExist();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithNonCharValue_ShouldThrowException()
            {
                var section = new NameValueCollection { { SettingName, "notChar" } };

                WhenSectionExists(section);

                Assert.Throws<UnexpectedConfigValueTypeException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithCharValue_ShouldReturnChar()
            {
                const string value = "X";
                var section = new NameValueCollection { { SettingName, value } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.TypeOf<char>());
                Assert.That(result, Is.EqualTo(Convert.ToChar(value)));
            }

            [Test]
            public void WhenArgsAreEnums_AndSectionSettingExists_ShouldReturnSetting()
            {
                const string value = "X";
                var section = new NameValueCollection { { SettingName, value } };

                WhenSectionExists(section);

                var result = ClassUnderTest.GetChar(DummyEnum.SettingName, DummyEnum.SectionName);

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
            public void WhenSectionDoesNotExist_ShouldThrowException()
            {
                WhenSectionDoesNotExist();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithNonByteValue_ShouldThrowException()
            {
                var section = new NameValueCollection { { SettingName, "1000" } };

                WhenSectionExists(section);

                Assert.Throws<UnexpectedConfigValueTypeException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithByteValue_ShouldReturnByte()
            {
                const string value = "5";
                var section = new NameValueCollection { { SettingName, value } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.TypeOf<byte>());
                Assert.That(result, Is.EqualTo(Convert.ToByte(value)));
            }

            [Test]
            public void WhenArgsAreEnums_AndSectionSettingExists_ShouldReturnSetting()
            {
                const string value = "5";
                var section = new NameValueCollection { { SettingName, value } };

                WhenSectionExists(section);

                var result = ClassUnderTest.GetByte(DummyEnum.SettingName, DummyEnum.SectionName);

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
            public void WhenSectionDoesNotExist_ShouldThrowException()
            {
                WhenSectionDoesNotExist();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithNonShortValue_ShouldThrowException()
            {
                var section = new NameValueCollection { { SettingName, "X" } };

                WhenSectionExists(section);

                Assert.Throws<UnexpectedConfigValueTypeException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithShortValue_ShouldReturnShort()
            {
                var section = new NameValueCollection { { SettingName, "3" } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.EqualTo(3));
            }

            [Test]
            public void WhenArgsAreEnums_AndSectionSettingExists_ShouldReturnSetting()
            {
                var section = new NameValueCollection { { SettingName, "3" } };

                WhenSectionExists(section);

                var result = ClassUnderTest.GetShort(DummyEnum.SettingName, DummyEnum.SectionName);

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
            public void WhenSectionDoesNotExist_ShouldThrowException()
            {
                WhenSectionDoesNotExist();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithNonIntValue_ShouldThrowException()
            {
                var section = new NameValueCollection { { SettingName, "X" } };

                WhenSectionExists(section);

                Assert.Throws<UnexpectedConfigValueTypeException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithIntValue_ShouldReturnInt()
            {
                var section = new NameValueCollection { { SettingName, "3" } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.EqualTo(3));
            }

            [Test]
            public void WhenArgsAreEnums_AndSectionSettingExists_ShouldReturnSetting()
            {
                var section = new NameValueCollection { { SettingName, "3" } };

                WhenSectionExists(section);

                var result = ClassUnderTest.GetInt(DummyEnum.SettingName, DummyEnum.SectionName);

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
            public void WhenSectionDoesNotExist_ShouldThrowException()
            {
                WhenSectionDoesNotExist();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithNonIntValue_ShouldThrowException()
            {
                var section = new NameValueCollection { { SettingName, "X" } };

                WhenSectionExists(section);

                Assert.Throws<UnexpectedConfigValueTypeException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithLongValue_ShouldReturnInt()
            {
                var section = new NameValueCollection { { SettingName, "3" } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.EqualTo(3));
            }

            [Test]
            public void WhenArgsAreEnums_AndSectionSettingExists_ShouldReturnSetting()
            {
                var section = new NameValueCollection { { SettingName, "3" } };

                WhenSectionExists(section);

                var result = ClassUnderTest.GetLong(DummyEnum.SettingName, DummyEnum.SectionName);

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
            public void WhenSectionDoesNotExist_ShouldThrowException()
            {
                WhenSectionDoesNotExist();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithNonBoolValue_ShouldThrowException()
            {
                var section = new NameValueCollection { { SettingName, "X" } };

                WhenSectionExists(section);

                Assert.Throws<UnexpectedConfigValueTypeException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithTrueValue_ShouldReturnTrue()
            {
                var section = new NameValueCollection { { SettingName, "true" } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.True);
            }

            [Test]
            public void WhenSectionExistsWithSettingWithFalseValue_ShouldReturnFalse()
            {
                var section = new NameValueCollection { { SettingName, "false" } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.False);
            }

            [Test]
            public void WhenArgsAreEnums_AndSectionSettingExists_ShouldReturnSetting()
            {
                var section = new NameValueCollection { { SettingName, "true" } };

                WhenSectionExists(section);

                var result = ClassUnderTest.GetBool(DummyEnum.SettingName, DummyEnum.SectionName);

                Assert.That(result, Is.True);
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
            public void WhenSectionDoesNotExist_ShouldThrowException()
            {
                WhenSectionDoesNotExist();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithNonFloatValue_ShouldThrowException()
            {
                var section = new NameValueCollection { { SettingName, "X" } };

                WhenSectionExists(section);

                Assert.Throws<UnexpectedConfigValueTypeException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithFloatValue_ShouldReturnFloat()
            {
                var section = new NameValueCollection { { SettingName, "3.4" } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.EqualTo(3.4f));
            }

            [Test]
            public void WhenArgsAreEnums_AndSectionSettingExists_ShouldReturnSetting()
            {
                var section = new NameValueCollection { { SettingName, "3.4" } };

                WhenSectionExists(section);

                var result = ClassUnderTest.GetFloat(DummyEnum.SettingName, DummyEnum.SectionName);

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
            public void WhenSectionDoesNotExist_ShouldThrowException()
            {
                WhenSectionDoesNotExist();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithNonDoubleValue_ShouldThrowException()
            {
                var section = new NameValueCollection { { SettingName, "X" } };

                WhenSectionExists(section);

                Assert.Throws<UnexpectedConfigValueTypeException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithDoubleValue_ShouldReturnDouble()
            {
                var section = new NameValueCollection { { SettingName, "1.123456789123456" } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.EqualTo(1.123456789123456d));
            }

            [Test]
            public void WhenArgsAreEnums_AndSectionSettingExists_ShouldReturnSetting()
            {
                var section = new NameValueCollection { { SettingName, "1.123456789123456" } };

                WhenSectionExists(section);

                var result = ClassUnderTest.GetDouble(DummyEnum.SettingName, DummyEnum.SectionName);

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
            public void WhenSectionDoesNotExist_ShouldThrowException()
            {
                WhenSectionDoesNotExist();

                Assert.Throws<ConfigSettingsProviderException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithNonDecimalValue_ShouldThrowException()
            {
                var section = new NameValueCollection { { SettingName, "X" } };

                WhenSectionExists(section);

                Assert.Throws<UnexpectedConfigValueTypeException>(() => Act());
            }

            [Test]
            public void WhenSectionExistsWithSettingWithGetDecimalValue_ShouldReturnGetDecimal()
            {
                var section = new NameValueCollection { { SettingName, ValidDecimal.ToString(CultureInfo.InvariantCulture) } };

                WhenSectionExists(section);

                var result = Act();

                Assert.That(result, Is.EqualTo(ValidDecimal));
            }

            [Test]
            public void WhenArgsAreEnums_AndSectionSettingExists_ShouldReturnSetting()
            {
                var section = new NameValueCollection { { SettingName, ValidDecimal.ToString(CultureInfo.InvariantCulture) } };

                WhenSectionExists(section);

                var result = ClassUnderTest.GetDecimal(DummyEnum.SettingName, DummyEnum.SectionName);

                Assert.That(result, Is.EqualTo(ValidDecimal));
            }

            private decimal Act()
            {
                return ClassUnderTest.GetDecimal(SettingName, SectionName);
            }
        }

    }
}