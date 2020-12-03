using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eLoan_Project.Models;
using System.Diagnostics;

namespace eLoan_Project.Data
{
    public class SeedTestData
    {
        public static void Initialize (eLoanContext context)
        {
            context.Database.EnsureCreated();

            if (context.testTables.Any()){
                Trace.WriteLine("Table not empty");
                return;
            }

            var testTables = new TestTable[]
            {
                new TestTable{Id=41177, FirstName = "Andrew"},
                new TestTable{Id=99999, FirstName = "Waffles"},
                new TestTable{Id=12345, FirstName = "Isabella"}
            };

            context.testTables.AddRange(testTables);
            context.SaveChanges();
        }
    }
}
