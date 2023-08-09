namespace Nhom13_QuanLyTourDuLIch.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        public DateTime? NgayLapHD { get; set; }

        public double? TongTien { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNV { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKH { get; set; }

        [StringLength(10)]
        public string MaTourTrongNuoc { get; set; }

        [StringLength(10)]
        public string MaTourNgoaiNuoc { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual KhachHang KhachHang1 { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual NhanVien NhanVien1 { get; set; }

        public virtual NhanVien NhanVien2 { get; set; }

        public virtual TourNgoaiNuoc TourNgoaiNuoc { get; set; }

        public virtual TourNgoaiNuoc TourNgoaiNuoc1 { get; set; }

        public virtual TourNgoaiNuoc TourNgoaiNuoc2 { get; set; }

        public virtual TourTrongNuoc TourTrongNuoc { get; set; }

        public virtual TourTrongNuoc TourTrongNuoc1 { get; set; }

        public virtual TourTrongNuoc TourTrongNuoc2 { get; set; }
    }
}
