namespace Form_j
{
    partial class Category
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
            this.dtSPSub = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtDSSP = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtCategory = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtSubCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemSub = new System.Windows.Forms.Button();
            this.btnSuaSub = new System.Windows.Forms.Button();
            this.btnLuuSub = new System.Windows.Forms.Button();
            this.btnXoaSub = new System.Windows.Forms.Button();
            this.dtSubCategory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtSPSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDSSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSubCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // dtSPSub
            // 
            this.dtSPSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSPSub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dtSPSub.Location = new System.Drawing.Point(12, 233);
            this.dtSPSub.Name = "dtSPSub";
            this.dtSPSub.Size = new System.Drawing.Size(662, 186);
            this.dtSPSub.TabIndex = 108;
            this.dtSPSub.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtSPSub_CellClick);
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
            this.dtDSSP.Location = new System.Drawing.Point(12, 425);
            this.dtDSSP.Name = "dtDSSP";
            this.dtDSSP.Size = new System.Drawing.Size(662, 201);
            this.dtDSSP.TabIndex = 107;
            this.dtDSSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDSSP_CellClick);
            // 
            // Add
            // 
            this.Add.HeaderText = "Add";
            this.Add.Name = "Add";
            this.Add.Text = "Add";
            this.Add.UseColumnTextForButtonValue = true;
            // 
            // dtCategory
            // 
            this.dtCategory.AllowUserToAddRows = false;
            this.dtCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCategory.Location = new System.Drawing.Point(12, 81);
            this.dtCategory.Name = "dtCategory";
            this.dtCategory.ReadOnly = true;
            this.dtCategory.Size = new System.Drawing.Size(334, 146);
            this.dtCategory.TabIndex = 106;
            this.dtCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCategory_CellClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(496, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 23);
            this.btnXoa.TabIndex = 113;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(592, 10);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 23);
            this.btnLuu.TabIndex = 114;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(393, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 23);
            this.btnSua.TabIndex = 112;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(291, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 23);
            this.btnThem.TabIndex = 111;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 118;
            this.label8.Text = "Category Name";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(92, 12);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(193, 20);
            this.txtCategory.TabIndex = 109;
            // 
            // txtSubCategory
            // 
            this.txtSubCategory.Location = new System.Drawing.Point(92, 43);
            this.txtSubCategory.Name = "txtSubCategory";
            this.txtSubCategory.Size = new System.Drawing.Size(193, 20);
            this.txtSubCategory.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 118;
            this.label1.Text = "SubCategory";
            // 
            // btnThemSub
            // 
            this.btnThemSub.Location = new System.Drawing.Point(291, 41);
            this.btnThemSub.Name = "btnThemSub";
            this.btnThemSub.Size = new System.Drawing.Size(86, 23);
            this.btnThemSub.TabIndex = 111;
            this.btnThemSub.Text = "Thêm";
            this.btnThemSub.UseVisualStyleBackColor = true;
            this.btnThemSub.Click += new System.EventHandler(this.btnThemSub_Click);
            // 
            // btnSuaSub
            // 
            this.btnSuaSub.Location = new System.Drawing.Point(393, 41);
            this.btnSuaSub.Name = "btnSuaSub";
            this.btnSuaSub.Size = new System.Drawing.Size(85, 23);
            this.btnSuaSub.TabIndex = 112;
            this.btnSuaSub.Text = "Sửa";
            this.btnSuaSub.UseVisualStyleBackColor = true;
            this.btnSuaSub.Click += new System.EventHandler(this.btnSuaSub_Click);
            // 
            // btnLuuSub
            // 
            this.btnLuuSub.Location = new System.Drawing.Point(592, 41);
            this.btnLuuSub.Name = "btnLuuSub";
            this.btnLuuSub.Size = new System.Drawing.Size(82, 23);
            this.btnLuuSub.TabIndex = 114;
            this.btnLuuSub.Text = "Lưu";
            this.btnLuuSub.UseVisualStyleBackColor = true;
            this.btnLuuSub.Click += new System.EventHandler(this.btnLuuSub_Click);
            // 
            // btnXoaSub
            // 
            this.btnXoaSub.Location = new System.Drawing.Point(496, 41);
            this.btnXoaSub.Name = "btnXoaSub";
            this.btnXoaSub.Size = new System.Drawing.Size(81, 23);
            this.btnXoaSub.TabIndex = 113;
            this.btnXoaSub.Text = "Xóa";
            this.btnXoaSub.UseVisualStyleBackColor = true;
            this.btnXoaSub.Click += new System.EventHandler(this.btnXoaSub_Click);
            // 
            // dtSubCategory
            // 
            this.dtSubCategory.AllowUserToAddRows = false;
            this.dtSubCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSubCategory.Location = new System.Drawing.Point(352, 81);
            this.dtSubCategory.Name = "dtSubCategory";
            this.dtSubCategory.ReadOnly = true;
            this.dtSubCategory.Size = new System.Drawing.Size(322, 146);
            this.dtSubCategory.TabIndex = 106;
            this.dtSubCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtSubCategory_CellClick);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 720);
            this.Controls.Add(this.btnXoaSub);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuuSub);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSuaSub);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThemSub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSubCategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.dtSPSub);
            this.Controls.Add(this.dtDSSP);
            this.Controls.Add(this.dtSubCategory);
            this.Controls.Add(this.dtCategory);
            this.Name = "Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtSPSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDSSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSubCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtSPSub;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridView dtDSSP;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.DataGridView dtCategory;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtSubCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemSub;
        private System.Windows.Forms.Button btnSuaSub;
        private System.Windows.Forms.Button btnLuuSub;
        private System.Windows.Forms.Button btnXoaSub;
        private System.Windows.Forms.DataGridView dtSubCategory;
    }
}