using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLogger
{
    public class FileLog : ILogger
    {
        public void Log(string message)
        {
            File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Log.txt"), message);
            // Imlemented logic
        }

        public void Log(object parameter, string message)
        {
            throw new NotImplementedException();
        }
    }
}
