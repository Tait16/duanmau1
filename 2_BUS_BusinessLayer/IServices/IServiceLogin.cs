using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IServiceLogin 
    {
        bool checkLogin(string email, string mk);
        string mahoa(string pass);
        void themTK(NhanVien nhanVien);
        string sendMail(string email, int matkhau);
        int RamdomNumber(int min, int max);
        string checkemail(string email);
        string timmnv(NhanVien nhanVien, string email);
        NhanVien getlistnvtimmnv(string email);
        List< NhanVien> getlistnv();
    }
}
