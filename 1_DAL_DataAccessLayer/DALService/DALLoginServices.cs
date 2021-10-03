using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.DALService
{
    public class DALLoginServices : IDALService.IDALLoginServices
    {
        DatabaseContext DatabaseContext;
        
        List<NhanVien> nhanViens;
        public DALLoginServices()
        {
            DatabaseContext = new DatabaseContext();
            nhanViens = new List<NhanVien>();
            getLstNV();
        }

        public void addTKhoan(NhanVien nhanVien)
        {
            
            nhanVien.Id = nhanViens.Max(c => c.Id + 1);
            
            DatabaseContext.NhanViens.Add(nhanVien);
            DatabaseContext.SaveChanges();
        }
        
        public bool checkmail(string email)
        {
            for (int i = 0; i < nhanViens.Count; i++)
            {
                if (nhanViens[i].Email==email)
                {
                    return true;
                }
            }
            return false;
        }
        public bool updateNV(NhanVien nhanVien, string email)
        {
            for (int i = 0; i < nhanViens.Count; i++)
            {
                if (nhanViens[i].Email==email)
                {
                    
                    DatabaseContext.Update(nhanVien);
                    DatabaseContext.SaveChanges();
                    return true;
                }
            }
            return false;
           
        }
       
       public void getLstNV()
        {
            nhanViens = DatabaseContext.NhanViens.ToList();
        }
        public List<NhanVien> getlstNV1()
        {
            return nhanViens;
        }
      
    }
}
