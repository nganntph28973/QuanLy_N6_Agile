using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QuanLy_N6_Agile.Models
{
    public partial class QL_N6_AgileContext : DbContext
    {
        public QL_N6_AgileContext()
        {
        }

        public QL_N6_AgileContext(DbContextOptions<QL_N6_AgileContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Grade> Grades { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-E5ECEDOO\\SQLEXPRESS;Database=QL_N6_Agile;Trusted_Connection=True; TrustServerCertificate =True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grade>(entity =>
            {
                entity.ToTable("Grade");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Gdtc).HasColumnName("GDTC");

                entity.Property(e => e.Masv)
                    .HasMaxLength(5)
                    .HasColumnName("MASV");

                entity.Property(e => e.Tienganh).HasColumnName("TIENGANH");

                entity.Property(e => e.Tinhoc).HasColumnName("TINHOC");

                entity.HasOne(d => d.MasvNavigation)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.Masv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Grade__MASV__4BAC3F29");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Masv)
                    .HasName("PK__Student__60228A2836E12407");

                entity.ToTable("Student");

                entity.Property(e => e.Masv)
                    .HasMaxLength(5)
                    .HasColumnName("MASV");

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gioitinh).HasMaxLength(3);

                entity.Property(e => e.Hoten).HasMaxLength(50);

                entity.Property(e => e.SoDt)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SoDT");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__User__F3DBC573CBA1D6F2");

                entity.ToTable("User");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .HasColumnName("role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
