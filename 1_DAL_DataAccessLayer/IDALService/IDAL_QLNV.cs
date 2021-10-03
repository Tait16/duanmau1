using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IDALService
{
    public interface IDAL_QLNV
    {
        List<NhanVien> getlistnv();
        void AddNV(NhanVien nhanVien);
        void LuuTT();
        void getLstNV();
        void DelNV(NhanVien nhanVien);
        void UpdateNV(NhanVien nhanVien);
        List<NhanVien> truyenlist(List<NhanVien> list);
    }
}
