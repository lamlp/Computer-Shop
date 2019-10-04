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
    public partial class Recommendation : Form
    {
        WS.WScode sv = new WS.WScode();
        WS.RecommendationDTO recom = new WS.RecommendationDTO();
        int reID = 0;
        public Recommendation()
        {
            InitializeComponent();
        }

        private void Recommendation_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        private void HienThi()
        {
            dtREcomSP.DataSource = sv.LoadSP();
            dtDSSP.DataSource = sv.LoadSP();
        }

        private void dtREcomSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            reID = int.Parse(dtREcomSP.Rows[e.RowIndex].Cells[0].Value.ToString());
            dtDSReCom.DataSource = sv.SP_Recommendation(reID.ToString());
        }

        private void dtDSReCom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtDSReCom.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int intproIDs = int.Parse(dtDSReCom.Rows[e.RowIndex].Cells[1].Value.ToString());
                XoaSPvaoRecom(reID, intproIDs);
            }
        }

        private void dtDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtDSSP.Columns["Add"].Index && e.RowIndex >= 0)
            {
                int intproID = int.Parse(dtDSSP.Rows[e.RowIndex].Cells[1].Value.ToString());
                ThemSPvaoRecom(reID, intproID);
            }
        }
        public void XoaSPvaoRecom(int a, int b)
        {
            recom.ReProductID = a;
            recom.ProductID = b;
            sv.Xoa_Recommendation(recom);
            dtDSReCom.DataSource = sv.SP_Recommendation(reID.ToString());
        }
        public void ThemSPvaoRecom(int c, int d)
        {
            recom.ReProductID = c;
            recom.ProductID = d;
            sv.Add_Recommendation(recom);
            dtDSReCom.DataSource = sv.SP_Recommendation(reID.ToString());
        }
    }
}
