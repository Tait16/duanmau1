using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.IDALService;
using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.DALService
{
    public class DAL_QLNV : IDALService.IDAL_QLNV
    {
        List<NhanVien> nhanViens;
        DatabaseContext Context;
        public DAL_QLNV()
        {
            nhanViens = new List<NhanVien>();
            Context = new DatabaseContext();
            getLstNV();
        }
        public void getLstNV()
        {
            nhanViens = Context.NhanViens.ToList();
        }
        public List<NhanVien> getlistnv()
        {
            return nhanViens;
        }
        public List<NhanVien> truyenlist(List<NhanVien> list)
        {
             return list = nhanViens;
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
        public void AddNV(NhanVien nhanVien)
        {
            nhanVien.Id = nhanViens.Max(c => c.Id + 1);
            nhanVien.Manv = RandomString(7, true);
            Context.NhanViens.Add(nhanVien);
            
            Context.SaveChanges();
        }
        public void DelNV(NhanVien nhanVien)
        {
            Context.NhanViens.Remove(nhanVien); 
            Context.SaveChanges();
        }
        public void UpdateNV(NhanVien nhanVien)
        {
            Context.NhanViens.Update(nhanVien);
            Context.SaveChanges();
        }
        public void LuuTT()
        {
            Context.SaveChanges();
        }

        
    }
}
