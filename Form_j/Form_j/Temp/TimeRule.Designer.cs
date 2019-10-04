namespace Form_j
{
    partial class TimeRule
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
            this.dtTimeBase = new System.Windows.Forms.DataGridView();
            this.dtDSSP = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtTimeRule = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtTimeBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDSSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTimeRule)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTimeBase
            // 
            this.dtTimeBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTimeBase.Location = new System.Drawing.Point(12, 12);
            this.dtTimeBase.Name = "dtTimeBase";
            this.dtTimeBase.Size = new System.Drawing.Size(696, 176);
            this.dtTimeBase.TabIndex = 0;
            this.dtTimeBase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTimeBase_CellClick);
            // 
            // dtDSSP
            // 
            this.dtDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDSSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Add});
            this.dtDSSP.Location = new System.Drawing.Point(12, 386);
            this.dtDSSP.Name = "dtDSSP";
            this.dtDSSP.Size = new System.Drawing.Size(696, 201);
            this.dtDSSP.TabIndex = 0;
            this.dtDSSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDSSP_CellClick);
            // 
            // Add
            // 
            this.Add.HeaderText = "Add";
            this.Add.Name = "Add";
            this.Add.Text = "Add";
            this.Add.UseColumnTextForButtonValue = true;
            // 
            // dtTimeRule
            // 
            this.dtTimeRule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTimeRule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dtTimeRule.Location = new System.Drawing.Point(12, 194);
            this.dtTimeRule.Name = "dtTimeRule";
            this.dtTimeRule.Size = new System.Drawing.Size(695, 186);
            this.dtTimeRule.TabIndex = 1;
            this.dtTimeRule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTimeRule_CellClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // TimeRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 596);
            this.Controls.Add(this.dtTimeRule);
            this.Controls.Add(this.dtDSSP);
            this.Controls.Add(this.dtTimeBase);
            this.Name = "TimeRule";
            this.Text = "TimeRule";
            this.Load += new System.EventHandler(this.TimeRule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTimeBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDSSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTimeRule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtTimeBase;
        private System.Windows.Forms.DataGridView dtDSSP;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.DataGridView dtTimeRule;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}