using _1_DAL_DataAccessLayer.DALService;
using _1_DAL_DataAccessLayer.IDALService;
using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Services
{
    public class Service_QLNV : IServices.IService_QLNV
    {
        List<NhanVien> nhanViens;
        IDAL_QLNV qlnv;
        public Service_QLNV()
        {
            nhanViens = new List<NhanVien>();
            qlnv =  new DAL_QLNV();
        }
        public List<NhanVien> getlistnv()
        {
            return nhanViens = qlnv.getlistnv();
        }
        public void ADDNV(NhanVien nhanVien)
        {
            
            qlnv.AddNV(nhanVien);
            qlnv.getLstNV();

        }
        public List<NhanVien> loaddatalist(List<NhanVien> nhanVien)
        {
            return nhanViens = qlnv.truyenlist(nhanVien);
        }
        public void luuTT()
        {
            qlnv.getLstNV();
            qlnv.LuuTT();
        }
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder sb = new StringBuilder();
            char c;
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                c = Convert.ToChar(Convert.ToInt32(rand.Next(65, 87)));
                sb.Append(c);
            }
            if (lowerCase)
                return sb.ToString().ToLower();
            return sb.ToString();

        }
        public string delNV(NhanVien nhanvien)
        {
            qlnv.DelNV(nhanvien);
            qlnv.getLstNV();
            return "xoa thanh cong";
        }
        public string UPDATENV(NhanVien nhanVien)
        {
            qlnv.UpdateNV(nhanVien);
            qlnv.getLstNV();
            return "sua thanh cong";
        }
        public List<NhanVien> SearchNV(string tennv)
        {
                return qlnv.getlistnv().Where(c => c.TenNv.StartsWith(tennv)).ToList();
        }
    }
}
