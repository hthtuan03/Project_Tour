using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Nhom13_QuanLyTourDuLIch.Model
{
    public partial class DuLichDB : DbContext
    {
        public DuLichDB()
            : base("name=DuLichDB1")
        {
        }

        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<TourNgoaiNuoc> TourNgoaiNuocs { get; set; }
        public virtual DbSet<TourTrongNuoc> TourTrongNuocs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaTourTrongNuoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaTourNgoaiNuoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.KhachHang)
                .HasForeignKey(e => e.MaKH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDons1)
                .WithRequired(e => e.KhachHang1)
                .HasForeignKey(e => e.MaKH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.NhanVien)
                .HasForeignKey(e => e.MaNV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HoaDons1)
                .WithRequired(e => e.NhanVien1)
                .HasForeignKey(e => e.MaNV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HoaDons2)
                .WithRequired(e => e.NhanVien2)
                .HasForeignKey(e => e.MaNV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TourNgoaiNuoc>()
                .Property(e => e.MaTourNgoaiNuoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TourNgoaiNuoc>()
                .HasMany(e => e.HoaDons)
                .WithOptional(e => e.TourNgoaiNuoc)
                .HasForeignKey(e => e.MaTourNgoaiNuoc);

            modelBuilder.Entity<TourNgoaiNuoc>()
                .HasMany(e => e.HoaDons1)
                .WithOptional(e => e.TourNgoaiNuoc1)
                .HasForeignKey(e => e.MaTourNgoaiNuoc);

            modelBuilder.Entity<TourNgoaiNuoc>()
                .HasMany(e => e.HoaDons2)
                .WithOptional(e => e.TourNgoaiNuoc2)
                .HasForeignKey(e => e.MaTourNgoaiNuoc);

            modelBuilder.Entity<TourTrongNuoc>()
                .Property(e => e.MaTourTrongNuoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TourTrongNuoc>()
                .HasMany(e => e.HoaDons)
                .WithOptional(e => e.TourTrongNuoc)
                .HasForeignKey(e => e.MaTourTrongNuoc);

            modelBuilder.Entity<TourTrongNuoc>()
                .HasMany(e => e.HoaDons1)
                .WithOptional(e => e.TourTrongNuoc1)
                .HasForeignKey(e => e.MaTourTrongNuoc);

            modelBuilder.Entity<TourTrongNuoc>()
                .HasMany(e => e.HoaDons2)
                .WithOptional(e => e.TourTrongNuoc2)
                .HasForeignKey(e => e.MaTourTrongNuoc);
        }
    }
}
