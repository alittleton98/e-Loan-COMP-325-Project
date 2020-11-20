using System;
using Microsoft.EntityFrameworkCore;
using eLoan_Project.Models;

namespace eLoan_Project.Data
{
    public class LoanContext : DbContext
    {
        public LoanContext(DbContextOptions<LoanContext> options) : base(options)
        {
        }

        public DbSet<Loan> loans { get; set; }
    }
}
