using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBCommon
{
    class AbstractDataValidator <T> : IDataValidate<T> 
    {
        public IDataValidate<T> Next
        {
            set;
            get;
        }

        public bool Check(T val)
        {
            if (!Process(val))
            {
                return false;
            }

            if (Next != null)
            {
                return Next.Check(val);
            }

            return true;
        }

        protected virtual bool Process(T val)
        {
            return true;
        }
    }
}
