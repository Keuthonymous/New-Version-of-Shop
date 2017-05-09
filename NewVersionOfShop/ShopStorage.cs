using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVersionOfShop
{
    class ShopStorage : ItemStorage<Item>
    {
        public void ChangePriceBulk(double newPrice, string searchArtNum)
        {
            var query = from item in InternalStorage
                        where item.ArtNum == searchArtNum
                        orderby item.Price
                        select item;

            foreach (Item i in query)
            {
                i.Price = newPrice;
            }
        }
    }
}
