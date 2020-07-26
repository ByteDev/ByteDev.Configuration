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
            public void WhenCalledWithNoArgs_ThenReturnException()
            {
                var sut = new ConfigSettingsProviderException();

                Assert.That(sut, Is.Not.Null);
            }

            [Test]
            public void WhenCalledWithMessage_ThenSetMessage()
            {
                var sut = new ConfigSettingsProviderException(Message);

                Assert.That(sut.Message, Is.EqualTo(Message));
            }

            [Test]
            public void WhenCalledWithMessageAndInnerException_ThenSetMessageAndInnerException()
            {
                var innerException = new Exception();

                var sut = new ConfigSettingsProviderException(Message, innerException);

                Assert.That(sut.Message, Is.EqualTo(Message));
                Assert.That(sut.InnerException, Is.SameAs(innerException));
            }    
        }
    }
}