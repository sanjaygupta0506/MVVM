using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.WPF_MVVM.SOLID_Princliple.Models
{
    //#region Normal
    //public class Logger
    //{
    //    public void Log(string message)
    //    {
    //        // Log message to file
    //    }
    //}

    //public class Processor
    //{
    //    private Logger _logger;

    //    public Processor()
    //    {
    //        _logger = new Logger();
    //    }

    //    public void ProcessData()
    //    {
    //        // Process data
    //        _logger.Log("Data processed successfully");
    //    }
    //}
    //#endregion

    #region Dependency Inversion Principle (DIP)
    public interface ILogger
    {
        void Log(string message);
    }

    public class Logger : ILogger
    {
        public void Log(string message)
        {
            // Log message to file
        }
    }

    public class Processor
    {
        private ILogger _logger;
        public Processor(ILogger logger)
        {
            _logger = logger;
        }

        public void ProcessData()
        {
            // Process data
            _logger.Log("Data processed successfully");
        }
    }
    #endregion
}
