using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_Presentation_Layer
{
    public partial class Frm_Register : Form
    {
        IServiceLogin serviceLogin;
        public Frm_Register()
        {
            InitializeComponent();
            serviceLogin = new ServiceLogin();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            if (txt_diachi.Text.Length==0|| txt_manv.Text.Length == 0 || txt_tennv.Text.Length == 0 || 
                txt_email.Text.Length == 0 || txt_matkhau.Text.Length == 0 )            
            {
                MessageBox.Show("moi dien du thong tin", "thong bao");
            }
            nhanVien.Manv = txt_manv.Text;
            nhanVien.Email = txt_email.Text;
            nhanVien.TenNv = txt_tennv.Text;
            nhanVien.DiaChi = txt_diachi.Text;
            nhanVien.MatKhau = serviceLogin.mahoa(txt_matkhau.Text);
            serviceLogin.themTK(nhanVien);            
            Properties.Settings.Default.checkemaillan1 = txt_email.Text;
            Properties.Settings.Default.checkpasslan1 = txt_matkhau.Text;
            Properties.Settings.Default.Save();                        
            this.Hide();
                MessageBox.Show("thanh cong", "thong bao");                
                Frm_Login frm_Login = new Frm_Login();
                frm_Login.Show();           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.Show();
        }
    }
}
