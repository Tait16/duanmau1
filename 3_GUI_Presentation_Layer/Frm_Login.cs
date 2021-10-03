using _1_DAL_DataAccessLayer.DALService;
using _1_DAL_DataAccessLayer.IDALService;
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

    public partial class Frm_Login : Form
    {
        IServiceLogin serviceLogin;
        IDALLoginServices loginServices;
        public Frm_Login()
        {
            InitializeComponent();
            //loaddata();
            
            serviceLogin = new ServiceLogin();
            
        }
        string _tk;
        string _mk;
        int count=0;
       
            
       
       
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            Frm_Main frm_Main = new Frm_Main();
            
            if (txt_email.Text.Length == 0 || txt_mk.Text.Length == 0)
            {
                MessageBox.Show("dien thieu thong tin", "thong bao");
                return;
            }
            if (serviceLogin.checkLogin(txt_email.Text, serviceLogin.mahoa(txt_mk.Text)))
            {
                Properties.Settings.Default.email= txt_email.Text;
                Properties.Settings.Default.Save();
                if (txt_email.Text==Properties.Settings.Default.checkemaillan1
                    &&txt_mk.Text== Properties.Settings.Default.checkpasslan1)
                {
                    Properties.Settings.Default.Reset();
                    MessageBox.Show("dang nhap lan dau thanh cong, hay doi mat khau", "thong bao");
                    this.Hide();
                    frm_Main.Show();
                    return;
                }
                MessageBox.Show("dang nhap thanh cong", "thong bao");
                this.Hide();
                frm_Main.Show();
            }
            else
            {
                MessageBox.Show("sai mat khau hoac tai khoan");
            }
            

        }
        
        private void lbl_taotk_Click(object sender, EventArgs e)
        {
            
            Frm_Register frm_Register = new Frm_Register();
            this.Hide();
            
            frm_Register.Show();
        }

        private void lbl_quenmatkhau_Click(object sender, EventArgs e)
        {
            Frm_ForgetMK frm_ForgetMK = new Frm_ForgetMK();
            this.Hide();
            frm_ForgetMK.Show();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            txt_email.Text = Properties.Settings.Default.Username;
            
        }

        private void rbt_ghinhotk_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_ghinhotk.Checked)
            {

                _tk = txt_email.Text;
                _mk = txt_mk.Text;
                Properties.Settings.Default.Username = _tk;
                Properties.Settings.Default.Pass = _mk;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Reset();
            }
        }
    }
}
