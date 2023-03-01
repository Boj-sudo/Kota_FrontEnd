using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kota_FrontEnd.ServiceReference;

namespace Kota_FrontEnd
{
    public partial class SearchProduct : System.Web.UI.Page
    {
        BackEndClient sr = new BackEndClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            int search_product = sr.GetProductID(p_code.Value);

            if(search_product > 0)
            {
                Response.Redirect("UpdateProduct.aspx?ID= " + search_product);
            }
            else
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Sorry, the product code can't be found, try again later.";
                p_code.Value = "";
            }
        }
    }
}