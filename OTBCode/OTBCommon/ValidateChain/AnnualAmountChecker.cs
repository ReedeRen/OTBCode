using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBCommon.ValidateChain
{
    public class AnnualAmountChecker : AbstractDataValidator<ViewModel.StaffSalary>
    {
        private int _maxSalary = Int32.MaxValue;

        public int MaxSalary
        {
            set
            {
                _maxSalary = value;
            }

            get
            {
                return _maxSalary;
            }
        }

        // annual amount can be zero
        protected override bool Process(ViewModel.StaffSalary val)
        {
            return (val.AnnualAmount >= 0) && (val.AnnualAmount < MaxSalary); 
        }

    }
}
