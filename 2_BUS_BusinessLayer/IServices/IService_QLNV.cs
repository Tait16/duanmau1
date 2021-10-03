using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IService_QLNV
    {
        List<NhanVien> getlistnv();
        void ADDNV(NhanVien nhanVien);
        string delNV(NhanVien nhanvien);
        string UPDATENV(NhanVien nhanVien);
        List<NhanVien> SearchNV(string tennv);
        void luuTT();
        List<NhanVien> loaddatalist(List<NhanVien> nhanVien);
    }
}
