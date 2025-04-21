


using BuilderPattern;
using BuilderPattern.Interface;

LoggingBuilder builder = new LoggingBuilder();
ILogging logger = builder.setformat("formatte").setincludeStackTrace(true).setlevel("level 3").setlogFilePath("loacl path").Build();
logger.Log();