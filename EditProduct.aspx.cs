using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kota_FrontEnd.ServiceReference;

namespace Kota_FrontEnd
{
    public partial class EditProduct : System.Web.UI.Page
    {
        BackEndClient sr = new BackEndClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            dynamic all_product = sr.GetProducts();
            string show = "";

            if (!Session["userType"].Equals("admin"))
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                foreach(productTable p in all_product)
                {
                    show += "<div class='col-md-3 col-sm-5'>";
                    show += "<div class='single-food'>";
                    show += "<a href='UpdateProduct.aspx?ID= " + p.Code + "'class='unit-9'>";
                    show += "<div class='food-img'>";
                    show += "<img src='" + p.Image + "'class='img-fluid' alt=''>";
                    show += "</div>";
                    show += "<div class='food-content'>";
                    show += "<div class='d-flex justify-content-between'>";
                    show += "<h5>" + p.Name + "</h5>";
                    show += "<span class='style-change'> R" + p.Price + "</span>";
                    show += "</div>";
                    show += "<dd>" + p.Description + "</dd>";
                    show += "</div>";
                    show += "</div>";
                    show += "<br>";
                    show += "</div>";
                }
            }

            prod.InnerHtml = show;
        }
    }
}