using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _1_DAL_DataAccessLayer.Models;

#nullable disable

namespace _1_DAL_DataAccessLayer.Context
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Hang> Hangs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-5ONOKUJ\\SQLEXPRESS;Initial Catalog=taitph17683-duanmau;User ID=duanmau;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hang>(entity =>
            {
                entity.HasKey(e => e.MaHang)
                    .HasName("PK__Hang__19C0DB1D9FEEA253");

                entity.Property(e => e.MaHang).ValueGeneratedNever();

                entity.Property(e => e.HinhAnh).IsUnicode(false);

                entity.Property(e => e.Manv).IsUnicode(false);

                entity.HasOne(d => d.ManvNavigation)
                    .WithMany(p => p.Hangs)
                    .HasForeignKey(d => d.Manv)
                    .HasConstraintName("FK__Hang__Manv__267ABA7A");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.Dienthoai)
                    .HasName("PK__KhachHan__04FA51A4ED718676");

                entity.Property(e => e.Dienthoai).IsUnicode(false);

                entity.Property(e => e.Manv).IsUnicode(false);

                entity.HasOne(d => d.ManvNavigation)
                    .WithMany(p => p.KhachHangs)
                    .HasForeignKey(d => d.Manv)
                    .HasConstraintName("FK__KhachHang__Manv__29572725");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.Manv)
                    .HasName("PK__NhanVien__2724CB02272DAADF");

                entity.Property(e => e.Manv).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
