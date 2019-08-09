using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KLOVE_ASSIGNMENT.Models
{
    public partial class KLOVEContext : DbContext
    {
        public KLOVEContext()
        {
        }

        public KLOVEContext(DbContextOptions<KLOVEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Employeedepartment> Employeedepartment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=KLOVE;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("DEPARTMENT");

                entity.Property(e => e.DepartmentID).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("EMPLOYEE");

                entity.Property(e => e.EmployeeID).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeContact).HasMaxLength(50);

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Employeedepartment>(entity =>
            {
                entity.ToTable("Employeedepartment");

                entity.Property(e => e.ID).HasColumnName("ID");

                entity.Property(e => e.EmployeeID).HasColumnName("EmployeeID");

                entity.Property(e => e.DepartmentID).HasColumnName("DepartmentID");
            });
        }
    }
}
