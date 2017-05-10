using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVersionOfShop
{
    class ShopStorage : ItemStorage<Item>
    {
        public void shopStorage()
        {
            Storage();
            InternalStorage.Add(new Item
                {
                    ArtNum = "A1234",
                    Name = " A thing",
                    Price = 66.66,
                    Category = "Something",
                    InStock = true,
                    InCart = false
                });
                //------------------------
                InternalStorage.Add(new Item
                {
                    ArtNum = "A1334",
                    Name = " Another thing",
                    Price = 76.66,
                    Category = "Something else",
                    InStock = true,
                    InCart = false
                });
                //-------------------------
                InternalStorage.Add(new Item
                {
                    ArtNum = "A1434",
                    Name = " Another thing again",
                    Price = 76.66,
                    Category = "Something else more",
                    InStock = false,
                    InCart = false
                });
                //-------------------------
                InternalStorage.Add(new Item
                {
                    ArtNum = "A1334",
                    Name = " Another thing",
                    Price = 76.66,
                    Category = "Something else",
                    InStock = false,
                    InCart = false
                });
                //-------------------------
                InternalStorage.Add(new Item
                {
                    ArtNum = "A1534",
                    Name = " Another thing again again",
                    Price = 77.66,
                    Category = "Something else again",
                    InStock = true,
                    InCart = false
                });
                //-------------------------
                InternalStorage.Add(new Item
                {
                    ArtNum = "A1634",
                    Name = "Running out of ideas for names",
                    Price = 86.66,
                    Category = "Same for Categories",
                    InStock = false,
                    InCart = false
                });
                //--------------------------
                InternalStorage.Add(new Item
                {
                    ArtNum = "A1734",
                    Name = "Too many things clearly",
                    Price = 96.66,
                    Category = "Random Shit",
                    InStock = true,
                    InCart = false
                });
        }
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

        public void AddItemToShop(Item i)
        {
            if (i.InStock == false)
            {
                i.InStock = true;
            }
        }
    }
}
