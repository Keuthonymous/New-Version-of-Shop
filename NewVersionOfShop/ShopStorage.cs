using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVersionOfShop
{
    class ShopStorage : ItemStorage<Item>
    {
        public void ChangePriceBulk(double price, string artNum)
        {
            int count = InternalStorage.Where(x => x.Equals(artNum)).Count();
        }
    }
}
