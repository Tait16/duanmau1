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
    public partial class Frm_ForgetMK : Form
    {
        IServiceLogin serviceLogin;
        public Frm_ForgetMK()
        {
            InitializeComponent();
            serviceLogin = new ServiceLogin();
        }
        
        private void txt_emailquenmk_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mk = serviceLogin.RamdomNumber(100000000, 999999999);
            MessageBox.Show(serviceLogin.checkemail(txt_emailquenmk.Text), "thong bao");
            
            if (txt_emailquenmk.Text.Length==0)
            {
                MessageBox.Show("moi nhap email", "thong bao");
            }
            if (serviceLogin.checkemail(txt_emailquenmk.Text)== "email hop le")
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien = serviceLogin.getlistnvtimmnv(txt_emailquenmk.Text);
                nhanVien.MatKhau = serviceLogin.mahoa(mk.ToString());
                serviceLogin.timmnv(nhanVien, txt_emailquenmk.Text);
                serviceLogin.sendMail(txt_emailquenmk.Text, mk);
                MessageBox.Show("da gui mk den email cua ban","thong bao");
                this.Hide();
                Frm_Login frm_Login = new Frm_Login();
                frm_Login.Show();
            }
            else
            {
                return;
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.Show();
        }
    }
}
