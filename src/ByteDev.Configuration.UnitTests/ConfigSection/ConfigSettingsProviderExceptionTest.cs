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
                var sut = new ConfigSettingsProviderException();

                Assert.IsNotNull(sut);
            }

            [Test]
            public void WhenCalledWithMessage_ShouldSetMessage()
            {
                var sut = new ConfigSettingsProviderException(Message);

                Assert.AreEqual(Message, sut.Message);
            }

            [Test]
            public void WhenCalledWithMessageAndInnerException_ShouldSetMessageAndInnerException()
            {
                var innerException = new Exception();

                var sut = new ConfigSettingsProviderException(Message, innerException);

                Assert.AreEqual(Message, sut.Message);
                Assert.AreSame(innerException, sut.InnerException);
            }    
        }
    }
}