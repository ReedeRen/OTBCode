using System;
using System.Collections.Generic;
using OTBCommon.Model;
using System.Data.Entity;

namespace OTBCommon
{
    public interface IOTBDataContext
    {
        DbSet<Currency> Currencies { set; get; }
        DbSet<Employee> Employees { set; get; }
        DbSet<Role> Roles { set; get; }
        DbSet<Salary> Salaries { set; get; }
    }
}
