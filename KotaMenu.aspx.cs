using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kota_FrontEnd.ServiceReference;

namespace Kota_FrontEnd
{
    public partial class KotaMenu : System.Web.UI.Page
    {
        BackEndClient sr = new BackEndClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            dynamic productItems = sr.GetAllKotaProducts();
            string show = "";

            foreach(productTable p in productItems)
            {
                show += "<div class='col-md-3 col-sm-6'>";
                show += "<div class='single-food'>";
                show += "<div class='food-img'>";
                show += "<img src='" + p.Image + "'class='img-fluid' alt=''>";
                show += "</div>";
                show += "<div class='food-content'>";
                show += "<div class='d-flex justify-content-between'>";
                show += "<h3><b>" + p.Name + "</b></h3>";
                show += "<p class='price'><span>R" + Math.Round(p.Price, 2) + "</span></p>";
                show += "</div>";
                show += "<p>" + p.Description + "</p>";
                show += "</div>";
                show += "</div>";
                show += "<p><a href='Cart.aspx?ID=" + p.Code + "' class='btn btn-outline-warning'>Add to Cart</a></p>";
                show += "</div>";
                show += "<br/>";
            }

            kota.InnerHtml = show;
        }
    }
}