using ByteDev.Configuration.AppSettings;
using NUnit.Framework;

namespace ByteDev.Configuration.UnitTests.AppSettings
{
    [TestFixture]
	public class AppSettingsProviderTest
	{
        private DummySettings _classUnderTest;

        [SetUp]
        public void SetUp()
        {
            _classUnderTest = new DummySettings();
        }

	    [Test]
	    public void WhenKeyDoesNotExist_ShouldThrowException()
	    {
	        Assert.Throws<AppSettingsKeyNotExistException>(() => { var s = _classUnderTest.NotExistString; });
	    }

	    [Test]
        public void WhenStringExists_ShouldGet()
        {
			Assert.That(_classUnderTest.ExistsString, Is.EqualTo("John"));
		}


	    [Test]
	    public void WhenCharExists_ShouldGet()
	    {
	        Assert.That(_classUnderTest.ExistsChar, Is.EqualTo('X'));
	    }

        [Test]
        public void WhenExistsButIsNotChar_ShouldThrowException()
        {
            Assert.Throws<UnexpectedConfigValueTypeException>(() => { var i = _classUnderTest.ExistsButIsNotChar; });
        }


        [Test]
        public void WhenBoolExists_ShouldGet()
        {
            Assert.That(_classUnderTest.ExistsBool, Is.True);
        }

        [Test]
        public void WhenExistsButIsNotBool_ShouldThrowException()
        {
            Assert.Throws<UnexpectedConfigValueTypeException>(() => { var b = _classUnderTest.ExistsButIsNotBool; });
        }


        [Test]
        public void WhenByteExists_ShouldGet()
        {
            Assert.That(_classUnderTest.ExistsByte, Is.EqualTo(byte.MaxValue));
        }

        [Test]
        public void WhenExistsButIsNotByte_ShouldThrowException()
        {
            Assert.Throws<UnexpectedConfigValueTypeException>(() => { var i = _classUnderTest.ExistsButIsNotByte; });
        }


        [Test]
        public void WhenShortExists_ShouldGet()
        {
            Assert.That(_classUnderTest.ExistsShort, Is.EqualTo(short.MaxValue));
        }

        [Test]
        public void WhenExistsButIsNotShort_ShouldThrowException()
        {
            Assert.Throws<UnexpectedConfigValueTypeException>(() => { var i = _classUnderTest.ExistsButisNotShort; });
        }


	    [Test]
        public void WhenIntExists_ShouldGet()
        {
            Assert.That(_classUnderTest.ExistsInt, Is.EqualTo(int.MaxValue));
        }

        [Test]
        public void WhenExistsButIsNotInt_ShouldThrowException()
        {
            Assert.Throws<UnexpectedConfigValueTypeException>(() => { var i = _classUnderTest.ExistsButIsNotInt; });
        }


        [Test]
        public void WhenLongExists_ShouldGet()
        {
            Assert.That(_classUnderTest.ExistsLong, Is.EqualTo(long.MaxValue));
        }

        [Test]
        public void WhenExistsButIsNotLong_ShouldThrowException()
        {
            Assert.Throws<UnexpectedConfigValueTypeException>(() => { var l = _classUnderTest.ExistsButIsNotLong; });
        }


        [Test]
        public void WhenFloatExists_ShouldGet()
        {
            Assert.That(_classUnderTest.ExistsFloat, Is.EqualTo(1.1234567f));
        }

        [Test]
        public void WhenExistsButIsNotFloat_ShouldThrowException()
        {
            Assert.Throws<UnexpectedConfigValueTypeException>(() => { var l = _classUnderTest.ExistsButIsNotFloat; });
        }


        [Test]
        public void WhenDoubletExists_ShouldGet()
        {
            Assert.That(_classUnderTest.ExistsDouble, Is.EqualTo(1.123456789012345d));
        }

        [Test]
        public void WhenExistsButIsNotDouble_ShouldThrowException()
        {
            Assert.Throws<UnexpectedConfigValueTypeException>(() => { var l = _classUnderTest.ExistsButIsNotDouble; });
        }


        [Test]
        public void WhenDecimalExists_ShouldGet()
        {
            Assert.That(_classUnderTest.ExistsDecimal, Is.EqualTo(1.1234567890123456789012345678m));
        }

        [Test]
        public void WhenExistsButIsNotDecimal_ShouldThrowException()
        {
            Assert.Throws<UnexpectedConfigValueTypeException>(() => { var l = _classUnderTest.ExistsButIsNotDecimal; });
        }
	}
}
