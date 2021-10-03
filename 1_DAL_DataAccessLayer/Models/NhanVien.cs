using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("NhanVien")]
    public partial class NhanVien
    {
        public NhanVien()
        {
            Hangs = new HashSet<Hang>();
            KhachHangs = new HashSet<KhachHang>();
        }

        [Column("ID")]
        public int? Id { get; set; }
        [Key]
        [StringLength(20)]
        public string Manv { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string TenNv { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        public bool? VaiTro { get; set; }
        public bool? TinhTrang { get; set; }
        [StringLength(50)]
        public string MatKhau { get; set; }

        [InverseProperty(nameof(Hang.ManvNavigation))]
        public virtual ICollection<Hang> Hangs { get; set; }
        [InverseProperty(nameof(KhachHang.ManvNavigation))]
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
    }
}
