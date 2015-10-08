using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBCommon.ValidateChain
{
    public class UnitChecker : AbstractDataValidator<ViewModel.StaffSalary>
    {
        protected override bool Process(ViewModel.StaffSalary val)
        {
            return !string.IsNullOrWhiteSpace(val.Currency);
        }
    }
}
