using COMP2614Assign06.Common;
using COMP2614Assign06.Data;
using COMP2614Assign06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace COMP2614Assign06.Business
{
    /// <summary>
    /// ClientValidation class Validates information being entered by user and passes it on to
    /// ClientRepository if it is valid.  If it is not valid it generates an error message.
    /// </summary>
    public class ClientValidation
    {
        public static List<string> errors;//List of errors generated if information is incorrect

        /// <summary>
        /// Constructor.  Creates List of to hold string of error messages.
        /// </summary>
        static ClientValidation()
        {
            errors = new List<string>();
        }

        /// <summary>
        /// Returns a formatted error message as a string.
        /// </summary>
        public static string ErrorMessage
        {
            get
            {
                string message = "";
                foreach (string line in errors)
                {
                    message += line + "\r\n";
                }
                return message;
            }
        }

        /// <summary>
        /// Generates BindingList of Clients from information received from Client Repository Class.
        /// </summary>
        /// <returns>BindingList of Clients</returns>
        public static ClientCollection GetClients() => ClientRepository.GetClients();

        /// <summary>
        /// Validates user input for New Client to be created.
        /// </summary>
        /// <param name="client">Object from Client Class to be created</param>
        /// <returns>Passes client object to ClientRepository Class nethod AddClient if valid.  
        /// Returns -1 as an int if user input is invalid</returns>
        public static int AddClient(Client client)
        {
            if (Validate(client))
            {
                return ClientRepository.AddClient(client);
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Validates user input for Client to be updated.
        /// </summary>
        /// <param name="client">Object from Client Class to be updated</param>
        /// <returns>Passes client object to ClientRepository Class method UpdateClient if valid.
        /// Returns -1 as an int if user input is invalid</returns>
        public static int UpdateClient(Client client)
        {
            if (Validate(client))
            {
                return ClientRepository.UpdateClient(client);
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Validates user input for Client to be deleted.
        /// </summary>
        /// <param name="client">Object from Client Class to be deleted</param>
        /// <returns>Passes client object to ClientRepository Class method DeleteClient</returns>
        public static int DeleteClient(Client client) => ClientRepository.DeleteClient(client);

        /// <summary>
        /// Validates user input to insure values for ClientCode, CompanyName, Address1, Province, 
        /// Postal Code and YtdSales are all valid values.  Generates error message as a string for each invalid 
        /// value and adds string to List.  Makes sure user entry is formatted correct.
        /// </summary>
        /// <param name="client">Object from Client Class to be validated</param>
        /// <returns>Bool representing true if values are all valid or false if values are not valid</returns>
        public static bool Validate(Client client)
        {      
            bool success = true;
            errors.Clear();

            string clientPattern = @"^[A-Z][A-Z][A-Z][A-Z][A-Z]$";
            string provincePattern = @"^[A-Z\s][A-Z\s]$";
            string postalCodePattern = @"^[A-Z\s]\d[A-Z\s] \d[A-Z\s]\d$";

            if (string.IsNullOrWhiteSpace(client.ClientCode))
            {
                errors.Add("ClientCode cannot be empty");
                success = false;
            }
            else if (!Regex.IsMatch(client.ClientCode, clientPattern))
            {
                errors.Add("Client Code must be in the format of ABCDE");
                success = false;
            }

            else if (string.IsNullOrWhiteSpace(client.CompanyName))
            {
                errors.Add("Company Name cannot be empty");
                success = false;
            }

            else if (string.IsNullOrWhiteSpace(client.Address1))
            {
                errors.Add("Address1 cannot be empty");
                success = false;
            }

            else if (string.IsNullOrWhiteSpace(client.Province))
            {
                errors.Add("Province cannot be empty");
                success = false;
            }
            else if (!Regex.IsMatch(client.Province, provincePattern))
            {
                errors.Add("Province must be in the uppercase in the format of AA");
                success = false;
            }
            else if (!client.Province.Equals("ON") && !client.Province.Equals("BC")
            && !client.Province.Equals("QC") && !client.Province.Equals("NS") 
            && !client.Province.Equals("NB") && !client.Province.Equals("MB") 
            && !client.Province.Equals("PE") && !client.Province.Equals("SK") 
            && !client.Province.Equals("AB") && !client.Province.Equals("NL")
            && !client.Province.Equals("NT") && !client.Province.Equals("YT")
            && !client.Province.Equals("NU"))
            {
                errors.Add("Not a valid Province");
                success = false;
            }

            else if (string.IsNullOrWhiteSpace(client.PostalCode))
            {
                errors.Add("Postal Code cannot be empty");
                success = false;
            }
            else if (!Regex.IsMatch(client.PostalCode, postalCodePattern))
            {
                errors.Add("Postal Code must be in the uppercase in the format of A9A 9A9");
                success = false;
            }

            else if (client.YtdSales < 0)
            {
                errors.Add("YTD Sales cannot be negative");
                success = false;
            }

            return success;
        }
    }
}