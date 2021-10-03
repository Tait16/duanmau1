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
    public class Service_QLSP: IServices.IService_QLSP
    {
        IDAL_QLSP dAL_QLSP;
        public Service_QLSP()
        {
            dAL_QLSP = new DAL_QLSP();
        }
        public List<Hang> getlisthang()
        {
            return dAL_QLSP.listhang();
        }
        public string AddHANG(Hang hang)
        {
            dAL_QLSP.themHang(hang);
            dAL_QLSP.getListHang();
            return "thanh cong";
        }
        public string XoaHang(Hang hang)
        {
            dAL_QLSP.xoaHang(hang);
            dAL_QLSP.getListHang();
            return "thanh cong";
        }
        public string SuaHang(Hang hang)
        {
            dAL_QLSP.SuaHAng(hang);
            dAL_QLSP.getListHang();
            return "thanh cong";
        }
        public List<Hang> Search(string tensp)
        {
            return dAL_QLSP.listhang().Where(c => c.TenHang.StartsWith(tensp)).ToList();
        }
    }
}
