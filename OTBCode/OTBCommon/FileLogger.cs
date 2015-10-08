using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBCommon
{
    public class FileLogger : ILogger
    {
        public string LogFile
        {
            set;
            get;
        }

        public void ErrorLog(string src, string msg)
        {
            if (string.IsNullOrWhiteSpace(LogFile))
            {
                return;
            }

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(LogFile))
            {
                sw.WriteLine(string.Format(_messageformat, src, msg));
            }
        }

        private readonly string _messageformat = "{0} \t {1}";
    }
}
