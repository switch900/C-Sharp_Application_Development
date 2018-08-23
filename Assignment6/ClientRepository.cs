using COMP2614Assign06.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign06.Data
{
    /// <summary>
    /// Class used to query SQL database.  Allows for Getting, Adding, Updating and Deleting Clients.
    /// </summary>
    class ClientRepository
    {
        /// <summary>
        /// Static Connection string for ClientRepository Class to connect to SQL Table Client029917
        /// </summary>
        private static string connString = @"Server=tcp:comp2614.database.windows.net,1433; 
                                  Initial Catalog=mc1810;
                                  User ID=student;
                                  Password=93nu5#S163;
                                  Encrypt=True;
                                  TrustServerCertificate=False;
                                  Connection Timeout=30;";

        /// <summary>
        /// Query Inserts a new client into the SQL database Client029917
        /// </summary>
        /// <param name="client">An object of of Client Class to be inserted into the database</param>
        /// <returns>Returns an Int representing how many rows where inserted into the table</returns>
        public static int AddClient(Client client)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"INSERT INTO Client029917
                                (ClientCode, CompanyName, Address1 , Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes)
                                VALUES (@clientCode, @companyName, @address1, @address2, @city, @province, 
                                    @postalCode, @ytdSales, @creditHold, @notes)";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    if (client.ClientCode != null)
                    {
                        cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@clientCode", DBNull.Value);
                    }

                    if (client.CompanyName != null)
                    {
                        cmd.Parameters.AddWithValue("@companyName", client.CompanyName);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@companyName", DBNull.Value);
                    }

                    if (client.Address1 != null)
                    {
                        cmd.Parameters.AddWithValue("@address1", client.Address1);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@address1", DBNull.Value);
                    }

                    if (client.Address2 != null)
                    {
                        cmd.Parameters.AddWithValue("@address2", client.Address2);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@address2", DBNull.Value);
                    }

                    if (client.City != null)
                    {
                        cmd.Parameters.AddWithValue("@city", client.City);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@city", DBNull.Value);
                    }

                    if (client.Province != null)
                    {
                        cmd.Parameters.AddWithValue("@province", client.Province);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@province", DBNull.Value);
                    }

                    if (client.PostalCode != null)
                    {
                        cmd.Parameters.AddWithValue("@postalCode", client.PostalCode);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@postalCode", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@ytdSales", client.YtdSales);
                    cmd.Parameters.AddWithValue("@creditHold", client.CreditHold);

                    if (client.Notes != null)
                    {
                        cmd.Parameters.AddWithValue("@notes", client.Notes);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@notes", DBNull.Value);
                    }

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }

        /// <summary>
        /// Query Updates information in the SQL database Client029917
        /// Uses the value from ClientCode as a reference for which column to Update
        /// </summary>
        /// <param name="client">An object of of Client Class to be updated in the database</param>
        /// <returns>Returns an Int representing how many rows where updated in the table</returns>
        public static int UpdateClient(Client client)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"UPDATE Client029917
                                 SET CompanyName=@companyName
                                    , Address1=@address1 
                                    , Address2=@address2
                                    , City=@city
                                    , Province=@province
                                    , PostalCode=@postalCode
                                    , YTDSales=@ytdSales
                                    , CreditHold=@creditHold
                                    , Notes=@notes
                                    WHERE ClientCode = @clientCode";


                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;


                    cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);

                    cmd.Parameters.AddWithValue("@companyName", client.CompanyName);
                    cmd.Parameters.AddWithValue("@address1", client.Address1);

                    if (client.Address2 != null)
                    {
                        cmd.Parameters.AddWithValue("@address2", client.Address2);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@address2", DBNull.Value);
                    }

                    if (client.City != null)
                    {
                        cmd.Parameters.AddWithValue("@city", client.City);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@city", DBNull.Value);
                    }

                    if (client.Province != null)
                    {
                        cmd.Parameters.AddWithValue("@province", client.Province);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@province", DBNull.Value);
                    }

                    if (client.PostalCode != null)
                    {
                        cmd.Parameters.AddWithValue("@postalCode", client.PostalCode);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@postalCode", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@ytdSales", client.YtdSales);
                    cmd.Parameters.AddWithValue("@creditHold", client.CreditHold);

                    if (client.Notes != null)
                    {
                        cmd.Parameters.AddWithValue("@notes", client.Notes);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@notes", DBNull.Value);
                    }

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }

        /// <summary>
        /// Query returns a List of all clients in the SQL database Client029917.
        /// </summary>
        /// <returns>returns customers as a BindingList</returns>
        public static ClientCollection GetClients()
        {
            ClientCollection clients; //= new ClientCollection();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT ClientCode, CompanyName, Address1 , Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes
                                 FROM Client029917";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    conn.Open();
                    clients = new ClientCollection();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string clientCode;
                        string companyName;
                        string address1;
                        string address2;
                        string city;
                        string province;
                        string postalCode;
                        decimal ytdSales;
                        bool creditHold = false;
                        string notes;

                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                clientCode = reader["ClientCode"] as string;
                            }
                            else
                            {
                                clientCode = null;
                            }
                            if (!reader.IsDBNull(1))
                            {
                                companyName = reader["CompanyName"] as string;
                            }
                            else
                            {
                                companyName = null;
                            }
                            if (!reader.IsDBNull(2))
                            {
                                address1 = reader["Address1"] as string;
                            }
                            else
                            {
                                address1 = null;
                            }
                            if (!reader.IsDBNull(3))
                            {
                                address2 = reader["Address2"] as string;
                            }
                            else
                            {
                                address2 = null;
                            }
                            if (!reader.IsDBNull(4))
                            {
                                city = reader["City"] as string;
                            }
                            else
                            {
                                city = null;
                            }
                            if (!reader.IsDBNull(5))
                            {
                                province = reader["Province"] as string;
                            }
                            else
                            {
                                province = null;
                            }
                            if (!reader.IsDBNull(6))
                            {
                                postalCode = reader["PostalCode"] as string;
                            }
                            else
                            {
                                postalCode = null;
                            }
                            ytdSales = (decimal)reader["YTDSales"];
                            creditHold = (bool)reader["CreditHold"];
                            notes = reader["Notes"] as string;
                            {
                                clients.Add(new Client
                                {
                                    ClientCode = clientCode
                                    ,
                                    CompanyName = companyName
                                    ,
                                    Address1 = address1
                                    ,
                                    Address2 = address2
                                    ,
                                    City = city
                                    ,
                                    Province = province
                                    ,
                                    PostalCode = postalCode
                                    ,
                                    CreditHold = creditHold
                                    ,
                                    YtdSales = ytdSales
                                    ,
                                    Notes = notes
                                });
                            }
                        }
                    }
                }
                return clients;
            }
        }

        /// <summary>
        /// Query deletes information from the SQL database Client029917
        /// Uses the value from ClientCode as a reference for which column to Delete
        /// </summary>
        /// <param name="client">An object from Client Class to be deleted from the database</param>
        /// <returns>Returns an Int representing how many rows where deleted from the table</returns>
        public static int DeleteClient(Client client)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"DELETE Client029917
                                 WHERE ClientCode = @clientCode";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }
    }
}