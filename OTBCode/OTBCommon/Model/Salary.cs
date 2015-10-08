using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OTBCommon.Model
{
    [Table("Salary")]
    public class Salary
    {
        [Key]
        public int Id
        {
            set;
            get;
        }

        [Required]
        public decimal AnnualAmount
        {
            set;
            get;
        }

        [Required]
        public int EmployeeID
        {
            set;
            get;
        }

        [ForeignKey("EmployeeID")]
        public virtual Employee Employee
        {
            set;
            get;
        }

        [Required]
        public int CurrencyID
        {
            set;
            get;
        }

        [ForeignKey("CurrencyID")]
        public virtual Currency Currency
        {
            set;
            get;
        }

    }
}
