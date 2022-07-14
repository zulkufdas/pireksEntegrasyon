using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PireksCihazEntegrasyonu
{
    public static class Logger
    {
        static  NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static void WriteError(Exception ex) => logger.Error(ex);
        public static void WriteError(string message) => logger.Error(message);

        public static void WriteInfo(string message) => logger.Info(message);

        public static void WriteWarning(string message) => logger.Warn(message);



    }
}
