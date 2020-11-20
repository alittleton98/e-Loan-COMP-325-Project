using System;
using Microsoft.EntityFrameworkCore;
using eLoan_Project.Models;

namespace eLoan_Project.Data
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {
        }

        public DbSet<Bank> banks { get; set; }
    }
}
