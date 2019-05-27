using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework7.ViewModels
{
    public class ShopItemViewModel
    {
        //Data Members
        private string mName;
        private string mDescription;
        private double mPrice;
        private int mQuantityAvailable;

        //Constructers
        public ShopItemViewModel()
        {
            
        }
        public ShopItemViewModel(string ItemName, string ItemDescription, double ItemPrice, int ItemQuantityAvailable )
        {
            ItemName = mName;
            ItemDescription = mDescription;
            ItemPrice = mPrice;
            ItemQuantityAvailable = mQuantityAvailable;
            
        }
        //Getters And setters
        public string Name
        {
            get
            {
                return mName;
            }

            set
            {
                mName = value;
            }
        }

        public string Description
        {
            get
            {
                return mDescription;
            }

            set
            {
                mDescription = value;
            }
        }

        public double Price
        {
            get
            {
                return mPrice;
            }

            set
            {
                mPrice = value;
            }
        }

        public int QuantityAvailable
        {
            get
            {
                return mQuantityAvailable;
            }

            set
            {
                mQuantityAvailable = value;
            }
        }
    }
}