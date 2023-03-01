using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kota_FrontEnd.ServiceReference;

namespace Kota_FrontEnd
{
    public partial class AdminRemove : System.Web.UI.Page
    {
        BackEndClient sr = new BackEndClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            int find_user = sr.FindUser(u_email.Value);

            if(find_user > 0)
            {
                Response.Redirect("RemoveProduct.aspx");
                Session["userType"] = u_email.Value;
            }
            else
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Sorry, can't find the current admin's email.";
                u_email.Value = "";
            }
        }
    }
}