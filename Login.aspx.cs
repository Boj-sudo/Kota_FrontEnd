using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kota_FrontEnd.ServiceReference;

namespace Kota_FrontEnd
{
    public partial class Login : System.Web.UI.Page
    {
        BackEndClient sr = new BackEndClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool user_exist = sr.Login(u_email.Value, u_password.Value);

            if(user_exist == true)
            {
                User user = sr.GetUser(u_email.Value);
                Session["Firstname"] = user.firstname;
                Session["Lastname"] = user.lastname;
                Session["Email"] = user.email;
                Session["type"] = user.type;

                Response.Redirect("Shop.aspx");
            }
            else
            {
                lbl_error.Text = "Incorrect email or password, please try again.";
                lbl_error.Visible = true;
                u_email.Value = " ";
                u_password.Value = " ";
            }
        }
    }
}