using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OTBCommon.Model;
using OTBCode.Models;

namespace OTBCode.DAL
{
    public class OTBInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<OTBContext>
    {
        protected override void Seed(OTBContext context)
        {
            //only run once
            //var funclist = this.GetType().GetMethods().Where(s => s.Name.Contains("PropertySeed"));
            //foreach (var s in funclist)
            //{
            //    s.Invoke(this, new object[] { context });
            //}
            //context.SaveChanges();
            PropertySeedCurrency(context);
            PropertySeedRole(context);
            PropertySeedEmployee(context);
            PropertySeedSalary(context);
        }

        public void SeedOnce(OTBContext context)
        {
            Seed(context);
        }

        #region table seed
        public void PropertySeedCurrency(OTBContext context)
        {
            var currencies = new List<Currency>
            {
                new Currency
                {
                    Id=1, 
                    Unit = "GBP",
                    ConversionFactor=1,
                },

                new Currency
                {
                    Id = 2,
                    Unit = "USD",
                    ConversionFactor = 1.54m,
                },

                new Currency
                {
                    Id = 3,
                    Unit = "Rocks",
                    ConversionFactor = 10m,
                },

                new Currency
                {
                    Id = 4,
                    Unit = "Sweets",
                    ConversionFactor = 12m,
                },

                new Currency
                {
                    Id = 5,
                    Unit = "Credits",
                    ConversionFactor = 8000m,
                }
            };

            currencies.ForEach(s => context.Currencies.Add(s));
            context.SaveChanges();
        }


        public void PropertySeedEmployee(OTBContext context)
        {
            var emoloyees = new List<Employee>
            {
                new Employee
                {
                    Id = 1, 
                    Name = "Homer Simpson", 
                    RoleID = 1,
                },
                
                new Employee
                {
                    Id = 2, 
                    Name = "Sterling Archer", 
                    RoleID = 1,
                },

                new Employee 
                {
                    Id = 3, 
                    Name = "Eric Cartman", 
                    RoleID = 1,
                },

                new Employee
                {
                    Id = 4, 
                    Name = "Fred Flinstone", 
                    RoleID = 2,
                },

                new Employee
                {
                    Id = 5, 
                    Name = "Professor Farnsworth", 
                    RoleID = 3,
                }
            };

            emoloyees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
        }

        public void PropertySeedRole(OTBContext context)
        {
            var roles = new List<Role>
            {
                new Role
                {
                    Id = 1,
                    Name = "Staff",
                },

                new Role
                {
                    Id = 2,
                    Name = "Manager",
                },

                new Role
                {
                    Id = 3,
                    Name = "Owner",
                }
            };

            roles.ForEach(s => context.Roles.Add(s));
            context.SaveChanges();
        }

        public void PropertySeedSalary(OTBContext context)
        {
            var salaries = new List<Salary>
            {
                new Salary
                {
                    Id = 1,
                    EmployeeID = 1,
                    CurrencyID = 2,
                    AnnualAmount = 22000m,
                },

                new Salary
                {
                    Id = 2,
                    EmployeeID = 2,
                    CurrencyID = 2,
                    AnnualAmount = 150000m,
                },

                new Salary
                {
                    Id = 3,
                    EmployeeID = 3,
                    CurrencyID = 4,
                    AnnualAmount = 60000m,
                },

                new Salary
                {
                    Id = 4,
                    EmployeeID = 4,
                    CurrencyID = 3,
                    AnnualAmount = 900000m,
                },

                new Salary
                {
                    Id = 5,
                    EmployeeID = 5,
                    CurrencyID = 5,
                    AnnualAmount = 5000000000m,
                },
            };

            salaries.ForEach(s => context.Salaries.Add(s));
            context.SaveChanges();
        }

        #endregion
    }
}