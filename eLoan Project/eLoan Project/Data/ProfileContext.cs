using System;
using Microsoft.EntityFrameworkCore;
using eLoan_Project.Models;

namespace eLoan_Project.Data
{
    public class ProfileContext : DbContext
    {
        public ProfileContext(DbContextOptions<ProfileContext> options) : base(options)
        {
        }

        public DbSet<Profile> profiles { get; set; }
    }
}
