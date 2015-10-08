using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using OTBCommon.Model;

namespace OTBCode.Models
{
    public class OTBContext : DbContext
    {
        #region data field
        public DbSet<Currency> Currencies
        {
            get;
            set;
        }

        public DbSet<Employee> Employees
        {
            get;
            set;
        }

        public DbSet<Role> Roles
        {
            get;
            set;
        }

        public DbSet<Salary> Salaries
        {
            get;
            set;
        }
        #endregion

        public OTBContext()
            : base("OTBConnectionStr") 
        { 
        }
    }
}