using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kota_FrontEnd.ServiceReference;

namespace Kota_FrontEnd
{
    public partial class UpdateUser : System.Web.UI.Page
    {
        BackEndClient sr = new BackEndClient();
        String userType = "Customer";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                User user = sr.GetUserToUpdate(Request.QueryString["ID"]);
                {
                    u_firstname.Value = Convert.ToString(user.firstname);
                    u_lastname.Value = Convert.ToString(user.lastname);
                    u_contact.Value = Convert.ToString(user.contact);
                    u_email.Value = Convert.ToString(user.email);
                    u_password.Value = Convert.ToString(user.password);
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
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

            bool updated_user = sr.UpdateUser(user, Convert.ToInt32(Request.QueryString["ID"]));

            if (updated_user.Equals(true))
            {
                lbl_error.Visible = true;
                lbl_error.Text = "User updated successfully.";
            }
            else
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Unable to update the current user.";
            }
        }
    }
}