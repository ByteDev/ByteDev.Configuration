using System;
using ByteDev.Configuration.ConfigSection;
using NUnit.Framework;

namespace ByteDev.Configuration.UnitTests.ConfigSection
{
    [TestFixture]
    public class ConfigSettingsProviderExceptionTest
    {
        [TestFixture]
        public class Constructor
        {
            private const string Message = "something went wrong";

            [Test]
            public void WhenCalledWithNoArgs_ShouldReturnException()
            {
                var classUnderTest = new ConfigSettingsProviderException();

                Assert.IsNotNull(classUnderTest);
            }

            [Test]
            public void WhenCalledWithMessage_ShouldSetMessage()
            {
                var classUnderTest = new ConfigSettingsProviderException(Message);

                Assert.AreEqual(Message, classUnderTest.Message);
            }

            [Test]
            public void WhenCalledWithMessageAndInnerException_ShouldSetMessageAndInnerException()
            {
                var innerException = new Exception();

                var classUnderTest = new ConfigSettingsProviderException(Message, innerException);

                Assert.AreEqual(Message, classUnderTest.Message);
                Assert.AreSame(innerException, classUnderTest.InnerException);
            }    
        }
    }
}