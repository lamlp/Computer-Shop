using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_j
{
    public partial class KhachHang : Form
    {
        WS.WScode sv = new WS.WScode();
        WS.CustomerDTO cus = new WS.CustomerDTO();
        bool them = true;
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        private void HienThi()
        {
            dtDSKH.DataSource = sv.LoadKH();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtTaiKhoan.ReadOnly = true;
            txtMatKhau.ReadOnly = true;
            txtTenKH.ReadOnly = true;
            txtNgaySinh.ReadOnly = true;
            txtCMND.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtDienThoai.ReadOnly = true;
            txtEmail.ReadOnly = true;
            rdNam.Enabled = false;
            rdNormal.Enabled = false;
            rdNu.Enabled = false;
            rdVIP.Enabled = false;
        }

        private void dtDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtTaiKhoan.Text = dtDSKH.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMatKhau.Text = dtDSKH.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenKH.Text = dtDSKH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNgaySinh.Text = (DateTime.Parse(dtDSKH.Rows[e.RowIndex].Cells[3].Value.ToString())).ToString("dd/MM/yyyy");
                txtCMND.Text = dtDSKH.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDiaChi.Text = dtDSKH.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtDienThoai.Text = dtDSKH.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtEmail.Text = dtDSKH.Rows[e.RowIndex].Cells[8].Value.ToString();
                if (bool.Parse(dtDSKH.Rows[e.RowIndex].Cells[4].Value.ToString()) == true)
                    rdNam.Checked = true;
                else rdNu.Checked = true;
                if (bool.Parse(dtDSKH.Rows[e.RowIndex].Cells[9].Value.ToString()) == true)
                    rdVIP.Checked = true;
                   else rdNormal.Checked = true;
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtTenKH.Text = "";
            txtNgaySinh.Text = "";
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtTaiKhoan.ReadOnly = false;
            txtMatKhau.ReadOnly = false;
            txtTenKH.ReadOnly = false;
            txtNgaySinh.ReadOnly = false;
            txtCMND.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtDienThoai.ReadOnly = false;
            txtEmail.ReadOnly = false;
            rdNam.Enabled = true;
            rdNormal.Enabled = true;
            rdNu.Enabled = true;
            rdVIP.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            txtTaiKhoan.ReadOnly = true;
            txtMatKhau.ReadOnly = false;
            txtTenKH.ReadOnly = false;
            txtNgaySinh.ReadOnly = false;
            txtCMND.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtDienThoai.ReadOnly = false;
            txtEmail.ReadOnly = false;
            rdNam.Enabled = true;
            rdNormal.Enabled = true;
            rdNu.Enabled = true;
            rdVIP.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try {
                cus.TaiKhoan = txtTaiKhoan.Text;
                sv.XoaKH(cus);
                MessageBox.Show("Xóa thành công");
                HienThi();
            }
            catch {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == ""|| txtTenKH.Text == "" || txtNgaySinh.Text =="" || txtCMND.Text == "" || txtDiaChi.Text =="" || txtDienThoai.Text =="" || txtEmail.Text =="" || rdNam.Checked == false & rdNu.Checked == false || rdNormal.Checked == false & rdVIP.Checked == false)
            {
                MessageBox.Show("Xin nhập đầy đủ thông tin");
            }
            else
                if (them == true)
                {
                    try
                    {
                        cus.TaiKhoan = txtTaiKhoan.Text;
                        cus.MatKhau = txtMatKhau.Text;
                        cus.TenKH = txtTenKH.Text;
                        cus.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
                        cus.CMND = txtCMND.Text;
                        cus.DiaChi = txtDiaChi.Text;
                        cus.DT = txtDienThoai.Text;
                        cus.Email = txtEmail.Text;
                        if (rdNam.Checked == true)
                            cus.GioiTinh = true;
                        else cus.GioiTinh = false;
                        if (rdNormal.Checked == false)
                            cus.LoaiKH = true;
                        else cus.LoaiKH = false;
                        sv.ThemKH(cus);
                        bool a = false;
                        foreach (DataGridViewRow dr in dtDSKH.Rows)
                        {
                            if (dr.Cells["TaiKhoan"].Value.ToString() == txtTaiKhoan.Text)
                            {
                                a = true;
                            }
                        };
                        if (a == true)
                            MessageBox.Show("Tài khoản đã tồn tại");
                        else
                            MessageBox.Show("Thêm khách hàng thành công");
                    }
                    catch
                    {
                        MessageBox.Show("Thêm khách hàng thất bại");
                    }
                    HienThi();
                }
                else
                {
                    try
                    {
                        cus.TaiKhoan = txtTaiKhoan.Text;
                        cus.MatKhau = txtMatKhau.Text;
                        cus.TenKH = txtTenKH.Text;
                        cus.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
                        cus.CMND = txtCMND.Text;
                        cus.DiaChi = txtDiaChi.Text;
                        cus.DT = txtDienThoai.Text;
                        cus.Email = txtEmail.Text;
                        if (rdNam.Checked == true)
                            cus.GioiTinh = true;
                        else cus.GioiTinh = false;
                        if (rdNormal.Checked == false)
                            cus.LoaiKH = true;
                        else cus.LoaiKH = false;
                        sv.SuaKH(cus);
                        HienThi();
                        MessageBox.Show("Sửa khách hàng thành công");
                    }
                    catch { MessageBox.Show("Sửa khách hàng thất bại"); }
                }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTim.Text = "";
            HienThi();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cus.TaiKhoan = txtTim.Text;
                dtDSKH.DataSource = sv.TimKH(cus).Tables[0];
            }
            catch { }
        }
    }
}
