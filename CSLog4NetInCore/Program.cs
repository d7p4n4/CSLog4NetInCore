using log4net;
using log4net.Config;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Configuration;
using System.IO;
using System.Reflection;

namespace CSLog4NetInCore
{
    class Program
    {
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("d:\\Server\\Visual_studio\\NuGetPackages\\CSLog4NetInCore\\CSLog4NetInCore\\log4net.config"));

            //var serviceProvider = new ServiceCollection().AddLogging(cfg => cfg.AddConsole()).Configure<LoggerFilterOptions>(cfg => cfg.MinLevel = LogLevel.Debug).BuildServiceProvider();
            //var logger = serviceProvider.GetService<ILogger<Program>>();

            //Console.WriteLine(ConfigurationManager.AppSettings["Rundate"]);
            //logger.LogDebug("Woo Hooo");
            _log.Info("Debug");


        }
    }
}
