using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("Hang")]
    public partial class Hang
    {
        [Key]
        public int MaHang { get; set; }
        [StringLength(50)]
        public string TenHang { get; set; }
        public int? SoLuong { get; set; }
        public double? DonGiaBan { get; set; }
        public double? DonGiaNhap { get; set; }
        [StringLength(400)]
        public string HinhAnh { get; set; }
        [StringLength(20)]
        public string GhiChu { get; set; }
        [StringLength(20)]
        public string Manv { get; set; }

        [ForeignKey(nameof(Manv))]
        [InverseProperty(nameof(NhanVien.Hangs))]
        public virtual NhanVien ManvNavigation { get; set; }
    }
}
