using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assignment04
{
    /// <summary>
    /// Class used to query SQL database
    /// </summary>
    class CustomerRepository
    {
        /// <summary>
        /// Query returns a List of all customers in the database.
        /// </summary>
        /// <returns>returns customers as a List</returns>
        public static CustomerCollection GetCustomers()
        {
            CustomerCollection customers;

            string connString = @"Server=tcp:comp2614.database.windows.net,1433; 
                                  Initial Catalog=mc1810;
                                  User ID=student;
                                  Password=93nu5#S163;
                                  Encrypt=True;
                                  TrustServerCertificate=False;
                                  Connection Timeout=30;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT CompanyName, Address, City, Province, PostalCode, CreditHold
                                 FROM Customer";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    conn.Open();
                    customers = new CustomerCollection();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string companyName;
                        string address;
                        string city;
                        string province;
                        string postalCode;
                        bool creditHold = false;
                        int colOrdinal = reader.GetOrdinal("creditHold");
                        while (reader.Read())
                        {
                            companyName = reader["CompanyName"] as string;
                            address = reader["Address"] as string;
                            city = reader["City"] as string;
                            province = reader["Province"] as string;
                            postalCode = reader["PostalCode"] as string;
                            if (!reader.IsDBNull(colOrdinal))
                            {
                                creditHold = reader.GetBoolean(colOrdinal);
                                customers.Add(new Customer(companyName, address, city, province, postalCode, creditHold));
                            }
                            else
                            {
                                customers.Add(new Customer(companyName, address, city, province, postalCode, creditHold));
                            }
                        }
                    }
                    return customers;
                }
            }
        }

        /// <summary>
        /// Query returns a list of Distinct provinces
        /// </summary>
        /// <returns>returns provinces as a List</returns>
        public static CustomerCollection GetProvinces()
        {
            CustomerCollection provinces;

            string connString = @"Server=tcp:comp2614.database.windows.net,1433; 
                                  Initial Catalog=mc1810;
                                  User ID=student;
                                  Password=93nu5#S163;
                                  Encrypt=True;
                                  TrustServerCertificate=False;
                                  Connection Timeout=30;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT DISTINCT Province
                                 FROM Customer";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    conn.Open();
                    provinces = new CustomerCollection();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string province;

                        while (reader.Read())
                        {
                            province = reader["Province"] as string;
                            if (reader.IsDBNull(0))
                            {
                                provinces.Add(new Customer(province));
                            }
                            else
                            {
                                provinces.Add(new Customer(province));
                            }
                        }
                    }
                    return provinces;
                }
            }
        }

        /// <summary>
        /// Query returns a List of customers based on specific province.
        /// </summary>
        /// <param name="provinceChoice"></param>
        /// <returns>Returns customers from specific province as a List</returns>
        public static CustomerCollection GetInfoByProvince(string provinceChoice)
        {
            CustomerCollection provinces;

            string connString = @"Server=tcp:comp2614.database.windows.net,1433; 
                                  Initial Catalog=mc1810;
                                  User ID=student;
                                  Password=93nu5#S163;
                                  Encrypt=True;
                                  TrustServerCertificate=False;
                                  Connection Timeout=30;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT CompanyName, Address, City, Province, PostalCode, CreditHold
                                 FROM Customer
                                 WHERE Province = @Province
                                 ORDER BY companyName ASC";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@Province", provinceChoice);
                    conn.Open();
                    provinces = new CustomerCollection();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string companyName;
                        string address;
                        string city;
                        string province;
                        string postalCode;
                        bool creditHold = false;
                        int colOrdinal = reader.GetOrdinal("creditHold");

                        while (reader.Read())
                        {
                            companyName = reader["CompanyName"] as string;
                            address = reader["Address"] as string;
                            city = reader["City"] as string;
                            province = reader["Province"] as string;
                            postalCode = reader["PostalCode"] as string;
                            if (!reader.IsDBNull(colOrdinal))
                            {
                                creditHold = reader.GetBoolean(colOrdinal);
                                provinces.Add(new Customer(companyName, address, city, province, postalCode, creditHold));
                            }
                            else
                            {
                                provinces.Add(new Customer(companyName, address, city, province, postalCode, creditHold));

                            }
                        }
                    }
                    ConsolePrinter.PrintCustomers(provinces);
                    return provinces;
                }
            }
        }
    }
}