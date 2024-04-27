using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace VovaPractics.BD
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<Codes> Codes { get; set; }
        public virtual DbSet<MenuFood> MenuFood { get; set; }
        public virtual DbSet<MenuHours> MenuHours { get; set; }
        public virtual DbSet<MenuMerch> MenuMerch { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Time> Time { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Codes>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Codes>()
                .HasMany(e => e.Time)
                .WithRequired(e => e.Codes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MenuFood>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MenuHours>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MenuMerch>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);
        }
    }
}
