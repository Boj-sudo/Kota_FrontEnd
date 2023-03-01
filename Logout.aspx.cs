using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kota_FrontEnd
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Firstname"] = null;
            Session["Lastname"] = null;
            Session["Email"] = null;
            Session["type"] = null;
            Response.Redirect("Home.aspx");
        }
    }
}