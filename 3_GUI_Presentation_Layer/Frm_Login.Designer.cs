
namespace _3_GUI_Presentation_Layer
{
    partial class Frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_dangnhap = new System.Windows.Forms.Label();
            this.lbl_nhapemail = new System.Windows.Forms.Label();
            this.lbl_nhapmatkhau = new System.Windows.Forms.Label();
            this.lbl_quenmatkhau = new System.Windows.Forms.Label();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.rbt_ghinhotk = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_taotk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_dangnhap
            // 
            this.lbl_dangnhap.AutoSize = true;
            this.lbl_dangnhap.Location = new System.Drawing.Point(204, 102);
            this.lbl_dangnhap.Name = "lbl_dangnhap";
            this.lbl_dangnhap.Size = new System.Drawing.Size(138, 15);
            this.lbl_dangnhap.TabIndex = 0;
            this.lbl_dangnhap.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // lbl_nhapemail
            // 
            this.lbl_nhapemail.AutoSize = true;
            this.lbl_nhapemail.Location = new System.Drawing.Point(106, 147);
            this.lbl_nhapemail.Name = "lbl_nhapemail";
            this.lbl_nhapemail.Size = new System.Drawing.Size(77, 15);
            this.lbl_nhapemail.TabIndex = 0;
            this.lbl_nhapemail.Text = "NHẬP EMAIL";
            // 
            // lbl_nhapmatkhau
            // 
            this.lbl_nhapmatkhau.AutoSize = true;
            this.lbl_nhapmatkhau.Location = new System.Drawing.Point(106, 207);
            this.lbl_nhapmatkhau.Name = "lbl_nhapmatkhau";
            this.lbl_nhapmatkhau.Size = new System.Drawing.Size(103, 15);
            this.lbl_nhapmatkhau.TabIndex = 0;
            this.lbl_nhapmatkhau.Text = "NHẬP MẬT KHẨU";
            // 
            // lbl_quenmatkhau
            // 
            this.lbl_quenmatkhau.AutoSize = true;
            this.lbl_quenmatkhau.Location = new System.Drawing.Point(353, 267);
            this.lbl_quenmatkhau.Name = "lbl_quenmatkhau";
            this.lbl_quenmatkhau.Size = new System.Drawing.Size(102, 15);
            this.lbl_quenmatkhau.TabIndex = 0;
            this.lbl_quenmatkhau.Text = "QUÊN MẬT KHẨU";
            this.lbl_quenmatkhau.Click += new System.EventHandler(this.lbl_quenmatkhau_Click);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Location = new System.Drawing.Point(204, 319);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(138, 40);
            this.btn_dangnhap.TabIndex = 1;
            this.btn_dangnhap.Text = "ĐĂNG NHẬP";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(204, 380);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(138, 40);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "THOAT";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(106, 166);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(349, 23);
            this.txt_email.TabIndex = 2;
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(106, 225);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(349, 23);
            this.txt_mk.TabIndex = 2;
            // 
            // rbt_ghinhotk
            // 
            this.rbt_ghinhotk.AutoSize = true;
            this.rbt_ghinhotk.Location = new System.Drawing.Point(106, 265);
            this.rbt_ghinhotk.Name = "rbt_ghinhotk";
            this.rbt_ghinhotk.Size = new System.Drawing.Size(139, 19);
            this.rbt_ghinhotk.TabIndex = 3;
            this.rbt_ghinhotk.TabStop = true;
            this.rbt_ghinhotk.Text = "GHI NHỚ TÀI KHOẢN";
            this.rbt_ghinhotk.UseVisualStyleBackColor = true;
            this.rbt_ghinhotk.CheckedChanged += new System.EventHandler(this.rbt_ghinhotk_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_3_GUI_Presentation_Layer.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(227, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 75);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_taotk
            // 
            this.lbl_taotk.AutoSize = true;
            this.lbl_taotk.Location = new System.Drawing.Point(353, 292);
            this.lbl_taotk.Name = "lbl_taotk";
            this.lbl_taotk.Size = new System.Drawing.Size(94, 15);
            this.lbl_taotk.TabIndex = 0;
            this.lbl_taotk.Text = "TẠO TÀI KHOẢN";
            this.lbl_taotk.Click += new System.EventHandler(this.lbl_taotk_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbt_ghinhotk);
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.lbl_taotk);
            this.Controls.Add(this.lbl_quenmatkhau);
            this.Controls.Add(this.lbl_nhapmatkhau);
            this.Controls.Add(this.lbl_nhapemail);
            this.Controls.Add(this.lbl_dangnhap);
            this.Name = "Frm_Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dangnhap;
        private System.Windows.Forms.Label lbl_nhapemail;
        private System.Windows.Forms.Label lbl_nhapmatkhau;
        private System.Windows.Forms.Label lbl_quenmatkhau;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.RadioButton rbt_ghinhotk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_taotk;
    }
}

