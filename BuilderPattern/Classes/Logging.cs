using BuilderPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Classes
{
    public class Logging :ILogging
    {
        private  string level;
        private  string outputDestination;
        private  string format;
        private  bool includeTimestamp;
        private  bool includeStackTrace;
        private  bool isAsync;
        private  string logFilePath;
        private int maxLogFiles;
        public Logging(string level = "", string outputDestination= "", string format = "", bool includeTimestamp = false,
            bool includeStackTrace = false, bool isAsync = true, string logFilePath="", int maxLogFiles = 2)
        {
            this.level = level;
            this.outputDestination = outputDestination;
            this.format = format;
            this.includeTimestamp = includeTimestamp;
            this.includeStackTrace = includeStackTrace;
            this.isAsync = isAsync;
            this.logFilePath = logFilePath;
            this.maxLogFiles = maxLogFiles;
        }

        public void Log()
        {
           Console.Write($"Logging Configuration:\n" +
               $"Level: {level}\n" +
               $"Output Destination: {outputDestination}\n" +
               $"Format: {format}\n" +
               $"Include Timestamp: {includeTimestamp}\n" +
               $"Include Stack Trace: {includeStackTrace}\n" +
               $"Asynchronous Logging: {isAsync}\n" +
               $"Log File Path: {logFilePath}\n" +
               $"Max Log Files: {maxLogFiles}");
        }
    }
}
