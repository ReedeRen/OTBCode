using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OTBCommon.Model
{
    [Table("Role")]
    public class Role
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

        public virtual ICollection<Employee> Employees
        {
            set;
            get;
        }

        //public enum RoleDescription : int
        //{
        //    Staff = 1, Manager = 2, Owner = 3,
        //}
    }
}
