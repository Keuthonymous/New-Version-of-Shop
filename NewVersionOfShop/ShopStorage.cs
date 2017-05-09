using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVersionOfShop
{
    class ShopStorage : ItemStorage<Item>
    {
        public void ChangePriceBulk(string artNum, double price)
        {
            var query = from item in InternalStorage
                        where item.ArtNum.Count() >= 1
                        select item;

        }
    }
}
