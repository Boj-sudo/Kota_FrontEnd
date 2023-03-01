using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kota_FrontEnd.ServiceReference;

namespace Kota_FrontEnd
{
    public partial class AboutProduct : System.Web.UI.Page
    {
        BackEndClient sr = new BackEndClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            dynamic p = sr.AboutProduct(Request.QueryString["ID"]);
            string show = "";

            show += "<div class='col-md-4 col-sm-5'>";
            show += "<div class='single-food'>";
            show += "<div class='food-img'>";
            show += "<img src='" + p.Image + "'class='img-fluid' alt=''>";
            show += "</div>";
            show += "</div>";
            show += "</div>";
            show += "<DL>";
            show += "<h5> Product Code: " + p.Code + "</h5>";
            show += "<h5> Product Name: " + p.Name + "</h5>";
            show += "<h5> Product Price: R" + Math.Round(p.Price, 2) + "</h5>";
            show += "<h5> Product Type: " + p.Type + "</h5>";
            show += "<h5> Product Special: " + p.Special + "</h5>";
            show += "<h5> Product Description: " + p.Description + "</h5>";
            show += "<h5> Product Update: " + p.Update + "</h5>";
            show += "</DL>";

            About.InnerHtml = show;
        }
    }
}