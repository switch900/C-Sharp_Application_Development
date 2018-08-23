using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign06.Common
{
    /// <summary>
    /// BindingList of objects from Client Class
    /// </summary>
    public class ClientCollection : BindingList<Client>
    {
        /// <summary>
        /// Calculates YTD Sales of all customers in List 
        /// </summary>
        /// <return>Sum of all values from variable YTDSales in ClientCollection returned as a Decimal</return>
        public decimal TotalYTDSales => this.Sum(x => x.YtdSales);

        /// <summary>
        /// Calculates total accounts with Credit hold in list
        /// </summary>
        /// <returns>Count of all values from variable CreditHold in ClientCollection returned as an int</returns>
        public int CreditHoldCount() => this.Count(y => y.CreditHold);
    }
}