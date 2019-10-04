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
    public partial class Category : Form
    {
        WS.WScode sv = new WS.WScode();
        WS.CategoryDTO cate = new WS.CategoryDTO();
        WS.SubCategoryDTO subcate = new WS.SubCategoryDTO();
        WS.SubCategoryMenuDTO submenu = new WS.SubCategoryMenuDTO();
        bool them;
        bool themsub;
        int subid;
        int cateid;
        public Category()
        {
            InitializeComponent();
        }

        private void dtCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCategory.Text = dtCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                cateid = int.Parse(dtCategory.Rows[e.RowIndex].Cells[0].Value.ToString());
                subcate.CategoryID = cateid;
                dtSubCategory.DataSource = sv.LoadSubCategoryByCateID(subcate).Tables[0];
            }
            catch { }
        }

        private void dtSubCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSubCategory.Text = dtSubCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
            subid = int.Parse(dtSubCategory.Rows[e.RowIndex].Cells[0].Value.ToString());
            subcate.SubCategoryID = subid;
            dtSPSub.DataSource = sv.LoadProductBySubID(subcate);
        }

        private void dtSPSub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtSPSub.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                submenu.SubCategoryID = subid;
                submenu.ProductID = int.Parse(dtSPSub.Rows[e.RowIndex].Cells[1].Value.ToString());
                sv.XoaSPSub(submenu);
                dtSPSub.DataSource = sv.LoadProductBySubID(subcate);
            }
        }
        private void dtDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dtDSSP.Columns["Add"].Index && e.RowIndex >= 0)
            {
                int proID = int.Parse(dtDSSP.Rows[e.RowIndex].Cells[1].Value.ToString());
                submenu.SubCategoryID = subid;
                submenu.ProductID = proID;
                sv.ThemSPVaoSubCateMenu(submenu);
                dtSPSub.DataSource = sv.LoadProductBySubID(subcate);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuuSub.Enabled = false;
            btnThemSub.Enabled = false;
            btnXoaSub.Enabled = false;
            btnSuaSub.Enabled = false;
            txtCategory.Enabled = true;
            txtSubCategory.Enabled = false;
            txtCategory.Text = "";
            txtCategory.Select();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuuSub.Enabled = false;
            btnThemSub.Enabled = false;
            btnXoaSub.Enabled = false;
            btnSuaSub.Enabled = false;
            txtCategory.Enabled = true;
            txtSubCategory.Enabled = false;
            txtCategory.Select();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cate.CategoryID = cateid;
            sv.XoaCategory(cate);
            HienThi();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                cate.CategoryName = txtCategory.Text;
                sv.TaoCategory(cate);
            }
            else {
                cate.CategoryName = txtCategory.Text;
                cate.CategoryID = cateid;
                sv.SuaCategory(cate);
            }
            HienThi();
        }

        private void btnThemSub_Click(object sender, EventArgs e)
        {
            themsub = true;
            btnLuuSub.Enabled = true;
            btnThemSub.Enabled = false;
            btnXoaSub.Enabled = false;
            btnSuaSub.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtCategory.Enabled = false;
            txtSubCategory.Enabled = true;
            txtSubCategory.Text = "";
            txtSubCategory.Select();
        }

        private void btnSuaSub_Click(object sender, EventArgs e)
        {
            themsub = false;
            btnLuuSub.Enabled = true;
            btnThemSub.Enabled = false;
            btnXoaSub.Enabled = false;
            btnSuaSub.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtSubCategory.Enabled = true;
            txtCategory.Enabled = false;
            txtSubCategory.Select();
        }

        private void btnXoaSub_Click(object sender, EventArgs e)
        {
            subcate.SubCategoryID = subid;
            sv.XoaSubCategory(subcate);
            dtSubCategory.DataSource = sv.LoadSubCategoryByCateID(subcate).Tables[0];
        }

        private void btnLuuSub_Click(object sender, EventArgs e)
        {
            {
                if (themsub == true)
                {
                    try
                    {
                        subcate.SubCategoryName = txtSubCategory.Text;
                        subcate.CategoryID = cateid;
                        sv.TaoSubCategory(subcate);
                    }
                    catch { MessageBox.Show("Thêm SubCategory thất bại"); }
                }
                else
                {
                    try
                    {
                        subcate.CategoryID = cateid;
                        subcate.SubCategoryID = subid;
                        subcate.SubCategoryName = txtSubCategory.Text;
                        sv.SuaSubCategory(subcate);
                    }
                    catch { MessageBox.Show("Sửa SubCategory thất bại"); }
                }
                dtSubCategory.DataSource = sv.LoadSubCategoryByCateID(subcate).Tables[0];
                HienThi();
            }
        }

        private void Category_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        private void HienThi()
        {
            dtCategory.DataSource = sv.LoadCategory().Tables[0];
            dtDSSP.DataSource = sv.LoadSP();
            btnLuu.Enabled = false;
            btnLuuSub.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThemSub.Enabled = true;
            btnXoaSub.Enabled = true;
            btnSuaSub.Enabled = true;
            txtSubCategory.Enabled = false;
            txtCategory.Enabled = false;
        }
    }
}
