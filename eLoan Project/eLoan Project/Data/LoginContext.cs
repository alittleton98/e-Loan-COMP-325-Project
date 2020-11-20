using System;
using Microsoft.EntityFrameworkCore;
using eLoan_Project.Models;

namespace eLoan_Project.Data
{
    public class LoginContext : DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options) : base(options)
        {
        }

        public DbSet<Login> logins { get; set; }
    }
}
