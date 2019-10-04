namespace Form_j
{
    partial class TimeBaseDisplay
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
            this.dtDSTR = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFromNgay = new System.Windows.Forms.TextBox();
            this.txtToNgay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThu = new System.Windows.Forms.ComboBox();
            this.txtToGio = new System.Windows.Forms.ComboBox();
            this.txtFromGio = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.calendaR = new System.Windows.Forms.MonthCalendar();
            this.calendaR2 = new System.Windows.Forms.MonthCalendar();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dtTimeRule = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtDSSP = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtDSTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTimeRule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDSSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDSTR
            // 
            this.dtDSTR.AllowUserToAddRows = false;
            this.dtDSTR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDSTR.Location = new System.Drawing.Point(12, 67);
            this.dtDSTR.Name = "dtDSTR";
            this.dtDSTR.ReadOnly = true;
            this.dtDSTR.Size = new System.Drawing.Size(662, 146);
            this.dtDSTR.TabIndex = 0;
            this.dtDSTR.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDSTR_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 90;
            this.label5.Text = "Thứ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "Giờ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "Ngày :";
            // 
            // txtFromNgay
            // 
            this.txtFromNgay.Location = new System.Drawing.Point(62, 12);
            this.txtFromNgay.Name = "txtFromNgay";
            this.txtFromNgay.Size = new System.Drawing.Size(81, 20);
            this.txtFromNgay.TabIndex = 85;
            this.txtFromNgay.Click += new System.EventHandler(this.txtFromNgay_Click);
            // 
            // txtToNgay
            // 
            this.txtToNgay.Location = new System.Drawing.Point(176, 12);
            this.txtToNgay.Name = "txtToNgay";
            this.txtToNgay.Size = new System.Drawing.Size(81, 20);
            this.txtToNgay.TabIndex = 85;
            this.txtToNgay.Click += new System.EventHandler(this.txtToNgay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "->";
            // 
            // txtThu
            // 
            this.txtThu.FormattingEnabled = true;
            this.txtThu.Items.AddRange(new object[] {
            "Thứ 2",
            "Thứ 3",
            "Thứ 4",
            "Thứ 5",
            "Thứ 6",
            "Thứ 7",
            "Chủ Nhật"});
            this.txtThu.Location = new System.Drawing.Point(519, 12);
            this.txtThu.Name = "txtThu";
            this.txtThu.Size = new System.Drawing.Size(106, 21);
            this.txtThu.TabIndex = 93;
            // 
            // txtToGio
            // 
            this.txtToGio.FormattingEnabled = true;
            this.txtToGio.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.txtToGio.Location = new System.Drawing.Point(399, 12);
            this.txtToGio.Name = "txtToGio";
            this.txtToGio.Size = new System.Drawing.Size(62, 21);
            this.txtToGio.TabIndex = 93;
            // 
            // txtFromGio
            // 
            this.txtFromGio.FormattingEnabled = true;
            this.txtFromGio.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.txtFromGio.Location = new System.Drawing.Point(305, 12);
            this.txtFromGio.Name = "txtFromGio";
            this.txtFromGio.Size = new System.Drawing.Size(62, 21);
            this.txtFromGio.TabIndex = 93;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(249, 38);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 23);
            this.btnXoa.TabIndex = 96;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(366, 38);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(108, 23);
            this.btnLuu.TabIndex = 97;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(130, 38);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(113, 23);
            this.btnSua.TabIndex = 95;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 38);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 23);
            this.btnThem.TabIndex = 94;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // calendaR
            // 
            this.calendaR.Location = new System.Drawing.Point(93, 28);
            this.calendaR.Name = "calendaR";
            this.calendaR.TabIndex = 98;
            this.calendaR.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendaR_DateSelected);
            // 
            // calendaR2
            // 
            this.calendaR2.Location = new System.Drawing.Point(216, 28);
            this.calendaR2.Name = "calendaR2";
            this.calendaR2.TabIndex = 99;
            this.calendaR2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendaR2_DateSelected);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(480, 38);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(145, 23);
            this.btnLamMoi.TabIndex = 97;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dtTimeRule
            // 
            this.dtTimeRule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTimeRule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dtTimeRule.Location = new System.Drawing.Point(12, 219);
            this.dtTimeRule.Name = "dtTimeRule";
            this.dtTimeRule.Size = new System.Drawing.Size(662, 186);
            this.dtTimeRule.TabIndex = 102;
            this.dtTimeRule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTimeRule_CellClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // dtDSSP
            // 
            this.dtDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDSSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Add});
            this.dtDSSP.Location = new System.Drawing.Point(12, 411);
            this.dtDSSP.Name = "dtDSSP";
            this.dtDSSP.Size = new System.Drawing.Size(662, 201);
            this.dtDSSP.TabIndex = 100;
            this.dtDSSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDSSP_CellClick);
            // 
            // Add
            // 
            this.Add.HeaderText = "Add";
            this.Add.Name = "Add";
            this.Add.Text = "Add";
            this.Add.UseColumnTextForButtonValue = true;
            // 
            // TimeBaseDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 621);
            this.Controls.Add(this.dtTimeRule);
            this.Controls.Add(this.dtDSSP);
            this.Controls.Add(this.calendaR2);
            this.Controls.Add(this.calendaR);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtFromGio);
            this.Controls.Add(this.txtToGio);
            this.Controls.Add(this.txtThu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToNgay);
            this.Controls.Add(this.txtFromNgay);
            this.Controls.Add(this.dtDSTR);
            this.Name = "TimeBaseDisplay";
            this.Text = "TimeBaseDisplay";
            this.Load += new System.EventHandler(this.TimeBaseDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDSTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTimeRule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDSSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtDSTR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFromNgay;
        private System.Windows.Forms.TextBox txtToNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtThu;
        private System.Windows.Forms.ComboBox txtToGio;
        private System.Windows.Forms.ComboBox txtFromGio;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.MonthCalendar calendaR;
        private System.Windows.Forms.MonthCalendar calendaR2;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dtTimeRule;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridView dtDSSP;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
    }
}