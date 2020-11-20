using System;
using Microsoft.EntityFrameworkCore;
using eLoan_Project.Models;

namespace eLoan_Project.Data
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }

        public DbSet<Customer> customers { get; set; }
    }
}
