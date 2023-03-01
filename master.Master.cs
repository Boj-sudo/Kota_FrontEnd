using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kota_FrontEnd
{
    public partial class master : System.Web.UI.MasterPage
    {
        public static List<CartItems> cart_items = new List<CartItems>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Firstname"] != null)
            {
                loginlink.Visible = false;
                registerlink.Visible = false;
                LogoutLink.Visible = true;
                user.Visible = true;
                catalog.Visible = false;

                if (Session["type"].Equals("Manager"))
                {
                    catalog.Visible = true;
                    addprod.Visible = true;
                    admin.Visible = false;
                    remove.Visible = false;
                }
                else if (Session["type"].Equals("admin"))
                {
                    catalog.Visible = true;
                    addprod.Visible = true;
                    admin.Visible = true;
                    remove.Visible = true;
                }
            }
        }

        public static List<CartItems> GetCartItems()
        {
            return cart_items;
        }

        public static void ClearCart()
        {
            cart_items.Clear();
        }

        public static int GetIndex(int id)
        {
            int index = 0;

            foreach(CartItems c in cart_items)
            {
                if (c.id.Equals(id))
                {
                    index = cart_items.IndexOf(c);
                }
            }

            return index;
        }
    }
}