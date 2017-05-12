using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVersionOfShop
{
    class ItemStorage<T> : IEnumerable<T>
        where T : Item, IEquatable<T>, IComparable<T>
    {
        #region Variables
        protected int id;
        protected List<T> InternalStorage = new List<T>();
        #endregion

        #region Properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        #endregion
        #region SearchParams
        //Get all items in stock
        public IEnumerable<T> GetItemsInStock()
        {
            var query = from item in InternalStorage
                        select item;

            return query;
        }

        //Sorts all items by price regardless if InStock == true 
        public IEnumerable<T> SortByPrice()
        {
            var query = from item in InternalStorage
                        orderby item.Price
                        select item;

            return query;
        }

        //Sorts all items by article number regardless if InStock == true
        public IEnumerable<T> SortByArtNum()
        {
            var query = from item in InternalStorage
                        orderby item.ArtNum
                        select item;

            return query;
        }

        //Sorts all items by category regardless if InStock == true
        public IEnumerable<T> SortByCat()
        {
            var query = from item in InternalStorage
                        orderby item.Category
                        select item;

            return query;
        }

        //Sorts all items by name regardless if InStock == true
        public IEnumerable<T> SortByName()
        {
            var query = from item in InternalStorage
                        orderby item.Name
                        select item;

            return query;
        }

        //Returns all items with names that match the user input
        public IEnumerable<T> GetItemFromName(string searchName)
        {
            var query = from item in InternalStorage
                        where item.Name == searchName
                        orderby item.Name
                        select item;

            return query;
        }

        //Returns all items with prices that match user input
        public IEnumerable<T> GetItemFromPrice(double searchPrice)
        {
            var query = from item in InternalStorage
                        where item.Price == searchPrice
                        orderby item.Price
                        select item;

            return query;
        }

        //Returns all items with article number that match user input
        public IEnumerable<T> GetItemfromArtNum(string searchArtNum)
        {
            var query = from item in InternalStorage
                        where item.ArtNum == searchArtNum
                        orderby item.ArtNum
                        select item;

            return query;
        }

        //Returns all items with category that matches user input
        public IEnumerable<T> GetItemFromCategory(string searchCat)
        {
            var query = from item in InternalStorage
                        where item.Category == searchCat
                        orderby item.Name
                        select item;

            return query;
        }

        //Returns items with higher price than that specified by user input
        public IEnumerable<T> GetItemOverPrice(double searchPrice)
        {
            var query = from item in InternalStorage
                        where item.Price >= searchPrice
                        orderby item.Price
                        select item;

            return query;
        }

        //Returns items with lower price than that specified by user input
        public IEnumerable<T> GetItemUnderPrice(double searchPrice)
        {
            var query = from item in InternalStorage
                        where item.Price <= searchPrice
                        orderby item.Price
                        select item;

            return query;
        }

        //Gets all items in InternalStorage
        public IEnumerable<T> GetAllItems()
        {
            var query = from i in InternalStorage
                        select i;

            return query;
        }

        //Adds an item to a list
        public T Add(string itemToAdd)
        {
            var query = (from i in InternalStorage
                        where i.Name == itemToAdd
                        select i).FirstOrDefault();
        }
        #endregion
        #region Methods
        //IEnumerator method
        public IEnumerator<T> GetEnumerator()
        {
            return InternalStorage.GetEnumerator();
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public ItemStorage()
        {
            InternalStorage = new List<T>();
        }
        #endregion
    }
}
