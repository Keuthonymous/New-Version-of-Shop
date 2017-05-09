﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVersionOfShop
{
    class Item : IEquatable<Item>, IComparable<Item>
    {
        #region PrivateVariables
        //Contains all private variables for an instance of Item
        private string artNum;
        private string name;
        private double price;
        private string category;
        #endregion

        #region PublicProperties
        //Contains all public properties for an instance of Item
        public string ArtNum
        {
            get { return artNum; }
            set { artNum = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        #endregion
        #region Constructor
        //Item constructor
        public Item(string ArtNum, string Name, double Price, string Category)
        {
            this.ArtNum = artNum;
            this.Name = name;
            this.Price = price;
            this.Category = category;
        }
        #endregion
        #region Methods
        public bool Equals(Item other)
        {
            if (other == null) return false;
            return (this.artNum.Equals(other.artNum));
        }
        #endregion
    }
}