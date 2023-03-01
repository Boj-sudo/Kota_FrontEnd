using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kota_FrontEnd.ServiceReference;

namespace Kota_FrontEnd
{
    public partial class Register : System.Web.UI.Page
    {
        BackEndClient sr = new BackEndClient();
        string userType = "Customer";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["type"] != null)
            {
                if (Session["type"].Equals("Manager"))
                {
                    lbl_error.Visible = true;
                    if (!IsPostBack)
                    {

                    }
                }
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (u_password.Value.Equals(confirm_password.Value))
            {
                bool is_registered = sr.IsRegistered(u_email.Value, u_password.Value);

                if (is_registered.Equals(false))
                {
                    User user = new User
                    {
                        firstname = u_firstname.Value,
                        lastname = u_lastname.Value,
                        contact = u_contact.Value,
                        email = u_email.Value,
                        password = u_password.Value,
                        type = userType,
                        active = 1
                    };

                    int register = sr.Register(user);

                    if (register.Equals(1))
                    {
                        Response.Redirect("Login.aspx");
                    }
                }
                else
                {
                    lbl_error.Text = "Something went wrong, please try again later.";
                    lbl_error.Visible = true;
                }
            }
            else
            {

            }
        }
    }
}