using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OTBCommon.Model
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int Id
        {
            set;
            get;
        }

        [StringLength(255)]
        [Required]
        public string Name
        {
            set;
            get;
        }

        [Required]
        public int RoleID
        {
            set;
            get;
        }

        [ForeignKey("RoleID")]
        public virtual Role RoleData
        {
            set;
            get;
        }
    }
}
