using log4net;
using log4net.Config;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTask.Log
{
    public class Logger
    {
        
        public static void LoggerRun()
        {
            XmlConfigurator.Configure();
        }
        public static ILog logger = LogManager.GetLogger(typeof(Program));

    }
    
}
