using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Serilog;

namespace InventManagement.Client.Web.App_Start
{
    public partial class Startup
    {
        public ILogger ConfigureLogging()
        {
            var logger = new LoggerConfiguration()
                .ReadFrom.AppSettings()
                .CreateLogger();

            Log.Logger = logger;
            return logger;
        }
    }
}