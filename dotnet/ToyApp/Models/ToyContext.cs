using System;
using Microsoft.EntityFrameworkCore;

namespace ToyApp.Models
{
    public class ToyContext : DbContext
    {
        public ToyContext(DbContextOptions<ToyContext> options)
    : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<MicroPost> MicroPost { get; set; }
    }
}
