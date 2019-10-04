using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace Web_j
{
    public class KetNoi
    {
        public static SqlConnection connect;
        //DataTable dd = new DataTable();
        //public KetNoi()
        //{
        //    dd = new DataTable();
        //    dd.Columns.Add("ProductID");
        //    dd.Columns.Add("ProductName");
        //    dd.Columns.Add("Price");
        //    dd.Columns.Add("Number");
        //    dd.Columns.Add("Total");
        //}
        //public DataTable GetDataTable()
        //{
        //    return this.dd;
        //}
        public static void MoKetNoi()
        {
            if (KetNoi.connect == null)
                KetNoi.connect = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Computer_Shop;Integrated Security=True");
            if (KetNoi.connect.State != ConnectionState.Open)
                KetNoi.connect.Open();
        }
        public static void DongKetNoi()
        {
            if (KetNoi.connect != null)
            {
                if (KetNoi.connect.State != ConnectionState.Open)
                    KetNoi.connect.Close();
            }
        }
        public void ThucThiCauLenhSQL(string strSQL)
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
                sqlcmd.ExecuteNonQuery();
                DongKetNoi();
            }
            catch
            {

            }
        }
        public DataTable GetDataTable(string strSQL)
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public string GetValue(string strSQL)
        {
            string temp = null;
            MoKetNoi();
            SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
                temp = sqldr[0].ToString();
            DongKetNoi();
            return temp;
        }

        public DataSet GetDataSet(string strSQL)
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                sqlda.Fill(dt);
                ds.Tables.Add(dt);
                DongKetNoi();
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public void DienVaoBang(DataTable dt, string strProductID, string strProductName, int strPrice, int strNumber, int strTotal)
        {
            if (dt.Rows.Count != 0)
            {
                bool kt = false;
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString().Equals(strProductID))
                    {
                        dr[3] = Convert.ToInt32(dr[3].ToString()) + strNumber;
                        dr[4] = Convert.ToInt32(dr[3].ToString()) * strPrice;
                        kt = true;
                    }
                }
                if (!kt)
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = strProductID;
                    dr[1] = strProductName;
                    dr[2] = strPrice;
                    dr[3] = strNumber;
                    dr[4] = strTotal;
                    dt.Rows.Add(dr);
                }
            }
            else
            {
                DataRow dr = dt.NewRow();
                dr[0] = strProductID;
                dr[1] = strProductName;
                dr[2] = strPrice;
                dr[3] = strNumber;
                dr[4] = strTotal;
                dt.Rows.Add(dr);
            }
        }
        public string LoadDuLieu(string strSQL, int i)
        {
            MoKetNoi();
            string strMa = "";
            SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
            SqlDataReader sqlDr = sqlcmd.ExecuteReader();
            while (sqlDr.Read())
            {
                strMa = sqlDr[i].ToString();
                break;
            }
            DongKetNoi();
            return strMa;
        }
    }
}