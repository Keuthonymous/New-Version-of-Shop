using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVersionOfShop
{
    class ShoppingCart : ItemStorage<Item>
    {
        public ShoppingCart()
        {
            InternalStorage = new List<Item>();
        }

        public void AddToCart(Item itemToAdd)
        {
            InternalStorage.Add(itemToAdd);
        }
        public IEnumerable<Item> GetItemsInCart()
        {
            var query = from i in InternalStorage
                        where i.InCart == true
                        orderby i.Name
                        select i;

            if (query != null)
            {
                return query;
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Item> GetReceipt()
        {
            return GetItemsInCart();
        }
    }
}
