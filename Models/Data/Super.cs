namespace LGCovid.Models.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Super : DbContext
    {
        public Super()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Expediente> Expedientes { get; set; }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Expediente>()
                .Property(e => e.LGIdNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Expediente>()
                .Property(e => e.Sintomas)
                .IsUnicode(false);

            modelBuilder.Entity<Expediente>()
                .Property(e => e.LugarConsulta)
                .IsUnicode(false);

            modelBuilder.Entity<Expediente>()
                .Property(e => e.DondeSeRealizo)
                .IsUnicode(false);

            modelBuilder.Entity<Expediente>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Expediente>()
                .Property(e => e.FolioIncapacidad)
                .IsUnicode(false);

            modelBuilder.Entity<Expediente>()
                .Property(e => e.PacienteSelforOther)
                .IsUnicode(false);

            modelBuilder.Entity<Expediente>()
                .Property(e => e.TelContacto)
                .IsUnicode(false);

            modelBuilder.Entity<Expediente>()
                .Property(e => e.LastChangeUser)
                .IsUnicode(false);

            modelBuilder.Entity<C__MigrationHistory>()
                .Property(e => e.MigrationId)
                .IsUnicode(false);

            modelBuilder.Entity<C__MigrationHistory>()
                .Property(e => e.ContextKey)
                .IsUnicode(false);

            modelBuilder.Entity<C__MigrationHistory>()
                .Property(e => e.Model)
                .IsFixedLength();

            modelBuilder.Entity<C__MigrationHistory>()
                .Property(e => e.ProductVersion)
                .IsUnicode(false);
        }
    }
}
