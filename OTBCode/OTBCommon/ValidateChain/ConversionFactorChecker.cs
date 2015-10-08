using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBCommon.ValidateChain
{
    public class ConversionFactorChecker : AbstractDataValidator<ViewModel.StaffSalary>
    {
        protected override bool Process(ViewModel.StaffSalary val)
        {
            return val.ConversionFactor > 0m;
        }
    }
}
