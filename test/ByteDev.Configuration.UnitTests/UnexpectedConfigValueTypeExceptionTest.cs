using System;
using NUnit.Framework;

namespace ByteDev.Configuration.UnitTests
{
    [TestFixture]
    public class UnexpectedConfigValueTypeExceptionTest
    {
        [TestFixture]
        public class Constructor : UnexpectedConfigValueTypeExceptionTest
        {
            private const string Message = "something went wrong";

            [Test]
            public void WhenCalledWithNoArgs_ThenReturnException()
            {
                var sut = new UnexpectedConfigValueTypeException();

                Assert.That(sut, Is.Not.Null);
            }

            [Test]
            public void WhenCalledWithMessage_ThenSetMessage()
            {
                var sut = new UnexpectedConfigValueTypeException(Message);

                Assert.That(sut.Message, Is.EqualTo(Message));
            }

            [Test]
            public void WhenCalledWithMessageAndInnerException_ThenSetMessageAndInnerException()
            {
                var innerException = new Exception();

                var sut = new UnexpectedConfigValueTypeException(Message, innerException);

                Assert.That(sut.Message, Is.EqualTo(Message));
                Assert.That(sut.InnerException, Is.SameAs(innerException));
            }

            [Test]
            public void WhenCalledWithKeyValueType_ThenSetMessage()
            {
                var sut = new UnexpectedConfigValueTypeException("key1", "value1", typeof(bool));

                Assert.That(sut.Message, Is.EqualTo("Key: 'key1' value: 'value1' is not of expected type: Boolean."));
            }
        }
    }
}