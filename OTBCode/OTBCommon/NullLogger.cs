using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBCommon
{
    public class NullLogger : ILogger
    {
        public void ErrorLog(string src, string msg)
        {
        }
    }
}
