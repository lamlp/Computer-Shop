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
    public partial class TimeRule : Form
    {
        WS.WScode sv = new WS.WScode();
        WS.TimeRuleDTO time = new WS.TimeRuleDTO();
        WS.TimeBaseDisplayDTO timebase = new WS.TimeBaseDisplayDTO();
        int i = 0;
        public TimeRule()
        {
            InitializeComponent();
        }

        private void TimeRule_Load(object sender, EventArgs e)
        {
            dtTimeBase.DataSource = sv.LoadTimeBaseDisplay().Tables[0];
            dtDSSP.DataSource = sv.LoadSP();
        }

        private void dtTimeBase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = int.Parse(dtTimeBase.Rows[e.RowIndex].Cells[0].Value.ToString());
            time.TimeID = int.Parse(dtTimeBase.Rows[e.RowIndex].Cells[0].Value.ToString());
            dtTimeRule.DataSource = sv.LoadTimeBaseByID(time).Tables[0];
        }
        private void dtDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtDSSP.Columns["Add"].Index && e.RowIndex >= 0)
            {
                int intproID = int.Parse(dtDSSP.Rows[e.RowIndex].Cells[1].Value.ToString());
                ThemSPvaoTimeRule(i,intproID);
            }
        }

        private void dtTimeRule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtTimeRule.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int intproIDs = int.Parse(dtTimeRule.Rows[e.RowIndex].Cells[1].Value.ToString());
                XoaSPvaoTimeRule(i, intproIDs);
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
    }
}
