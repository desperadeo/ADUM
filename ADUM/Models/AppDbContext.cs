using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADUM.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        public DbSet<Token> Tokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Token>().HasData(
                new Token { Id = 1, SamAccountName = "dan", ADGroup = "G_INF_ADM", StartTime = new DateTime(2021, 03, 15, 08, 04, 14), ExpiredTime = new DateTime(2021, 03, 15, 08, 09, 14), Status = 0 },
                new Token { Id = 2, SamAccountName = "toan", ADGroup = "G_INF_ADM", StartTime = new DateTime(2021, 03, 20, 18, 24, 14), ExpiredTime = new DateTime(2021, 03, 20, 18, 34, 14), Status = 0 },
                new Token { Id = 3, SamAccountName = "alex", ADGroup = "G_INF_ADM", StartTime = new DateTime(2021, 03, 21, 12, 04, 14), ExpiredTime = new DateTime(2021, 03, 21, 20, 04, 14), Status = 0 }
                );
        }
    }
}
