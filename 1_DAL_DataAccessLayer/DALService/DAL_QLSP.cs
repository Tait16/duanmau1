using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.DALService
{
    public class DAL_QLSP : IDALService.IDAL_QLSP
    {
        List<Hang> hangs = new List<Hang>();
        List<Hang> hangsearch = new List<Hang>();
        DatabaseContext databaseContext;
        public DAL_QLSP()
        {
            databaseContext = new DatabaseContext();
            getListHang();
        }
        public void getListHang()
        {
            hangs = databaseContext.Hangs.ToList();
        }
        public List<Hang> listhang()
        {
            return hangs;
        }
        public void themHang(Hang hang)
        {
            databaseContext.Hangs.Add(hang);
            databaseContext.SaveChanges();
        }
        public void xoaHang(Hang hang)
        {
            databaseContext.Hangs.Remove(hang);
            databaseContext.SaveChanges();
        }
        public void SuaHAng(Hang hang)
        {
            databaseContext.Hangs.Update(hang);
            databaseContext.SaveChanges();
        }
       
    }
}
