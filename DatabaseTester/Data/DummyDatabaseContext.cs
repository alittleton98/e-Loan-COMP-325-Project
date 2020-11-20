using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseTester.Models;

namespace DatabaseTester
{
    public class DummyDatabaseContext : DbContext
    {
        public DummyDatabaseContext(DbContextOptions<DummyDatabaseContext> options) : base(options)
        {

        }

        public DbSet<DummyTable_Person> Person {get; set;}
    }
}
