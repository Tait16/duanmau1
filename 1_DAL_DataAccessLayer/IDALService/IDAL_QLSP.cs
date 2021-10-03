using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IDALService
{
    public interface IDAL_QLSP
    {
        List<Hang> listhang();
        void themHang(Hang hang);
        void getListHang();
        void xoaHang(Hang hang);
        void SuaHAng(Hang hang);
      
    }
}
