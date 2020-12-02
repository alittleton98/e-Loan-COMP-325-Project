using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eLoan_Project.Models;

namespace eLoan_Project.Data
{
    public class TestTableContext : DbContext
    {
        public TestTableContext(DbContextOptions<TestTableContext> options) : base(options)
        {
        }

        public DbSet<TestTable> testTables { get; set; }
    }
}
