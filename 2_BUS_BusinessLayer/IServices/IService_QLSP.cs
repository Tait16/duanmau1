using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IService_QLSP
    {
        public List<Hang> getlisthang();
        string AddHANG(Hang hang);
        string XoaHang(Hang hang);
        string SuaHang(Hang hang);
        List<Hang> Search(string tensp);
    }
}
