using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kota_FrontEnd
{
    public partial class RemoveCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(Request.QueryString["ID"]);

            master.cart_items.RemoveAt(master.GetIndex(index));

            int a = 0;

            foreach(CartItems c in master.cart_items)
            {
                a += c.quantity;
            }

            Session["CartItems"] = a;
            Response.Redirect("Cart.aspx");
        }
    }
}