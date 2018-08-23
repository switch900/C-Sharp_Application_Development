using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp2614Assign03
{
    /// <summary>
    /// Class creates an object of Invoice information
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// constant for GST Amount
        /// </summary>
        public const decimal GST_AMOUNT = .05m;
        /// <summary>
        /// constant for PST Amount
        /// </summary>
        public const decimal PST_AMOUNT = .07m;

        /// <summary>
        /// Invoice Number
        /// </summary>
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Invoice Date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Percentage to be discounted if Invoice is paid by discountDate
        /// </summary>
        public decimal DiscountAmount { get; set; }

        /// <summary>
        /// Amount of days until discount expires as an int
        /// </summary>
        public int DiscountDay { get; set; }

        /// <summary>
        /// InventoryItem objects as a List 
        /// </summary>
        public List<InventoryItem> Inventory { get; set; }

        /// <summary>
        /// Calculation to add amount of days Discount is valid to Invoice Date
        /// </summary>
        /// <returns>Day that Discount expires as a DateTime</returns>
        public DateTime DiscountDate
        {
            get
            {
                return Date.AddDays(DiscountDay);
            }
        }

        /// <summary>
        /// calculate subtotal of all the prices from Items in the Inventory
        /// </summary>
        /// <returns>subtotal as a decimal</returns>
        public decimal Subtotal
        {
            get
            {
                decimal subtotal = 0;
                for (int index = 0; index < Inventory.Count(); index++)
                {
                    subtotal += Inventory[index].Ext;
                }
                return subtotal;
            }
        }

        /// <summary>
        /// Calculate the total GST for the invoice
        /// </summary>
        /// <returns>GST amount as a Decimal</returns>
        public decimal GST => Subtotal * GST_AMOUNT;

        /// <summary>
        /// Calculate the total PST for the invoice
        /// </summary>
        /// <returns>PST amount as a Decimal</returns>
        public decimal PST
        {
            get
            {
                decimal pst= 0m;

                for (int index = 0; index < Inventory.Count(); index++)
                {
                    if (Inventory[index].HasPST.Equals("Y")) 
                    pst = (Inventory[index].Ext * PST_AMOUNT)+pst;
                }
                return pst;
            }
        }

        /// <summary>
        /// Total price of all items on invoice including applicable GST and PST tax
        /// </summary>
        public decimal Total
        {
            get
            {
                return Subtotal + GST + PST;

            }
        }

        /// <summary>
        /// Total discount to be applied if invoice is paid before Discount Date
        /// </summary>
        public decimal DiscountTotal
        {
            get
            {
                decimal discountAmount = 0m;
                {
                    discountAmount = Total * (DiscountAmount / 100);
                }
                return discountAmount;
            }
        }

        /// <summary>
        /// ToString method of fields from Invoice class
        /// </summary>
        /// <returns>ields as a string</returns>
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", Date, InvoiceNumber, DiscountAmount, DiscountDay, DiscountDate);
        }
    }
}