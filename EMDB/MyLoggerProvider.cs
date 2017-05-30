using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Extensions.Logging;

namespace EMDB
{
    //public class MyLoggerProvider : ILoggerProvider
    //{
    //    public ILogger CreateLogger(string categoryName)
    //    {
    //        return new MyLogger();
    //    }

    //    public void Dispose()
    //    { }

    //    private class MyLogger : ILogger
    //    {
    //        public bool IsEnabled(LogLevel logLevel)
    //        {
    //            return true;
    //        }

    //        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
    //        {
    //            try
    //            {
    //                if ( RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
    //                    File.AppendAllText(@"/tmp/log.txt", formatter(state, exception));

    //                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
    //                    File.AppendAllText(@"C:\temp\log.txt", formatter(state, exception));

    //                Console.WriteLine(formatter(state, exception));
    //            }
    //            catch (Exception) { }
    //        }

    //        public IDisposable BeginScope<TState>(TState state)
    //        {
    //            return null;
    //        }
    //    }
    //}
}