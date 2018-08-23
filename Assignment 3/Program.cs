using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Comp2614Assign03
{
    /// <summary>
    /// Class uses StreamReader to read .txt file and add information to List of Invoice information
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string path;
            Database invoices = new Database();

            if (args.Length > 0)
            {
                path = args[0];
            }
            else
            {
                Console.WriteLine("Usage: COMP2614Exercise03 invoicedata.txt");
                return;
            }

            StreamReader streamReader = null;

            string lineData;
            string[] lineElements;
            string[] invoiceListing;

            if (File.Exists(path))
            {
                try
                {
                    streamReader = new StreamReader(path);

                    while (streamReader.Peek() > 0)
                    {
                        string invoiceNumber;
                        DateTime date;
                        int discountDay;
                        int discountAmount;

                        lineData = streamReader.ReadLine();
                        lineElements = lineData.Split('|');
                        invoiceListing = lineElements[0].Split(':');

                        invoiceNumber = invoiceListing[0];
                        bool goodDate = DateTime.TryParse(invoiceListing[1], out date);
                        bool goodDiscountAmount = int.TryParse(invoiceListing[2].Substring(0, 1), out discountAmount);
                        bool goodDiscountDay = int.TryParse(invoiceListing[2].Substring(1, 2), out discountDay);

                        //create list of inventory information
                        List<InventoryItem> inventoryInformation = new List<InventoryItem>();

                        for (int index = 1; index < lineElements.Length; index++)
                        {
                            int qty;
                            string sku;
                            string description;
                            decimal price;
                            string hasPST;

                            string[] tempInventory = lineElements[index].Split(':');
                            bool goodQty = int.TryParse(tempInventory[0], out qty);
                            sku = tempInventory[1];
                            description = tempInventory[2];
                            bool goodPrice = decimal.TryParse(tempInventory[3], out price);
                            hasPST = tempInventory[4];

                            //add inventory information to List of inventory information
                            inventoryInformation.Add(new InventoryItem
                            {
                                Qty = qty,
                                Sku = sku,
                                Description = description,
                                Price = price,
                                HasPST = hasPST
                            });
                        }
                        //add invoice header information and List of inventory information to List of Invoice information
                        invoices.Add(new Invoice
                        {
                            InvoiceNumber = invoiceNumber,
                            Date = date,
                            DiscountAmount = discountAmount,
                            DiscountDay = discountDay,
                            Inventory = inventoryInformation
                        });
                    }

                    //Print Invoice Listing title to Console.
                    //Iterate through List of invoices and print each one formatted by PrintToConsole class
                    PrintToConsole.printInvoiceListing();
                    foreach (Invoice invoice in invoices)
                    {
                        PrintToConsole.PrintInvoice(invoice);
                    }
                }     
                catch (Exception ex)
                {
                    Console.WriteLine("\n{0}\n", ex.Message);
                }
                finally
                {
                    if (streamReader != null)
                    {                        
                        streamReader.Close(); 
                    }                         
                }                            
            }
            else
            {
                Console.WriteLine("\nFile not found.\n");
            }
        }
    }
}