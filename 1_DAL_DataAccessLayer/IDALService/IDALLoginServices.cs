using _1_DAL_DataAccessLayer.DALService;
using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IDALService
{
    public interface IDALLoginServices 
    {
        void getLstNV();
        List<NhanVien> getlstNV1();
       
        void addTKhoan(NhanVien nhanVien);
        bool checkmail(string email);
        bool updateNV(NhanVien nhanVien, string email);


    }
}
