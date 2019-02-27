using System;
using HSpider.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HSpider.Web
{
    public class HSpiderContext : DbContext
    {
        public HSpiderContext()
        {
        }

        public HSpiderContext(DbContextOptions<HSpiderContext> options)
            : base(options)
        {
        }

        public DbSet<Comic> Comics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<Comic>(entity =>
            {
                entity.Property(e => e.GrabDate).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });
        }
    }
}
