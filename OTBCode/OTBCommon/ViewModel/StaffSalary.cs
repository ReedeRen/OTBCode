using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OTBCommon.ViewModel
{
    public class StaffSalary
    {
        public string Name
        {
            set;
            get;
        }

        public string Currency
        {
            set;
            get;
        }

        public decimal AnnualAmount
        {
            set
            {
                _annualamount = value;
                UpdateGBPSalary();
            }
            get
            {
                return _annualamount;
            }
        }

        public decimal ConversionFactor
        {
            set
            {
                _conversionfactor = value;
                UpdateGBPSalary();
            }
            get
            {
                return _conversionfactor;
            }
        }

        //read only
        public decimal GBPSalary
        {
            protected set;
            get;
        }


        private decimal _annualamount = 0m;
        private decimal _conversionfactor = 1m;


        protected void UpdateGBPSalary()
        {
            GBPSalary = _annualamount * _conversionfactor;
        }
    }
}