using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLog
{
    public class SqlLogger : ILogger
    {
        public void Log(string message)
        {
            System.Diagnostics.Trace.WriteLine(message);
            //TODO
        }
    }
}
