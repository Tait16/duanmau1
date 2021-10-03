using _1_DAL_DataAccessLayer.DALService;
using _1_DAL_DataAccessLayer.IDALService;
using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Services
{
    public class ServiceLogin : IServices.IServiceLogin
    {
        IDALLoginServices loginServices;
        List<NhanVien> nhanViens;
        public ServiceLogin()
        {
            loginServices = new DALLoginServices();
        }

        public NhanVien getlistnvtimmnv(string email)
        {
            return loginServices.getlstNV1().Where(c => c.Email == email).FirstOrDefault();
        }

        public bool checkLogin(string email, string mk)
        {            
                foreach (var x in loginServices.getlstNV1())
                {
                    if (x.Email == email && x.MatKhau == mk)
                    {
                        return true;
                    }
                }
                return false;                                  
        }
        public string mahoa(string pass)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] enctypt;
            UTF8Encoding encode = new UTF8Encoding();
            enctypt = md5.ComputeHash(encode.GetBytes(pass));
            StringBuilder encriptdata = new StringBuilder();
            for (int i = 0; i < enctypt.Length; i++)
            {
                encriptdata.Append(enctypt[i].ToString());
            }
            return encriptdata.ToString();
        }
        public void themTK(NhanVien nhanVien)
        {
            loginServices.addTKhoan(nhanVien);
        }
        public string checkemail(string email)
        {
            if (loginServices.checkmail(email))
            {
                return "email hop le";
            }
            return "khong tim thay email";
        }
        public string timmnv(NhanVien nhanVien, string email)
        {
            if (loginServices.updateNV(nhanVien, email))
            {
                return "thanh cong";
            }
            return "that bai";
        }
        public int RamdomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public string sendMail(string email, int matkhau)
        {            
            var mail = new MailMessage();
            var SmtpServer = new SmtpClient();
            SmtpServer.Credentials = new NetworkCredential("taitph17683@fpt.edu.vn", "tsuyokunaru1612");
            SmtpServer.EnableSsl = true;
            mail.From = new MailAddress("taitph17683@fpt.edu.vn","Tran Tai");
            mail.BodyEncoding = mail.SubjectEncoding = Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            mail.To.Add(email);
            mail.Subject = "QUEN MAT KHAU";           
            mail.Body = "mat khau moi cua ban la: " + matkhau;
            SmtpServer.Host = "smtp.gmail.com";
            SmtpServer.Port = 587;           
            SmtpServer.Send(mail);
            return "OK";
        }
        public List<NhanVien> getlistnv()
        {
           return nhanViens = loginServices.getlstNV1();
        }
    }
}
