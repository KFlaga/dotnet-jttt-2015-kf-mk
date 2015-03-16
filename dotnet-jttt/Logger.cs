using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_jttt
{
    class Logger
    {
        // Ponieważ chcemy miec jeden log dla calej aplikacji dostepny z kazdego miejsca, to
        // uzyta zostanie jedna instancja statyczna loggera
        static Logger instance;
        public static Logger Instance
        {
            get
            {
                 if(instance == null)
                    instance = new Logger();
                return instance;
            }
        }

        string logPath;
        DateTime time;

        private Logger()
        {
            logPath = "jttt.log";
        }

        public void AddLog(string info)
        {
            time = DateTime.Now;
            StreamWriter sw = File.AppendText(logPath);
            sw.WriteLine(time.ToString() + " - " + info);
            sw.Close();
        }
    }
}
