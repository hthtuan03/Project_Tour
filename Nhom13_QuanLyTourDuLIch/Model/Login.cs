namespace Nhom13_QuanLyTourDuLIch.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login")]
    public partial class Login
    {
        [Key]
        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(20)]
        public string Password { get; set; }
    }
}
