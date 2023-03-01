using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kota_FrontEnd.ServiceReference;

namespace Kota_FrontEnd
{
    public partial class DeleteProduct : System.Web.UI.Page
    {
        BackEndClient sr = new BackEndClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Product get_product = sr.GetProduct(Request.QueryString["ID"]);

                p_name.Value = get_product.name;
                p_price.Value = Convert.ToString(get_product.price);
                p_special.Value = Convert.ToString(get_product.special);
                p_details.Value = get_product.description;
                p_update.Value = Convert.ToString(get_product.update);
                p_image.Value = get_product.image;
                p_type.Value = Convert.ToString(get_product.type);
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            bool remove_product = sr.RemoveProduct(Request.QueryString["ID"]);

            if(remove_product == true)
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Product is succefully deleted.";
            }
            else
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Sorry, can't delete this current product.";
            }
        }
    }
}