using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_j
{
    public partial class SanPham : Form
    {
        WS.WScode sv = new WS.WScode();
        WS.ProductDTO[] list;
        WS.ProductDTO pro = new WS.ProductDTO();
        int proID;
        bool them;
        public SanPham()
        {
            InitializeComponent();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            HienThi();
        }


        private void dtDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenSP.ReadOnly = true;
            txtGia.ReadOnly = true;
            txtGhiChu.ReadOnly = true;
            txtImage.ReadOnly = true;
            try
            {
                proID = int.Parse(dtDSSP.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTenSP.Text = dtDSSP.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtGia.Text = dtDSSP.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtImage.Text = dtDSSP.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGhiChu.Text = dtDSSP.Rows[e.RowIndex].Cells[4].Value.ToString();
                ThayHinh();
            }
                catch
            {

                }
        }
        private void ThayHinh()
        {
            try
            {
                //pictureBox1.ImageLocation = "skin_1.ipg";
                //pictureBox1.Image = Image.FromFile("../"+txtImage.Text);
                pictureBox1.Image = Image.FromFile("../" + txtImage.Text);
            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                pro.ProductID = proID;
                if (sv.CheckExist(pro) == 0)
            { 
                sv.XoaSP(pro);
                MessageBox.Show("Xóa thành công");
            }
                else MessageBox.Show("Không thể xóa");
            }
            catch { }
            HienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            txtTenSP.ReadOnly = false;
            txtGia.ReadOnly = false;
            txtGhiChu.ReadOnly = false;
            txtTenSP.Text = "";
            txtGia.Text = "";
            txtImage.Text = "Chọn hình";
            txtGhiChu.Text = "";
            txtTenSP.Select();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            txtTenSP.ReadOnly = false;
            txtGia.ReadOnly = false;
            txtGhiChu.ReadOnly = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text=="" || txtGia.Text=="")
            {
                MessageBox.Show("Xin nhập đầy đủ thông tin");
            }
            if (them == true)
            {
                try
                {
                    DataTable t = ConvertToDataTable(list);
                    pro.ProductName = txtTenSP.Text;
                    pro.Price = int.Parse(txtGia.Text);
                    if (txtImage.Text == "Chọn hình")
                    {
                        pro.Image = "Image/noimage.png";
                    }
                    else
                        pro.Image = txtImage.Text;
                    pro.Descriptions = txtGhiChu.Text;
                    int i = 0;
                    foreach (DataRow r in t.Rows)
                    {
                        i = int.Parse(r[0].ToString());
                    }
                    pro.ProductID = i + 1;
                    sv.ThemSP(pro);
                    MessageBox.Show("Thêm sản phẩm thành công");
                }
                catch { MessageBox.Show("Thêm sản phẩm thất bại"); }
            }
            else
            {
                try
                {
                    pro.ProductName = txtTenSP.Text;
                    pro.Price = int.Parse(txtGia.Text);
                    if (txtImage.Text == "Chọn hình")
                    {
                        pro.Image = "Image/noimage.png";
                    }
                    else
                        pro.Image = txtImage.Text;
                    pro.Descriptions = txtGhiChu.Text;
                    pro.ProductID = proID;
                    sv.SuaSP(pro);
                    MessageBox.Show("Sửa sản phẩm thành công");
                }
                catch
                {
                    MessageBox.Show("Sửa sản phẩm thất bại");
                }
            };
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            txtTenSP.ReadOnly = true;
            txtGia.ReadOnly = true;
            txtGhiChu.ReadOnly = true;
            if (txtTim.Text == "")
                HienThi();
            else txtTim_TextChanged(sender, e);
        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
        private void HienThi()
        {
            txtTenSP.ReadOnly = true;
            txtGia.ReadOnly = true;
            txtGhiChu.ReadOnly = true;
            btnLuu.Enabled = false;
            list = sv.LoadSP();
            dtDSSP.DataSource = list;
        }

        private void txtImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtImage.Text = "Image/"+ openFileDialog1.SafeFileName;
            ThayHinh();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            pro.ProductName = txtTim.Text;
            dtDSSP.DataSource = sv.TimSP(pro).Tables[0];
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTim.Text = "";
            HienThi();
        }
    }
}
