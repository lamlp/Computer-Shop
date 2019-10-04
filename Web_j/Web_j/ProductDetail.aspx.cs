using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_j
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        WS.WScode sv = new WS.WScode();
        WS.ProductDTO pro = new WS.ProductDTO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ProductID"] != null)
                {
                    int productID = int.Parse(Request.QueryString["ProductID"].ToString());
                    pro.ProductID = productID;
                    dtProduct.DataSource = sv.TimSPbyID(pro).Tables[0];
                    dtProduct.DataBind();
                }
            }
            
        }
    }
}