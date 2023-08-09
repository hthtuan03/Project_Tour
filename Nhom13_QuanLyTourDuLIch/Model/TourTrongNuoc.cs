namespace Nhom13_QuanLyTourDuLIch.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TourTrongNuoc")]
    public partial class TourTrongNuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TourTrongNuoc()
        {
            HoaDons = new HashSet<HoaDon>();
            HoaDons1 = new HashSet<HoaDon>();
            HoaDons2 = new HashSet<HoaDon>();
        }

        [Key]
        [StringLength(10)]
        public string MaTourTrongNuoc { get; set; }

        [StringLength(200)]
        public string TenTourTrongNuoc { get; set; }

        public int? SoNguoiDiTrongNuoc { get; set; }

        public DateTime? NgayDiTrongNuoc { get; set; }

        public DateTime? NgayKetThucTrongNuoc { get; set; }

        public double? GiaTourTrongNuoc { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image1 { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons2 { get; set; }
    }
}
