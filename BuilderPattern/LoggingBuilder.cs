using BuilderPattern.Classes;
using BuilderPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class LoggingBuilder
    {
        private string level = "";
        private string outputDestination =" ";
        private string format =" ";
        private bool includeTimestamp = false;
        private bool includeStackTrace = false;
        private bool isAsync = false;
        private string logFilePath = "";
        private int maxLogFiles = 2;

        public LoggingBuilder setlevel(string level) 
        {
            this.level = level;
            return this;
        }

        public LoggingBuilder setoutputDestination(string outputDestination)
        {
            this.outputDestination = outputDestination;
            return this;
        }

        public LoggingBuilder setformat(string format)
        {
            this.format = format;
            return this;
        }

        public LoggingBuilder setincludeTimestamp(bool includeTimestamp)
        {
            this.includeTimestamp = includeTimestamp;
            return this;
        }

        public LoggingBuilder setincludeStackTrace(bool includeStackTrace)
        {
            this.includeStackTrace = includeStackTrace;
            return this;
        }

        public LoggingBuilder setisAsync(bool isAsync)
        {
            this.isAsync = isAsync;
            return this;
        }

        public LoggingBuilder setlogFilePath(string logFilePath)
        {
            this.logFilePath = logFilePath;
            return this;
        }

        public LoggingBuilder setmaxLogFiles(int maxLogFiles)
        {
            this.maxLogFiles = maxLogFiles;
            return this;
        }

        public ILogging Build() 
        {
            return new Logging(level, outputDestination, format, includeTimestamp,
             includeStackTrace, isAsync, logFilePath, maxLogFiles);
        }

    }
}
