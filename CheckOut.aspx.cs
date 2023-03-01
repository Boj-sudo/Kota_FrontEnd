using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kota_FrontEnd.ServiceReference;

namespace Kota_FrontEnd
{
    public partial class CheckOut : System.Web.UI.Page
    {
        BackEndClient sr = new BackEndClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            double sum = 0;
            double vat = 0.15;
            string display = "";
            double vat_total = sum * vat;

            display += "<h3>Cart Totals</h3>";
            display += "<p class='d-flex'>";
            display += "<span>Subtotal</span>";
            display += "<span> R" + sum + "</span>";
            display += "</p>";
            display += "<p class='d-flex'>";
            display += "<span>VAT Total</span>";
            display += "<span> R" + vat_total + "</span>";
            display += "</p>";
            display += "<p class='d-flex'>";
            display += "<span>Discount</span>";
            display += "<span>R3.00</span>";
            display += "</p>";
            display += "<hr>";
            display += "<p class='d-flex total-price'>";
            display += "<span>Total</span>";
            display += "<span> R" + (sum - vat_total) + "</span>";
            display += "</p>";

            totalcart.InnerHtml = display;
        }
    }
}