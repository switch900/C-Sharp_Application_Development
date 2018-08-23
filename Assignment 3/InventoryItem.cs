using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp2614Assign03
{
    /// <summary>
    /// Class creates an object of Inventory Items
    /// </summary>
    public class InventoryItem
    {

        /// <summary>
        /// Quantity of items
        /// </summary>
        ///  
        public int Qty { get; set; }

        /// <summary>
        /// SKU reference number for item
        /// </summary>
        ///  
        public string Sku { get; set; }

        /// <summary>
        /// Description of item
        /// </summary>
        ///  
        public string Description { get; set; }

        /// <summary>
        /// Unit Price for item
        /// </summary>
        ///  
        public decimal Price { get; set; }

        /// <summary>
        /// Reference to determine if item should be assessed PST.  
        /// Y for Yes it has PST and N for No it doesn't get charged PST.
        /// </summary>
        ///  
        public string HasPST { get; set; }

        /// <summary>
        /// Calculation to determine the total price for a line by multiplying the quantity by the unit price.
        /// </summary>
        ///  
        public decimal Ext
        {
            get { return Qty * Price; }
        }

        /// <summary>
        /// ToString method of fields from Invoice class
        /// </summary>
        /// <returns>fields as a string</returns>  
        public override string ToString()
        {
            return $"{Qty}, {Sku}, {Description}, {"PST= " + HasPST}";
        }
    }
}