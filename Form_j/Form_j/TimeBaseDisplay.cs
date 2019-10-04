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
    public partial class TimeBaseDisplay : Form
    {
        WS.WScode sv = new WS.WScode();
        WS.TimeRuleDTO time = new WS.TimeRuleDTO();
        WS.TimeBaseDisplayDTO timebase = new WS.TimeBaseDisplayDTO();
        int timeID = 0;
        bool them;
        public TimeBaseDisplay()
        {
            InitializeComponent();
        }

        private void TimeBaseDisplay_Load(object sender, EventArgs e)
        {
            calendaR.Visible = false;
            calendaR2.Visible = false;
            HienThi();
        }
        private void HienThi()
        {
            dtDSTR.DataSource = sv.LoadTimeBaseDisplay().Tables[0];
            dtDSSP.DataSource = sv.LoadSP();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtFromNgay.Enabled = false;
            txtToNgay.Enabled = false;
            txtFromGio.Enabled = false;
            txtToGio.Enabled = false;
            txtThu.Enabled = false;
        }

        private void dtDSTR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtFromNgay.Text = DateTime.Parse(dtDSTR.Rows[e.RowIndex].Cells[1].Value.ToString()).ToString("dd/MM/yyyy");
                txtToNgay.Text = DateTime.Parse(dtDSTR.Rows[e.RowIndex].Cells[2].Value.ToString()).ToString("dd/MM/yyyy");
                txtFromGio.Text = DateTime.Parse(dtDSTR.Rows[e.RowIndex].Cells[3].Value.ToString()).ToString("HH");
                txtToGio.Text = DateTime.Parse(dtDSTR.Rows[e.RowIndex].Cells[4].Value.ToString()).ToString("HH");
                int dt = int.Parse(dtDSTR.Rows[e.RowIndex].Cells[5].Value.ToString());
                switch (dt)
                {
                    case 1: txtThu.Text = "Chủ Nhật"; break;
                    case 2: txtThu.Text = "Thứ 2"; break;
                    case 3: txtThu.Text = "Thứ 3"; break;
                    case 4: txtThu.Text = "Thứ 4"; break;
                    case 5: txtThu.Text = "Thứ 5"; break;
                    case 6: txtThu.Text = "Thứ 6"; break;
                    case 7: txtThu.Text = "Thứ 7"; break;
                }
                timeID = int.Parse(dtDSTR.Rows[e.RowIndex].Cells[0].Value.ToString());
                time.TimeID = timeID;
                dtTimeRule.DataSource = sv.LoadTimeBaseByID(time).Tables[0];
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
            txtFromNgay.Enabled = true;
            txtToNgay.Enabled = true;
            txtFromGio.Enabled = true;
            txtToGio.Enabled = true;
            txtThu.Enabled = true;
            txtFromNgay.Text = "";
            txtToNgay.Text = "";
            txtFromGio.Text = "";
            txtToGio.Text = "";
            txtThu.Text = "";
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            txtFromNgay.Enabled = true;
            txtToNgay.Enabled = true;
            txtFromGio.Enabled = true;
            txtToGio.Enabled = true;
            txtThu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
            timebase.TimeID = timeID;
            sv.XoaTimeBaseDisplay(timebase);
            MessageBox.Show("Xóa thành công");
            }
            catch
            {MessageBox.Show("Xóa thất bại");}
            HienThi();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtFromGio.Text == "" || txtFromNgay.Text == "" || txtToGio.Text=="" || txtToNgay.Text=="" || txtThu.Text=="")
            { 
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin"); 
            }
            if (them == true)
            {
                try
                {
                    DataTable t = sv.LoadTimeBaseDisplay().Tables[0];
                    foreach (DataRow dr in t.Rows)
                    {
                        timeID = int.Parse(dr[0].ToString());
                    }
                    timebase.FromTime = DateTime.Parse(txtFromNgay.Text);
                    timebase.FromHour = DateTime.Parse(txtFromGio.Text + ":00:00");
                    timebase.ToTime = DateTime.Parse(txtToNgay.Text);
                    timebase.ToHour = DateTime.Parse(txtToGio.Text + ":00:00");
                    switch (txtThu.Text)
                    {
                        case "Chủ Nhật": timebase.DayOfWeek = 1; break;
                        case "Thứ 2": timebase.DayOfWeek = 2; break;
                        case "Thứ 3": timebase.DayOfWeek = 3; break;
                        case "Thứ 4": timebase.DayOfWeek = 4; break;
                        case "Thứ 5": timebase.DayOfWeek = 5; break;
                        case "Thứ 6": timebase.DayOfWeek = 6; break;
                        case "Thứ 7": timebase.DayOfWeek = 7; break;
                    };
                    sv.ThemTimeBaseDisplay(timebase);
                    MessageBox.Show("Thêm Time-base thành công");
                }
                catch
                {
                    MessageBox.Show("Thêm Time-base thất bại");
                }
            }
            else
            {
                try
                {
                    timebase.TimeID = timeID;
                    timebase.FromTime = DateTime.Parse(txtFromNgay.Text);
                    timebase.FromHour = DateTime.Parse(txtFromGio.Text + ":00:00");
                    timebase.ToTime = DateTime.Parse(txtToNgay.Text);
                    timebase.ToHour = DateTime.Parse(txtToGio.Text + ":00:00");
                    switch (txtThu.Text)
                    {
                        case "Chủ Nhật": timebase.DayOfWeek = 1; break;
                        case "Thứ 2": timebase.DayOfWeek = 2; break;
                        case "Thứ 3": timebase.DayOfWeek = 3; break;
                        case "Thứ 4": timebase.DayOfWeek = 4; break;
                        case "Thứ 5": timebase.DayOfWeek = 5; break;
                        case "Thứ 6": timebase.DayOfWeek = 6; break;
                        case "Thứ 7": timebase.DayOfWeek = 7; break;
                    };
                    sv.SuaTimeBaseDisplay(timebase);
                    MessageBox.Show("Sửa Time-base thành công");
                }
                catch
                {
                    MessageBox.Show("Sửa Time-base thất bại");
                }
            }
            HienThi();
        }

        private void txtFromNgay_Click(object sender, EventArgs e)
        {
            if (calendaR.Visible)
            {
                calendaR.Visible = false;
            }
            else
            {
                calendaR.Visible = true;
            }
        }
        private void txtToNgay_Click(object sender, EventArgs e)
        {
            if (calendaR2.Visible)
            {
                calendaR2.Visible = false;
            }
            else
            {
                calendaR2.Visible = true;
            }
        }
        private void calendaR_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtFromNgay.Text = calendaR.SelectionRange.Start.ToShortDateString();
            calendaR.Visible = false;
        }

        private void calendaR2_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtToNgay.Text = calendaR2.SelectionRange.Start.ToShortDateString();
            calendaR2.Visible = false;
        }

        private void dtTimeRule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtTimeRule.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int intproIDs = int.Parse(dtTimeRule.Rows[e.RowIndex].Cells[1].Value.ToString());
                XoaSPvaoTimeRule(timeID, intproIDs);
            }
        }

        private void dtDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtDSSP.Columns["Add"].Index && e.RowIndex >= 0)
            {
                int intproID = int.Parse(dtDSSP.Rows[e.RowIndex].Cells[1].Value.ToString());
                ThemSPvaoTimeRule(timeID, intproID);
            }
        }
        private void ThemSPvaoTimeRule(int a, int b)
        {
            time.TimeID = a;
            time.ProductID = b;
            sv.AddTimeRule(time);
            dtTimeRule.DataSource = sv.LoadTimeBaseByID(time).Tables[0];
        }
        private void XoaSPvaoTimeRule(int c, int d)
        {
            time.TimeID = c;
            time.ProductID = d;
            sv.XoaTimeRule(time);
            dtTimeRule.DataSource = sv.LoadTimeBaseByID(time).Tables[0];
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
