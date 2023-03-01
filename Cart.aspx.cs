using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kota_FrontEnd.ServiceReference;

namespace Kota_FrontEnd
{
    public partial class Cart : System.Web.UI.Page
    {
        BackEndClient sr = new BackEndClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            int count = 1;
            double sum = 0;
            double vat = 0.15;
            string display = "";
            string show = "";
            string id = Request.QueryString["ID"];

            Session["Item"] = id;

            if(Session["Firstname"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                show += "<table class='table'>";
                show += "<thead class='thead-primary'>";
                show += "<tr class='text-center'>";
                show += "<th>&nbsp;</th>";
                show += "<th>&nbsp;</th>";
                show += "<th>Product name</th>";
                show += "<th>Product price</th>";
                show += "<th>Product quantity</th>";
                show += "<th>Total</th>";
                show += "</tr>";
                show += "</thead>";
                show += "</tbody>";
                    
                if(Session["Item"] == null)
                {
                    dynamic new_item = master.GetCartItems();

                    foreach(CartItems c in new_item)
                    {
                        var productItems = sr.AboutProduct(Convert.ToString(c.id));
                        double totalItems = Convert.ToInt32(productItems.Price * c.quantity);

                        show += "<tr class='text-center'>";
                        show += "<td><a href='RemoveCart.aspx?ID=" + c.id + "'><img src='assets/images/cancel.png' class='img-fluid' alt='' width='50' height='50'></a></td>";
                        show += "<td><img src='" + productItems.Image + "'class='img-fluid' alt='' width='150' height='150'></td>";
                        show += "<td class='product-name'>";
                        show += "<h3><b>" + productItems.Name + "</b></h3>";
                        show += "<p><b>" + productItems.Description + "</b></p>";
                        show += "</td>";
                        show += "<td class='price'> R" + Math.Round(productItems.Price, 2) + "</td>";
                        show += "<td class='quantity'>" + c.quantity + "</td>";
                        show += "<td class='total'> R" + Math.Round(totalItems) + "</td>";
                        show += "</tr>";

                        sum += totalItems;
                    }
                }
                else
                {
                    CartItems items = new CartItems(Convert.ToInt32(Session["Item"]), count);

                    int length = master.cart_items.Count;
                    int index = -1;

                    if(length != 0)
                    {
                        for(int i = 0; i < length; i++)
                        {
                            if (master.cart_items[i].id.Equals(items.id))
                            {
                                index = i;
                                break;
                            }
                        }
                        if (index == -1)
                        {
                            master.cart_items.Add(items);
                        }
                        else
                        {
                            master.cart_items[index].quantity += 1;
                        }
                    }
                    else
                    {
                        master.cart_items.Add(items);
                    }

                    int item_new = Convert.ToInt32((Session["CartItems"]).ToString());

                    item_new += 1;
                    Session["Cartitems"] = item_new;
                    Response.Redirect("Shop.aspx");
                }

                show += "</tbody>";
                show += "</table>";

                double vat_total = sum * vat;

                display += "<h3> Cart Totals </h3>";
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

                showcart.InnerHtml = show;
                totalcart.InnerHtml = display;
            }
        }
    }
}