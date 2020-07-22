using System;

namespace NLog
{
    public class Log
    {
        static Logger logger = LogManager.GetLogger("");
        public static void Info(string input)
        {
            logger.Info(input);
        }

        public static void Error(string input)
        {
            logger.Error(input);
        }

        public static void Error(string input, Exception exception)
        {
            logger.Error(exception, input);
        }
    }
}
