using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace repositoryPatternDemo.Models.EF
{
    public partial class repositoryDemoDBContext : DbContext
    {
        public repositoryDemoDBContext()
        {
        }

        public repositoryDemoDBContext(DbContextOptions<repositoryDemoDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmpDetil> EmpDetils { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server= WIN8\\NIKHILINSTANCE;database=repositoryDemoDB;integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmpDetil>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("empDetils");

                entity.Property(e => e.EmployeeDesignation)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("employeeDesignation");

                entity.Property(e => e.EmployeeIsPermenant).HasColumnName("employeeIsPermenant");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("employeeName");

                entity.Property(e => e.EmployeePay).HasColumnName("employeePay");

                entity.Property(e => e.EmpployeeNo).HasColumnName("empployeeNo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
