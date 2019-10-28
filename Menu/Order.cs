/* Order Class
 * Author: Jake Carlson
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents a new customer order.
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        // private backing variables.
        private double salesTaxRate = 8.0;
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// A collection of items in the order.
        /// </summary>
        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }

        /// <summary>
        /// An event Handler for property changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The subtotal cost of the order.
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subtotal = 0;
                foreach(IOrderItem item in Items)
                {
                    subtotal += item.Price;
                }
                if (subtotal > 0)
                {
                    return subtotal;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// The sales tax rate for the order.
        /// </summary>
        public double SalesTaxRate
        {
            get
            {
                return salesTaxRate;
            }
            set
            {
                if (salesTaxRate < 0)
                {
                    return;
                }
                salesTaxRate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxRate"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
        } 

        /// <summary>
        /// The sales tax cost for the order.
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }

        /// <summary>
        /// The total cost of the order.
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SalesTaxCost + SubtotalCost;
            }
        }

        /// <summary>
        /// Constructor for the Order Class.
        /// </summary>
        public Order()
        {
        }

        /// <summary>
        /// Adds a new item to our order.
        /// </summary>
        /// <param name="item">The item to add to the list.</param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            NotifyAllPropertiesChanged();
        }

        /// <summary>
        /// Removes an item from our order.
        /// </summary>
        /// <param name="item">The item to remove from the lsit.</param>
        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                NotifyAllPropertiesChanged();
            }
            return removed;
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyAllPropertiesChanged();
        }

        /// <summary>
        /// Notifies when all of the properties have changed.
        /// </summary>
        protected void NotifyAllPropertiesChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
    }
}
