using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kota_FrontEnd.ServiceReference;

namespace Kota_FrontEnd
{
    public partial class AddProduct : System.Web.UI.Page
    {
        BackEndClient sr = new BackEndClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var product_exist = sr.DoesProductExist(p_code.Value);

            if(product_exist == true)
            {
                lbl_error.Visible = true;
                lbl_error.Text = "This product already exist.";
            }
            else
            {
                Product new_product = new Product
                {
                    code = Convert.ToInt32(p_code.Value),
                    name = p_name.Value,
                    price = Convert.ToInt32(p_price.Value),
                    special = Convert.ToInt32(p_special.Value),
                    description = p_details.Value,
                    update = Convert.ToInt32(p_update.Value),
                    image = p_image.Value,
                    type = Convert.ToInt32(p_type.Value),
                    active = 1
                };

                var add_product = sr.AddNewProduct(new_product);

                if(add_product == true)
                {
                    lbl_error.Visible = true;
                    lbl_error.Text = "New product have been added successfully.";

                    p_code.Value = "";
                    p_name.Value = "";
                    p_price.Value = "";
                    p_special.Value = "";
                    p_details.Value = "";
                    p_update.Value = "";
                    p_image.Value = "";
                    p_type.Value = "";
                }
            }
        }
    }
}