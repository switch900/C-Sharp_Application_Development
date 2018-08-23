using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp2614Assign03
{
    /// <summary>
    /// Class formats and prints information from Invoice to console
    /// </summary>
    class PrintToConsole
    {
        private static String line = new String('-', 61);

        /// <summary>
        /// Prints in the heading line for all the invoice as "Invoice Listing" with a line separator.
        /// </summary>
        public static void printInvoiceListing()
        {
            Console.WriteLine("Invoice Listing");
            Console.WriteLine(line);
        }

        /// <summary>
        /// Prints the body of the invoice.  Adds up the prices for the invoice to get a subtotal.
        /// Calculates the value of the GST and PST and adds those values to the subtotal to get a final total
        /// Multiplies the total by the discount amount to find out the total discount if invoice is paid early.
        /// </summary>
        /// <param name="invoice">\Object from Invoice class</param>
        public static void PrintInvoice(Invoice invoice)
        {
            Console.WriteLine("{0,13}{1,-8}"
                    , "\nInvoice Number: "
                    , invoice.InvoiceNumber);
            Console.WriteLine("{0,13}{1,-8}"
                    , "Invoice Date:   "
                    , invoice.Date.ToString("MMM d, yyyy"));//prints the invoice date in format like Jan 1, 2018
            Console.WriteLine("{0,13}{1,-8}"
                , "Discount Date:  "
                , invoice.DiscountDate.ToString("MMM d, yyyy"));//prints the invoice discount date in format like Jan 1, 2018
            Console.WriteLine("{0,13}{1,-16}"
                , "Term:           "
                , $"{invoice.DiscountAmount:F2}" + "% " + invoice.DiscountDay + " days ADI");//prints the discount amount in format like 1.00

            Console.WriteLine(line);

            Console.WriteLine("{0,-4}{1,-12}{2,-23}{3,7} {4,-5} {5,8}"
                            , "Qty"
                            , "SKU"
                            , "Description"
                            , "Price"
                            , "PST"
                            , "Ext");
            Console.WriteLine(line);
            //iterate through the invoice and prints all the inventory items
            foreach (InventoryItem item in invoice.Inventory)
            {
                if (item != null)
                {
                    PrintDescription(item);
                }
            }
            Console.WriteLine(line);
            Console.WriteLine("{0,25}    {1,32}",
                            "Subtotal:", String.Format("{0:N}", invoice.Subtotal));
            Console.WriteLine("{0,20}   {1,38}", "GST:", String.Format("{0:N}", invoice.GST));

            if (invoice.PST > 0) //If PST amount from invoice is greater than 0 print out the total PST. 
            {
                Console.WriteLine("{0,20}   {1,38}", "PST:", String.Format("{0:N}", invoice.PST));
            }
            Console.WriteLine(line);
            Console.WriteLine("{0,22}   {1,37}"
                            , "Total:", String.Format("{0:N}\n", invoice.Total));
            Console.WriteLine("{0,25}  {1,34}\n"
                           , "Discount:", String.Format("{0:N}", invoice.DiscountTotal));
        }

        /// <summary>
        /// Prints out the item description from the Inventory Item
        /// </summary>
        /// <param name="inventoryItem">Object from InventoryItem class</param>
        public static void PrintDescription(InventoryItem inventoryItem)
        {
            Console.WriteLine("{0,3} {1,-8}   {2,-20} {3,10:N}  {4,-3}{5,10:N}", inventoryItem.Qty, inventoryItem.Sku, inventoryItem.Description, inventoryItem.Price, inventoryItem.HasPST, inventoryItem.Ext);
        }
    }
}