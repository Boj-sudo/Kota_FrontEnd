using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kota_FrontEnd
{
    public class CartItems
    {
        public int id;
        public int quantity;

        public CartItems(int id, int quantity)
        {
            this.id = id;
            this.quantity = quantity;
        }
    }
}