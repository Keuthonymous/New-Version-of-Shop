using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVersionOfShop
{
    class ShoppingCart : ItemStorage<Item>
    {
        public void AddToCart(Item i)
        {
            if (i.InCart == false)
            {
                i.InCart = true;
            }
        }
        public IEnumerable<Item> Checkout()
        {
            var query = from i in InternalStorage
                        where i.InCart == true
                        orderby i.Name
                        select i;

            return query;
        }

        public IEnumerable<Item> GetReceipt()
        {
            return Checkout();
        }
    }
}
