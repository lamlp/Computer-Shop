namespace Form_j
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTTKhachHang = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSPLienQuan = new System.Windows.Forms.Button();
            this.btnTGHienThi = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDSDonHang = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(2, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnDangXuat);
            this.groupBox1.Controls.Add(this.btnDangNhap);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hệ Thống";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.Image = global::Form_j.Properties.Resources.Custom_Icon_Design_Flatastic_9_Logout;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(423, 21);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(234, 45);
            this.btnDangXuat.TabIndex = 0;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.Image = global::Form_j.Properties.Resources.Custom_Icon_Design_Flatastic_9_Login;
            this.btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDangNhap.Location = new System.Drawing.Point(136, 21);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(234, 45);
            this.btnDangNhap.TabIndex = 0;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.btnTTKhachHang);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(0, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(792, 78);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khách Hàng";
            // 
            // btnTTKhachHang
            // 
            this.btnTTKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTTKhachHang.Image = global::Form_j.Properties.Resources.Custom_Icon_Design_Pretty_Office_2_Personal_information;
            this.btnTTKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTTKhachHang.Location = new System.Drawing.Point(135, 18);
            this.btnTTKhachHang.Name = "btnTTKhachHang";
            this.btnTTKhachHang.Size = new System.Drawing.Size(235, 45);
            this.btnTTKhachHang.TabIndex = 0;
            this.btnTTKhachHang.Text = "Thông Tin Khách Hàng";
            this.btnTTKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTTKhachHang.UseVisualStyleBackColor = true;
            this.btnTTKhachHang.Click += new System.EventHandler(this.btnTTKhachHang_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.btnSPLienQuan);
            this.groupBox3.Controls.Add(this.btnTGHienThi);
            this.groupBox3.Controls.Add(this.btnSanPham);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(792, 139);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sản Phẩm";
            // 
            // btnSPLienQuan
            // 
            this.btnSPLienQuan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSPLienQuan.Image = global::Form_j.Properties.Resources.Custom_Icon_Design_Pretty_Office_3_Product_sales_report;
            this.btnSPLienQuan.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSPLienQuan.Location = new System.Drawing.Point(136, 79);
            this.btnSPLienQuan.Name = "btnSPLienQuan";
            this.btnSPLienQuan.Size = new System.Drawing.Size(234, 45);
            this.btnSPLienQuan.TabIndex = 0;
            this.btnSPLienQuan.Text = "Sản Phẩm Liên Quan";
            this.btnSPLienQuan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSPLienQuan.UseVisualStyleBackColor = true;
            this.btnSPLienQuan.Click += new System.EventHandler(this.btnSPLienQuan_Click);
            // 
            // btnTGHienThi
            // 
            this.btnTGHienThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTGHienThi.Image = global::Form_j.Properties.Resources.Oxygen_Icons_org_Oxygen_Apps_preferences_system_time;
            this.btnTGHienThi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTGHienThi.Location = new System.Drawing.Point(423, 19);
            this.btnTGHienThi.Name = "btnTGHienThi";
            this.btnTGHienThi.Size = new System.Drawing.Size(234, 45);
            this.btnTGHienThi.TabIndex = 0;
            this.btnTGHienThi.Text = "Thời Gian Hiển Thị";
            this.btnTGHienThi.UseVisualStyleBackColor = true;
            this.btnTGHienThi.Click += new System.EventHandler(this.btnTGHienThi_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanPham.Image = global::Form_j.Properties.Resources.Itzikgur_My_Seven_Books_2;
            this.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSanPham.Location = new System.Drawing.Point(136, 19);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(234, 45);
            this.btnSanPham.TabIndex = 0;
            this.btnSanPham.Text = "Sản Phẩm";
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox4.Controls.Add(this.btnDSDonHang);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 301);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(792, 80);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Đơn Hàng";
            // 
            // btnDSDonHang
            // 
            this.btnDSDonHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDSDonHang.Image = global::Form_j.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_view_list_details;
            this.btnDSDonHang.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDSDonHang.Location = new System.Drawing.Point(136, 22);
            this.btnDSDonHang.Name = "btnDSDonHang";
            this.btnDSDonHang.Size = new System.Drawing.Size(234, 41);
            this.btnDSDonHang.TabIndex = 0;
            this.btnDSDonHang.Text = "Danh Sách Đơn Hàng";
            this.btnDSDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDSDonHang.UseVisualStyleBackColor = true;
            this.btnDSDonHang.Click += new System.EventHandler(this.btnDSDonHang_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox5.Controls.Add(this.btnDanhMuc);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(0, 381);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(792, 89);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh Mục";
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDanhMuc.Image = global::Form_j.Properties.Resources.Sbstnblnd_Plateau_Apps_menu_editor;
            this.btnDanhMuc.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDanhMuc.Location = new System.Drawing.Point(135, 24);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(235, 41);
            this.btnDanhMuc.TabIndex = 0;
            this.btnDanhMuc.Text = "Danh Mục";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(792, 480);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Quản Lý Bán Hàng Điện Tử";
            this.Load += new System.EventHandler(this.Main_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTTKhachHang;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnSPLienQuan;
        private System.Windows.Forms.Button btnTGHienThi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDSDonHang;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDanhMuc;
    }
}