using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            new ConsoleLog().Log(new object(), "Hello world");
        }
    }

    public class ConsoleLog : ILogger
    {
        public void Log(object parameter, string message)
        {
            Console.WriteLine(message);
        }
    }
}
