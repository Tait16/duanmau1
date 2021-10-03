using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("KhachHang")]
    public partial class KhachHang
    {
        [Key]
        [StringLength(15)]
        public string Dienthoai { get; set; }
        [StringLength(50)]
        public string TenKhach { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(5)]
        public string Phai { get; set; }
        [StringLength(20)]
        public string Manv { get; set; }

        [ForeignKey(nameof(Manv))]
        [InverseProperty(nameof(NhanVien.KhachHangs))]
        public virtual NhanVien ManvNavigation { get; set; }
    }
}
