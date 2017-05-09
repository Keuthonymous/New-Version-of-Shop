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
        protected List<T> InternalStorage;
        #endregion

        #region Properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        #region Constructor
        public void Storage()
        {
            this.InternalStorage = new List<T>();
        }
        #endregion
        #region Methods
        //Adds items to list
        public void Add(T itemToAdd)
        {
            InternalStorage.Add(itemToAdd);
        }

        //Removes Items from list
        public void Remove(T itemToRemove)
        {
            InternalStorage.Remove(itemToRemove);
        }

        //Sort Items
        public void Sort()
        {
            InternalStorage.Sort();
        }

        //Gets all items in InternalStorage
        public IEnumerable<Item> GetAllItems()
        {
            return InternalStorage;
        }

        //IEnumerator method
        public IEnumerator<T> GetEnumerator()
        {
            return InternalStorage.GetEnumerator();
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion
    }
}
