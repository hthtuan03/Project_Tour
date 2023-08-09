namespace Nhom13_QuanLyTourDuLIch.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TourNgoaiNuoc")]
    public partial class TourNgoaiNuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TourNgoaiNuoc()
        {
            HoaDons = new HashSet<HoaDon>();
            HoaDons1 = new HashSet<HoaDon>();
            HoaDons2 = new HashSet<HoaDon>();
        }

        [Key]
        [StringLength(10)]
        public string MaTourNgoaiNuoc { get; set; }

        [StringLength(200)]
        public string TenTourNgoaiNuoc { get; set; }

        public int? SoNguoiDiNgoaiNuoc { get; set; }

        public DateTime? NgayDiNgoaiNuoc { get; set; }

        public DateTime? NgayKetThucNgoaiNuoc { get; set; }

        public double? GiaTourNgoaiNuoc { get; set; }

        [Column(TypeName = "image")]
        public byte[] ImageNN1 { get; set; }

        [Column(TypeName = "image")]
        public byte[] ImageNN2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons2 { get; set; }
    }
}
