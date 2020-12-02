using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eLoan_Project.Models;

namespace eLoan_Project.Data
{
    public class SeedTestData
    {
        public static void Initialize (eLoanContext context)
        {
            context.Database.EnsureCreated();

            var testTables = new TestTable[]
            {
                new TestTable{Id=41177, FirstName = "Andrew"},
                new TestTable{Id=99999, FirstName = "Waffles"},
                new TestTable{FirstName = "Isabella"}
            };

            context.testTables.AddRange(testTables);
            context.SaveChanges();
        }
    }
}
