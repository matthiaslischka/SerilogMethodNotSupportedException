using System;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serilog;
using Serilog.Extensions.Logging;

namespace SerilogMethodNotSupportedException
{
    [TestClass]
    public class ExceptionTests
    {
        [TestMethod]
        public void ThrowsException()
        {
            var serilogLogger = new LoggerConfiguration().CreateLogger();
            var microsoftLogger = new SerilogLoggerFactory(serilogLogger).CreateLogger<ExceptionTests>();
            microsoftLogger.LogInformation("{@asd}", new ReadOnlyMemory<byte>());
        }
    }
}