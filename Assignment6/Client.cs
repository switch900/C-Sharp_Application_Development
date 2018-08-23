using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign06.Common
{
    /// <summary>
    /// Class creates an object of Client information
    /// </summary>
    public class Client
    { 
        /// <summary>
        /// ClientCode as a string
        /// </summary>
        public string ClientCode { get; set; }

        /// <summary>
        /// CompanyName as a string
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Address1 as a string
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Address2 as a string
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// City as a string
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Province as a string
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// PostalCode as a string
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// CreditHold as a bool
        /// </summary>
        public bool CreditHold { get; set; }

        /// <summary>
        /// YtdSales as a decimal
        /// </summary>
        public decimal YtdSales { get; set; }

        /// <summary>
        /// Notes as a string
        /// </summary>
        public string Notes { get; set; }
    }
}
