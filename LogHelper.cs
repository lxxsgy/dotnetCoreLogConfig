  public class LogManange
    {
        static ILog log = null;
        public static ILog GetLog()
        {
            if (log == null)
            {
                ILoggerRepository repository = LogManager.CreateRepository("NETCoreRepository");
                XmlConfigurator.Configure(repository, new FileInfo("log4net.config"));
                log = LogManager.GetLogger(repository.Name, MethodBase.GetCurrentMethod().DeclaringType);
            }
            
            return log;
        }
    }
