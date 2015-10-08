using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OTBCommon.Model
{
    [Table("Currency")]
    public class Currency
    {
        [Key]
        public int Id
        {
            set;
            get;
        }

        [StringLength(255, MinimumLength=3)]
        [Required]
        public string Unit
        {
            set;
            get;
        }

        [Required]
        public decimal ConversionFactor
        {
            set;
            get;
        }
    }
}
