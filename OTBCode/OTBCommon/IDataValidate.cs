using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBCommon
{
    public interface IDataValidate<T>
    {
        IDataValidate<T> Next { set; get; }
        bool Check(T val);
    }
}
