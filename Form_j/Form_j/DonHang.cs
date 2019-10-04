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
    public partial class DonHang : Form
    {
        WS.WScode sv = new WS.WScode();
        WS.OrdersDTO hoadon = new WS.OrdersDTO();
        WS.OrdersDetailDTO cthd = new WS.OrdersDetailDTO();
        int orderid;
        bool them;
        int row;
        public DonHang()
        {
            InitializeComponent();
        }

        private void dtHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row = e.RowIndex;
                orderid = int.Parse(dtHD.Rows[e.RowIndex].Cells[0].Value.ToString());
                cthd.OrderID = orderid;
                dtDSSP.DataSource = sv.LoadChiTietHoaDon(cthd).Tables[0];
                int tongtien = 0;
                int dongia = 0;
                int soluong = 0;
                foreach (DataRow dr in sv.LoadChiTietHoaDon(cthd).Tables[0].Rows)
                {
                    dongia = int.Parse(dr[2].ToString());
                    soluong = int.Parse(dr[3].ToString());
                    tongtien += (dongia * soluong);
                }
                lbTongTien.Text = tongtien.ToString() + " VND";
                

                //Đổ dữ liệu vào textbox
                txtTenKH.Text = dtHD.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDiaChi.Text = dtHD.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGhiChu.Text = dtHD.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDienThoai.Text = dtHD.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtNgayTao.Text = DateTime.Parse(dtHD.Rows[e.RowIndex].Cells[6].Value.ToString()).ToString("dd/MM/yyyy");
                txtNgayGiao.Text = DateTime.Parse(dtHD.Rows[e.RowIndex].Cells[7].Value.ToString()).ToString("dd/MM/yyyy");
            }
            catch { }
        }

        private void DonHang_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        private void HienThi()
        {
            dtHD.DataSource = sv.LoadHoaDon();
            calendaR.Visible = false;
            calendaR2.Visible = false;
            dtHD.ReadOnly = false;
            dtDSSP.ReadOnly = true;
            dtHD.Columns[0].ReadOnly = true;
            dtHD.Columns[1].ReadOnly = true;
            dtHD.Columns[2].ReadOnly = true;
            dtHD.Columns[3].ReadOnly = true;
            dtHD.Columns[4].ReadOnly = true;
            dtHD.Columns[6].ReadOnly = true;
            dtHD.Columns[7].ReadOnly = true;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtGhiChu.Text = "";
            txtDienThoai.Text = "";
            txtNgayTao.Text = "Chọn Ngày";
            txtNgayGiao.Text = "Chọn Ngày";
            txtTenKH.Select();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            hoadon.OrderID = orderid;
            sv.XoaHoaDon(hoadon);
            HienThi();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                try
                {
                    hoadon.TenKH = txtTenKH.Text;
                    hoadon.GhiChu = txtGhiChu.Text;
                    hoadon.DiaChi = txtDiaChi.Text;
                    hoadon.DienThoai = txtDienThoai.Text;
                    hoadon.NgayTao = DateTime.Parse(txtNgayTao.Text);
                    hoadon.NgayGiao = DateTime.Parse(txtNgayGiao.Text);
                    hoadon.TrangThai = false;
                    sv.TaoHoaDon(hoadon);
                    MessageBox.Show("Thêm Đơn Hàng Thành Công");
                }
                catch { MessageBox.Show("Thêm Đơn Hàng Thất Bại"); }
            }
            else
            {
                try
                {
                    hoadon.OrderID = orderid;
                    hoadon.TenKH = txtTenKH.Text;
                    hoadon.GhiChu = txtGhiChu.Text;
                    hoadon.DiaChi = txtDiaChi.Text;
                    hoadon.DienThoai = txtDienThoai.Text;
                    hoadon.NgayTao = DateTime.Parse(txtNgayTao.Text);
                    hoadon.NgayGiao = DateTime.Parse(txtNgayGiao.Text);
                    sv.SuaHoaDon(hoadon);
                    MessageBox.Show("Thêm Đơn Hàng Thành Công");
                }
                catch { MessageBox.Show("Sửa Đơn Hàng Thất Bại"); }
            }
            HienThi();
        }

        private void calendaR_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtNgayTao.Text = calendaR.SelectionRange.Start.ToShortDateString();
            calendaR.Visible = false;
        }

        private void txtNgayTao_Click(object sender, EventArgs e)
        {
            if (calendaR.Visible)
            {
                calendaR.Visible = false;
            }
            else
                calendaR.Visible = true;
        }

        private void txtNgayGiao_Click(object sender, EventArgs e)
        {
            if (calendaR2.Visible)
            {
                calendaR2.Visible = false;
            }
            else
                calendaR2.Visible = true;
        }

        private void calendaR2_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtNgayGiao.Text = calendaR2.SelectionRange.Start.ToShortDateString();
            calendaR2.Visible = false;
        }

        private void dtHD_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)dtHD.Rows[e.RowIndex].Cells["TrangThai"];
                    bool isChecked = (bool)checkbox.EditingCellFormattedValue;
                    hoadon.OrderID = int.Parse(dtHD.Rows[e.RowIndex].Cells[0].Value.ToString());
                    hoadon.TrangThai = isChecked;
                    sv.ActiveHoaDon(hoadon);
                    HienThi();
                }
                catch { }
            }

        }
    }
}
