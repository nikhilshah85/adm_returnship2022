using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace employeeManagementWebAPI.Models.EF
{
    public partial class employeeDBContext : DbContext
    {
        public employeeDBContext()
        {
        }

        public employeeDBContext(DbContextOptions<employeeDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DeptInfo> DeptInfos { get; set; } = null!;
        public virtual DbSet<EmployeeInfo> EmployeeInfos { get; set; } = null!;
        public virtual DbSet<Register> Registers { get; set; } = null!;
        public virtual DbSet<UserLoginInfo> UserLoginInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=WIN8\\NIKHILINSTANCE;database=employeeDB;integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeptInfo>(entity =>
            {
                entity.HasKey(e => e.DeptNo)
                    .HasName("PK__deptInfo__BE2D3F555CC3F920");

                entity.ToTable("deptInfo");

                entity.Property(e => e.DeptNo)
                    .ValueGeneratedNever()
                    .HasColumnName("deptNo");

                entity.Property(e => e.DeptLocaton)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("deptLocaton");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("deptName");
            });

            modelBuilder.Entity<EmployeeInfo>(entity =>
            {
                entity.HasKey(e => e.EmpNo)
                    .HasName("PK__employee__AFB335929D89AE20");

                entity.ToTable("employeeInfo");

                entity.Property(e => e.EmpNo)
                    .ValueGeneratedNever()
                    .HasColumnName("empNo");

                entity.Property(e => e.EmpDept).HasColumnName("empDept");

                entity.Property(e => e.EmpDesigantion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("empDesigantion");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("empName");

                entity.Property(e => e.EmpSalary).HasColumnName("empSalary");

                entity.HasOne(d => d.EmpDeptNavigation)
                    .WithMany(p => p.EmployeeInfos)
                    .HasForeignKey(d => d.EmpDept)
                    .HasConstraintName("fk_empDept");
            });

            modelBuilder.Entity<Register>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.RId).HasColumnName("rId");

                entity.Property(e => e.RName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("rName");
            });

            modelBuilder.Entity<UserLoginInfo>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PK__UserLogi__66DCF95D7A876F5E");

                entity.ToTable("UserLoginInfo");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("userName");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
