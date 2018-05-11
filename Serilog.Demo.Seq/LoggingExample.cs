using System;
using AutoFixture;
using NUnit.Framework;
using Serilog.Core;
using Serilog.Demo.Common;

namespace Serilog.Demo.Seq
{
    [TestFixture]
    public class LoggingExample
    {
        private readonly IFixture _autoFixture = new Fixture();

        [Test]
        public void Logging_Information_Message_To_Seq_Should_Not_Throw_Exception()
        {
            var infoObject = BuildTestInfoObject();
            
            Assert.That(() =>
            {
                using (var log = BuildLogger())
                {
                    log.Information("Test information message. Details of an object related to this event: {@InfoObject}", infoObject);
                }
            }, Throws.Nothing);
        }

        [Test]
        public void Logging_Warning_Message_To_Seq_Should_Not_Throw_Exception()
        {
            var infoObject = BuildTestInfoObject();

            Assert.That(() =>
            {
                using (var log = BuildLogger())
                {
                    log.Warning("Test warning message. Details of an object related to this event: {@InfoObject}", infoObject);
                }
            }, Throws.Nothing);
        }

        [Test]
        public void Logging_Error_Message_To_Seq_Should_Not_Throw_Exception()
        {
            var manualException = BuildTestException();

            Assert.That(() =>
            {
                using (var log = BuildLogger())
                {
                    log.Error("Test error message. Details of error: {@Exception}", manualException);
                }
            }, Throws.Nothing);
        }

        [Test]
        public void Logging_Debug_Message_To_Seq_Should_Not_Throw_Exception()
        {
            var infoObject = BuildTestInfoObject();
            var manualException = BuildTestException();

            Assert.That(() =>
            {
                using (var log = BuildLogger())
                {
                    log.Debug("Test debug message. Details of an object related to this event: {@InfoObject}. Details of error: : {@Exception}", infoObject, manualException);
                }
            }, Throws.Nothing);
        }

        #region Helper Methods

        private Logger BuildLogger()
        {
            return new LoggerConfiguration()
                .MinimumLevel.Debug()
                .ReadFrom.AppSettings()
                .CreateLogger();
        }

        private TestInformation BuildTestInfoObject()
        {
            return new TestInformation
            {
                Id = _autoFixture.Create<int>(),
                Description = _autoFixture.Create<string>()
            };
        }

        private Exception BuildTestException()
        {
            return new Exception("This is a test exception that's been manually created");
        }

        #endregion
    }
}
