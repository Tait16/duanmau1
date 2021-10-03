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
    public partial class Frm_NhanVien : Form
    {
        int nhacnholuu=0;
        IService_QLNV service_QLNV;
        public Frm_NhanVien()
        {
            InitializeComponent();
            service_QLNV = new Service_QLNV();
            loaddata();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        void loaddata()
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Manv";
            dataGridView1.Columns[1].Name = "Email";
            dataGridView1.Columns[2].Name = "Tennv";
            dataGridView1.Columns[3].Name = "Diachi";
            dataGridView1.Columns[4].Name = "Vaitro";
            dataGridView1.Columns[5].Name = "Tinhtrang";
            dataGridView1.Columns[6].Name = "manv";
            dataGridView1.Columns[6].Visible = false;



            dataGridView1.Rows.Clear();
            foreach (var x in service_QLNV.getlistnv())
            {
                dataGridView1.Rows.Add(x.Manv, x.Email, x.TenNv, x.DiaChi,
                    x.VaiTro == true ? "nhan vien" : "quantri",
                    x.TinhTrang == true ? "hoat dong" : "khong hoat dong",
                    x.Manv) ;
            }
        }
        private void btn_danhsach_Click(object sender, EventArgs e)
        {
            loaddata();
        }
        List<NhanVien> nhanVienlist;
        void loaddata1()
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Manv";
            dataGridView1.Columns[1].Name = "Email";
            dataGridView1.Columns[2].Name = "Tennv";
            dataGridView1.Columns[3].Name = "Diachi";
            dataGridView1.Columns[4].Name = "Vaitro";
            dataGridView1.Columns[5].Name = "Tinhtrang";
            dataGridView1.Columns[6].Name = "manv";
            dataGridView1.Columns[6].Visible = false;



            dataGridView1.Rows.Clear();
            foreach (var x in service_QLNV.loaddatalist(nhanVienlist))
            {
                dataGridView1.Rows.Add(x.Manv, x.Email, x.TenNv, x.DiaChi,
                    x.VaiTro == true ? "nhan vien" : "quantri",
                    x.TinhTrang == true ? "hoat dong" : "khong hoat dong",
                    x.Manv);
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.Email = txt_email.Text;
            nhanVien.DiaChi = txt_diachi.Text;
            nhanVien.TenNv = txt_tennv.Text;
            nhanVien.TinhTrang = cbx_hoatdong.Checked;
            nhanVien.VaiTro = rbt_nhanvien.Checked;
            service_QLNV.ADDNV(nhanVien);
            loaddata1();
            nhacnholuu++;

        }
        string msv; 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == service_QLNV.getlistnv().Count) return;
            txt_email.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            txt_tennv.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            txt_diachi.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            if (dataGridView1.Rows[rowindex].Cells[4].Value.ToString()=="nhan vien")
            {
                rbt_nhanvien.Checked = true;
                rbt_qtri.Checked = false;
            }
            else
            {
                rbt_nhanvien.Checked = false;
                rbt_qtri.Checked = true;
            }
            if (dataGridView1.Rows[rowindex].Cells[5].Value.ToString() == "hoat dong")
            {
                cbx_hoatdong.Checked = true;
                cbx_khonghoatdong.Checked = false;

            }
            else
            {
                cbx_hoatdong.Checked = false;
                cbx_khonghoatdong.Checked = true;
            }
            msv = dataGridView1.Rows[rowindex].Cells[6].Value.ToString();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var xoanv = service_QLNV.getlistnv().Where(c=>c.Manv==msv).FirstOrDefault();
            MessageBox.Show( service_QLNV.delNV(xoanv),"thong bao");
            loaddata();
            nhacnholuu++;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien = service_QLNV.getlistnv().Where(c => c.Manv == msv).FirstOrDefault();
            nhanVien.DiaChi = txt_diachi.Text;
            nhanVien.Email = txt_email.Text;
            nhanVien.TenNv = txt_tennv.Text;
            nhanVien.TinhTrang = cbx_hoatdong.Checked;
            nhanVien.VaiTro = rbt_nhanvien.Checked;

            MessageBox.Show(service_QLNV.UPDATENV(nhanVien), "thong bao");
            loaddata();
            nhacnholuu++;
        }

        private void btn_đong_Click(object sender, EventArgs e)
        {
            if (nhacnholuu>0)
            {
                DialogResult xacnhan = MessageBox.Show("ban co muon luu",
                    "thong bao", MessageBoxButtons.YesNo);
                if (xacnhan == DialogResult.Yes)
                {
                    service_QLNV.luuTT();
                    this.Hide();
                    Frm_Main frm_Main = new Frm_Main();
                    frm_Main.Show();
                    return;
                }

            }
            else
            {
                this.Hide();
                Frm_Main frm_Main = new Frm_Main();
                frm_Main.Show();
            }
            

        }
        void loaddatasearch(string search)
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Manv";
            dataGridView1.Columns[1].Name = "Email";
            dataGridView1.Columns[2].Name = "Tennv";
            dataGridView1.Columns[3].Name = "Diachi";
            dataGridView1.Columns[4].Name = "Vaitro";
            dataGridView1.Columns[5].Name = "Tinhtrang";
            dataGridView1.Columns[6].Name = "manv";
            dataGridView1.Columns[6].Visible = false;



            dataGridView1.Rows.Clear();
            foreach (var x in service_QLNV.SearchNV(search))
            {
                dataGridView1.Rows.Add(x.Manv, x.Email, x.TenNv, x.DiaChi,
                    x.VaiTro == true ? "nhan vien" : "quantri",
                    x.TinhTrang == true ? "hoat dong" : "khong hoat dong",
                    x.Manv);
            }
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            loaddatasearch(txt_timkiem.Text);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            service_QLNV.luuTT();
            loaddata();
        }
    }
}
