using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kota_FrontEnd.ServiceReference;

namespace Kota_FrontEnd
{
    public partial class Home : System.Web.UI.Page
    {
        BackEndClient sr = new BackEndClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            dynamic all_product = sr.GetAllProducts();
            dynamic all_updatedProduct = sr.UpdateProducts();

            string show = "";
            string display = "";

            foreach(productTable p in all_product)
            {
                show += "<div class='col-md-3 col-sm-5'>";
                show += "<div class='single-food'>";
                show += "<div class='food-img'>";
                show += "<a href='Shop.aspx?ID=" + p.Code + "'</a>";
                show += "<img src='" + p.Image + "'class='img-fluid' alt=''>";
                show += "</div>";
                show += "<div class='food-content'>";
                show += "<div class='d-flex justify-content-between'>";
                show += "<h5>" + p.Name + "</h5>";
                show += "<span class='style-change'>R" + Math.Round(p.Price, 2) + "</span>";
                show += "</div>";
                show += "<br>";
                show += "<dd><b>" + p.Description + "</b></dd>";
                show += "</div>";
                show += "</div>";
                show += "</div>";
            }

            _product.InnerHtml = show;

            int i = 19;
            int t = 2;

            foreach(productTable p in all_updatedProduct)
            {
                display += "<div class='col-md-4'>";
                display += "<div class='single-food'>";
                display += "<div class='food-img'>";
                display += "<img src='" + p.Image + "'class=img-fluid' alt=''>";
                display += "</div>";
                display += "<div class='food-content'>";
                display += "<div class='post-admin d-lg-flex mb-3'>";
                display += "<span class='mr-5 d-block mb-2 mb-lg-0'><i class='fa fa-user-o mr-2'></i>Admin</span>";
                display += "<span><i class='fa fa-calendar-o mr-2'></i>" + i++ + "/" + t++ + "/2023</span>";
                display += "</div>";
                display += "<h5>no finer food can be found</h5>";
                display += "<dd>" + p.Description + "</dd>";
                display += "<a href='#' class='template-btn3 mt-2'>read more<span><i class='fa fa-long-arrow-right'></i></span></a>";
                display += "</div>";
                display += "</div>";
                display += "</div>";
            }

            update.InnerHtml = display;
        }
    }
}