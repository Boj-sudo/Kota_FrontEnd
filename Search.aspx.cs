using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kota_FrontEnd.ServiceReference;

namespace Kota_FrontEnd
{
    public partial class Search : System.Web.UI.Page
    {
        BackEndClient sr = new BackEndClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            int findUser = sr.FindUser(u_email.Value);

            if(findUser > 0)
            {
                Response.Redirect("UpdateUser.aspx?ID=" + findUser);
            }
            else
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Unable to find the current user's email.";
                u_email.Value = " ";
            }
        }
    }
}