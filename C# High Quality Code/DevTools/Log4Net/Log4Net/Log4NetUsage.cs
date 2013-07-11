using System;
using log4net;
using log4net.Config;

namespace Log4NetTest
{
    class Log4NetUsage
    {
        private static readonly ILog log =
          LogManager.GetLogger("Debug");
        static void Main()
        {
            BasicConfigurator.Configure();

            string hello = null;

            log.Warn("Program starts to execute code.");
            log.Debug("Line 22 executed.");

            try
            {
                log.Info("Try parse null:");
                int myInt = int.Parse(hello);
            }
            catch (ArgumentNullException ex)
            {
                log.Error(ex.Message);
            }

            try
            {
                int zero = 0;
                log.Info("Try divide integer by zero.");
                int testDevisionByZero = 1 / zero;
            }
            catch (DivideByZeroException ex)
            {

                log.Error(ex.Message);
            }
        }
    }

}
