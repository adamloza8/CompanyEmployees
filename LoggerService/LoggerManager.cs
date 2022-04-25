using Contracts;
using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerService
{
    public class LoggerManager : ILoggerManager
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        
        public LoggerManager()
        {

        }
        void ILoggerManager.LogDebug(string message)
        {
            logger.Debug(message);
        }

        void ILoggerManager.LogError(string message)
        {
            logger.Error(message);
        }

        void ILoggerManager.LogInfo(string message)
        {
            logger.Info(message);
        }

        void ILoggerManager.LogWarn(string message)
        {
            logger.Warn(message);
        }
    }
}
