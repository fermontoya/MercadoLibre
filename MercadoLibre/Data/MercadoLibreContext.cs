using System;
using MercadoLibre.Models;
using Microsoft.EntityFrameworkCore;

namespace MercadoLibre.Data
{
    public partial class MercadoLibreContext : DbContext
    {
        public MercadoLibreContext() { }
        public MercadoLibreContext(DbContextOptions<MercadoLibreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Condicion> Condicion { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Condicion>(entity =>
            {
                entity.Property(e => e.Adn)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
