using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kota_FrontEnd.ServiceReference;

namespace Kota_FrontEnd
{
    public partial class UpdateProduct : System.Web.UI.Page
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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                name = p_name.Value,
                price = Convert.ToInt32(p_price.Value),
                special = Convert.ToInt32(p_special.Value),
                description = p_details.Value,
                update = Convert.ToInt32(p_update.Value),
                image = p_image.Value,
                type = Convert.ToInt32(p_type.Value),
                active = 1
            };

            var new_product = sr.UpdateProductByID(product, Convert.ToInt32(Request.QueryString["ID"]));

            if(new_product == true)
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Product successfully updated.";
            }
            else
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Sorry, can't update the current product.";
            }
        }
    }
}