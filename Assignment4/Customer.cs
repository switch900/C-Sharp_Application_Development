using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assignment04
{
    /// <summary>
    /// Class creates an object of Customer information
    /// </summary>
    class Customer
    {
        public Customer(String province)
        {
            this.Province = province;
        }
        /// <summary>
        /// Constructor for objects of Customer Class
        /// </summary>
        /// <param name="companyName"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="province"></param>
        /// <param name="postalCode"></param>
        /// <param name="creditHold"></param>
        public Customer(string companyName, string address, string city, string province, string postalCode, bool creditHold)
        {
            this.CompanyName = companyName;
            this.Address = address;
            this.City = city;
            this.Province = province;
            this.PostalCode = postalCode;
            this.CreditHold = creditHold;
        }
        /// <summary>
        /// Company Name as a string
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// Address as a string
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// City as a string
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Province as a string
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// Postal Code as a string
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// CreditHold as a bool
        /// </summary>
        public bool CreditHold { get; set; }

        /// <summary>
        /// ToString method for Customer class
        /// </summary>
        /// <returns>Fields as String</returns>
        public override string ToString() => string.Format($"{CompanyName}: {Address}: {City}: {Province}: {PostalCode}: {CreditHold}");
    }
}