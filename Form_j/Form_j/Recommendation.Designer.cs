namespace Form_j
{
    partial class Recommendation
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
            this.dtDSReCom = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtDSSP = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtREcomSP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtDSReCom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDSSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtREcomSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDSReCom
            // 
            this.dtDSReCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDSReCom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dtDSReCom.Location = new System.Drawing.Point(12, 164);
            this.dtDSReCom.Name = "dtDSReCom";
            this.dtDSReCom.Size = new System.Drawing.Size(662, 186);
            this.dtDSReCom.TabIndex = 105;
            this.dtDSReCom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDSReCom_CellClick);
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
            this.dtDSSP.Location = new System.Drawing.Point(12, 356);
            this.dtDSSP.Name = "dtDSSP";
            this.dtDSSP.Size = new System.Drawing.Size(662, 201);
            this.dtDSSP.TabIndex = 104;
            this.dtDSSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDSSP_CellClick);
            // 
            // Add
            // 
            this.Add.HeaderText = "Add";
            this.Add.Name = "Add";
            this.Add.Text = "Add";
            this.Add.UseColumnTextForButtonValue = true;
            // 
            // dtREcomSP
            // 
            this.dtREcomSP.AllowUserToAddRows = false;
            this.dtREcomSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtREcomSP.Location = new System.Drawing.Point(12, 12);
            this.dtREcomSP.Name = "dtREcomSP";
            this.dtREcomSP.ReadOnly = true;
            this.dtREcomSP.Size = new System.Drawing.Size(662, 146);
            this.dtREcomSP.TabIndex = 103;
            this.dtREcomSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtREcomSP_CellClick);
            // 
            // Recommendation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 566);
            this.Controls.Add(this.dtDSReCom);
            this.Controls.Add(this.dtDSSP);
            this.Controls.Add(this.dtREcomSP);
            this.Name = "Recommendation";
            this.Text = "Recommendation";
            this.Load += new System.EventHandler(this.Recommendation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDSReCom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDSSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtREcomSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtDSReCom;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridView dtDSSP;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.DataGridView dtREcomSP;
    }
}