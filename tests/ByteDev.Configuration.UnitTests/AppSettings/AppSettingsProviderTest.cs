﻿using System;
using ByteDev.Configuration.AppSettings;
using NUnit.Framework;

namespace ByteDev.Configuration.UnitTests.AppSettings
{
    [TestFixture]
	public class AppSettingsProviderTest
	{
        private DummySettings _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new DummySettings();
        }

	    [Test]
	    public void WhenKeyDoesNotExist_ThenThrowException()
	    {
	        Assert.Throws<AppSettingsKeyNotExistException>(() => { _ = _sut.NotExistString; });
	    }

	    [Test]
        public void WhenStringExists_ThenGet()
        {
			Assert.That(_sut.ExistsString, Is.EqualTo("John"));
		}


	    [Test]
	    public void WhenCharExists_ThenGet()
	    {
	        Assert.That(_sut.ExistsChar, Is.EqualTo('X'));
	    }

        [Test]
        public void WhenExistsButIsNotChar_ThenThrowException()
        {
            Assert.Throws<UnexpectedConfigValueTypeException>(() => { _ = _sut.ExistsButIsNotChar; });
        }


        [Test]
        public void WhenBoolExists_ThenGet()
        {
            Assert.That(_sut.ExistsBool, Is.True);
        }

        [Test]
        public void WhenExistsButIsNotBool_ThenThrowException()
        {
            Assert.Throws<UnexpectedConfigValueTypeException>(() => { _ = _sut.ExistsButIsNotBool; });
        }


        [Test]
        public void WhenByteExists_ThenGet()
        {
            Assert.That(_sut.ExistsByte, Is.EqualTo(byte.MaxValue));
        }

        [Test]
        public void WhenExistsButIsNotByte_ThenThrowException()
        {
            Assert.Throws<UnexpectedConfigValueTypeException>(() => { _ = _sut.ExistsButIsNotByte; });
        }


        [Test]
        public void WhenShortExists_ThenGet()
        {
            Assert.That(_sut.ExistsShort, Is.EqualTo(short.MaxValue));
        }

        [Test]
        public void WhenExistsButIsNotShort_ThenThrowException()
        {
            Assert.Throws<UnexpectedConfigValueTypeException>(() => { _ = _sut.ExistsButisNotShort; });
        }


	    [Test]
        public void WhenIntExists_ThenGet()
        {
            Assert.That(_sut.ExistsInt, Is.EqualTo(int.MaxValue));
        }

        [Test]
        public void WhenExistsButIsNotInt_ThenThrowException()
        {
            Assert.Throws<UnexpectedConfigValueTypeException>(() => { _ = _sut.ExistsButIsNotInt; });
        }


        [Test]
        public void WhenLongExists_ThenGet()
        {
            Assert.That(_sut.ExistsLong, Is.EqualTo(long.MaxValue));
        }

        [Test]
        public void WhenExistsButIsNotLong_ThenThrowException()
        {
            Assert.Throws<UnexpectedConfigValueTypeException>(() => { _ = _sut.ExistsButIsNotLong; });
        }


        [Test]
        public void WhenFloatExists_ThenGet()
        {
            Assert.That(_sut.ExistsFloat, Is.EqualTo(1.1234567f));
        }

        [Test]
        public void WhenExistsButIsNotFloat_ThenThrowException()
        {
            Assert.Throws<UnexpectedConfigValueTypeException>(() => { _ = _sut.ExistsButIsNotFloat; });
        }


        [Test]
        public void WhenDoubletExists_ThenGet()
        {
            Assert.That(_sut.ExistsDouble, Is.EqualTo(1.123456789012345d));
        }

        [Test]
        public void WhenExistsButIsNotDouble_ThenThrowException()
        {
            Assert.Throws<UnexpectedConfigValueTypeException>(() => { _ = _sut.ExistsButIsNotDouble; });
        }


        [Test]
        public void WhenDecimalExists_ThenGet()
        {
            Assert.That(_sut.ExistsDecimal, Is.EqualTo(1.1234567890123456789012345678m));
        }

        [Test]
        public void WhenExistsButIsNotDecimal_ThenThrowException()
        {
            Assert.Throws<UnexpectedConfigValueTypeException>(() => { _ = _sut.ExistsButIsNotDecimal; });
        }


        [Test]
        public void WhenUriExists_ThenGet()
        {
            Assert.That(_sut.ExistsAbsoluteUri.ToString(), Is.EqualTo("http://www.google.com/"));
        }

        [Test]
        public void WhenExistsButIsNotAbsoluteUri_ThenThrowException()
        {
            Assert.Throws<UnexpectedConfigValueTypeException>(() => { _ = _sut.ExistsButIsNotAbsoluteUri; });
        }


        [Test]
        public void WhenGuidExists_ThenGet()
        {
            Assert.That(_sut.ExistsGuid, Is.EqualTo(new Guid("9DDC5329-2219-45EB-AACB-9842A9335128")));
        }

        [Test]
        public void WhenExistsButIsNotGuid_ThenThrowException()
        {
            Assert.Throws<UnexpectedConfigValueTypeException>(() => { _ = _sut.ExistsButIsNotGuid; });
        }
	}
}
