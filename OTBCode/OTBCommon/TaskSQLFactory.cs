using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBCommon
{
    public class TaskSQLFactory
    {
        public enum TaskTopic : int
        {
            Task1 = 0, Task2 = 1, Task3 = 2, Task4 = 3,
        }

        protected TaskSQLFactory()
        { }

        public static string GetSQLInstance(TaskTopic topic)
        {
            try
            {
                return SQLCmds[(int)topic];
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }


        public static string[] SQLCmds = 
        {
            @"select a.name as 'Staff', b.AnnualAmount as 'Salary', b.AnnualAmount / c.conversionfactor as 'GBP' from Employee a join Salary b on a.id = b.EmployeeID join Currency c on b.CurrencyID = c.Id",
            @"select sum(b.AnnualAmount/c.conversionfactor) as 'Sum Salary in GBP' from Salary b join Currency c on b.CurrencyID = c.Id",
            @"select a.name as 'Staff', b.AnnualAmount as 'Salary', b.AnnualAmount / c.conversionfactor as 'GBP' from Employee a join Salary b on a.id = b.EmployeeID join Currency c on b.CurrencyID = c.Id order by b.AnnualAmount / c.conversionfactor desc",
            @"select * from (select ROW_NUMBER() over (order by GBP desc) as rownum, * from (select a.name as 'Staff', b.AnnualAmount as 'Salary', b.AnnualAmount / c.conversionfactor as 'GBP' from Employee a join Salary b on a.id = b.EmployeeID join Currency c on b.CurrencyID = c.Id) as ta) as tb where rownum between {0} and {1}",
        };
    }
}
