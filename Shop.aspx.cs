using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kota_FrontEnd.ServiceReference;

namespace Kota_FrontEnd
{
    public partial class Shop : System.Web.UI.Page
    {
        BackEndClient sr = new BackEndClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Firstname"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                dynamic kotaItems = sr.GetAllKotaProducts();
                string show = "";

                foreach(productTable p in kotaItems)
                {
                    show += "<div class='col-md-3'>";
                    show += "<div class='menu-entry'>";
                    show += "<a href='AboutProduct.aspx?ID= " + p.Code + "'</a>";
                    show += "<div class='food-img'>";
                    show += "<img src='" + p.Image + "'class='img-fluid' alt=''>";
                    show += "</div>";
                    show += "<div class='text text-center pt-4'>";
                    show += "<h3><b>" + p.Name + "</b></h3>";
                    show += "<p>" + p.Description + "</p>";
                    show += "<p class='price'><span>R" + Math.Round(p.Price, 2) + "</span></p>";
                    show += "<p><a href='Cart.aspx?ID=" + p.Code + "' class='btn btn-outline-warning'>Add to Cart</a></p>";
                    show += "</div>";
                    show += "</div>";
                    show += "</div>";
                }

                item1.InnerHtml = show;

                dynamic bunnyItems = sr.GetALlBunnyProducts();
                string print = "";

                foreach(productTable p in bunnyItems)
                {
                    print += "<div class='col-md-3'>";
                    print += "<div class='menu-entry'>";
                    print += "<a href='AboutProduct.aspx?ID= " + p.Code + "'</a>";
                    print += "<div class='food-img'>";
                    print += "<img src='" + p.Image + "'class='img-fluid' alt=''>";
                    print += "</div>";
                    print += "<div class='text text-center pt-4'>";
                    print += "<h3><b>" + p.Name + "</b></h3>";
                    print += "<p>" + p.Description + "</p>";
                    print += "<p class='price'><span>R" + Math.Round(p.Price, 2) + "</span></p>";
                    print += "<p><a href='Cart.aspx?ID=" + p.Code + "' class='btn btn-outline-warning'>Add to Cart</a></p>";
                    print += "</div>";
                    print += "</div>";
                    print += "</div>";
                }

                item2.InnerHtml = print;

                dynamic specialItems = sr.GetOnSpecial();
                string display = "";

                foreach(productTable p in specialItems)
                {
                    display += "<div class='col-md-3'>";
                    display += "<div class='menu-entry'>";
                    display += "<a href='AboutProduct.aspx?ID= " + p.Code + "'</a>";
                    display += "<div class='food-img'>";
                    display += "<img src='" + p.Image + "'class='img-fluid' alt=''>";
                    display += "</div>";
                    display += "<div class='text text-center pt-4'>";
                    display += "<h3><b>" + p.Name + "</b></h3>";
                    display += "<p>" + p.Description + "</p>";
                    display += "<p class='price'><span>R" + Math.Round(p.Price, 2) + "</span></p>";
                    display += "<p><a href='Cart.aspx?ID=" + p.Code + "' class='btn btn-outline-warning'>Add to Cart</a></p>";
                    display += "</div>";
                    display += "</div>";
                    display += "</div>";
                }

                item3.InnerHtml = display;
            }
        }
    }
}