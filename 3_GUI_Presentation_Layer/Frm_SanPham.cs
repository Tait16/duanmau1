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
    public partial class Frm_SanPham : Form
    {
        IService_QLSP service_QLSP;
        IService_QLNV service_QLNV;
        public Frm_SanPham()
        {
            InitializeComponent();
            service_QLSP = new Service_QLSP();
            service_QLNV = new Service_QLNV();
            loaddata();
        }
        void loaddata()
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "MA HANG";
            dataGridView1.Columns[1].Name = "TEN HANG";
            dataGridView1.Columns[2].Name = "SO LUONG";
            dataGridView1.Columns[3].Name = "DON GIA NHAP";
            dataGridView1.Columns[4].Name = "DON GIA BAN";          
            dataGridView1.Columns[5].Name = "GHI CHU";
            dataGridView1.Columns[6].Name = "MANV";
            dataGridView1.Rows.Clear();
            foreach (var x in service_QLSP.getlisthang())
            {
                dataGridView1.Rows.Add(x.MaHang, x.TenHang, x.SoLuong, x.DonGiaNhap, x.DonGiaBan, x.GhiChu,x.Manv);
            }

        }
        
        private void btn_them_Click(object sender, EventArgs e)
        {
            
            Hang hang = new Hang();
            hang.MaHang = Convert.ToInt32( txt_mahang.Text);
            hang.TenHang = txt_tenhang.Text;
            hang.SoLuong = Convert.ToInt32(txt_soluong.Text);
            hang.DonGiaNhap = Convert.ToInt32(txt_dongianhap.Text);
            hang.DonGiaBan = Convert.ToInt32(txt_dongiaban.Text);
            hang.GhiChu = txt_ghichu.Text;
            hang.Manv = service_QLNV.getlistnv().Where(
                c=>c.Email==Properties.Settings.Default.email).Select(c=>c.Manv).FirstOrDefault();
            MessageBox.Show(service_QLSP.AddHANG(hang), "thong bao");
            loaddata();
        }
        
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            Hang hang = new Hang();
            hang = service_QLSP.getlisthang().Where(c => c.MaHang == Convert.ToInt32(txt_mahang.Text)
            ).FirstOrDefault();
            MessageBox.Show( service_QLSP.XoaHang(hang),"thong bao");
            loaddata();
        }
        string mnv;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == service_QLSP.getlisthang().Count) return;
            txt_mahang.Text = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            txt_tenhang.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            txt_soluong.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            txt_dongianhap.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            txt_dongiaban.Text = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
            txt_ghichu.Text = dataGridView1.Rows[rowindex].Cells[5].Value.ToString(); 
            mnv = dataGridView1.Rows[rowindex].Cells[6].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Hang hang = new Hang();
            hang = service_QLSP.getlisthang().Where(c => c.MaHang == Convert.ToInt32(txt_mahang.Text)
            ).FirstOrDefault();
            hang.TenHang = txt_tenhang.Text;
            hang.SoLuong = Convert.ToInt32( txt_soluong.Text);
            hang.GhiChu = txt_ghichu.Text;
            hang.DonGiaNhap = Convert.ToInt32( txt_dongianhap.Text);
            hang.DonGiaBan = Convert.ToInt32(txt_dongiaban.Text);
            service_QLSP.SuaHang(hang);
            loaddata();


        }

        private void btn_dánhach_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {

        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Main frm_Main = new Frm_Main();
            frm_Main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loaddatasearch(txt_timkiem.Text);
        }
        void loaddatasearch(string tensp)
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "MA HANG";
            dataGridView1.Columns[1].Name = "TEN HANG";
            dataGridView1.Columns[2].Name = "SO LUONG";
            dataGridView1.Columns[3].Name = "DON GIA NHAP";
            dataGridView1.Columns[4].Name = "DON GIA BAN";
            dataGridView1.Columns[5].Name = "GHI CHU";
            dataGridView1.Columns[6].Name = "MANV";
            dataGridView1.Rows.Clear();
            foreach (var x in service_QLSP.Search(tensp))
            {
                dataGridView1.Rows.Add(x.MaHang, x.TenHang, x.SoLuong, x.DonGiaNhap, x.DonGiaBan, x.GhiChu, x.Manv);
            }

        }
    }
}
