using API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
    }
}