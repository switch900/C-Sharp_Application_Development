using COMP2614Assign06.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign06
{
    /// <summary>
    /// ClientViewModel Class is used to pass values between objects of ClientCollection 
    /// and objects accesed from SQL Table by ClientRepository Class
    /// </summary>
    public class ClientViewModel : INotifyPropertyChanged
    {
        public string clientCode;
        public string companyName;
        public string address1;
        public string address2;
        public string city;
        public string province;
        public string postalCode;
        public decimal ytdSales;
        public bool creditHold;
        public string notes;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invokes PropertyChanged method when values are modified
        /// </summary>
        /// <param name="propertyName">Variable to be modified</param>
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public ClientViewModel()
        {
        }

        /// <summary>
        /// Constructor to create a collection of clients
        /// </summary>
        /// <param name="clients">BindingList of clients from ClientCollection class</param>
        public ClientViewModel(ClientCollection clients)
        {
            this.Clients = clients;
        }

        public string ClientCode
        {
            get { return clientCode; }
            set
            {
                clientCode = value;
                OnPropertyChanged();
            }
        }
        public string CompanyName
        {
            get { return companyName; }
            set
            {
                companyName = value;
                OnPropertyChanged();
            }
        }

        public string Address1
        {
            get { return address1; }
            set
            {
                address1 = value;
                OnPropertyChanged();
            }
        }

        public string Address2
        {
            get { return address2; }
            set
            {
                address2 = value;
                OnPropertyChanged();
            }
        }

        public string City
        {
            get { return city; }
            set
            {
                city = value;
                OnPropertyChanged();
            }
        }

        public string Province
        {
            get { return province; }
            set
            {
                province = value;
                OnPropertyChanged();
            }
        }

        public string PostalCode
        {
            get { return postalCode; }
            set
            {
               postalCode = value;
                OnPropertyChanged();
            }
        }

        public decimal YtdSales
        {
            get { return ytdSales; }
            set
            {
                ytdSales = value;
                OnPropertyChanged();
            }
        }

        public bool CreditHold
        {
            get { return creditHold; }
            set
            {
                creditHold = value;
                OnPropertyChanged();
            }
        }

        public string Notes
        {
            get { return notes; }
            set
            {
                notes = value;
                OnPropertyChanged();
            }
        }

        public ClientCollection Clients { get; set; }

        /// <summary>
        /// Sets display values for object
        /// </summary>
        /// <param name="client">Object to be displayed</param>
        public void SetDisplayClient(Client client)
        {
            this.ClientCode = client.ClientCode;
            this.CompanyName = client.CompanyName;
            this.Address1 = client.Address1;
            this.Address2 = client.Address2;
            this.City = client.City;
            this.Province = client.Province;
            this.PostalCode = client.PostalCode;
            this.YtdSales = client.YtdSales;
            this.CreditHold = client.CreditHold;
            this.Notes = client.Notes;         
        }

        /// <summary>
        /// Sets values for object to be saved
        /// </summary>
        /// <param name="collectionIndex">Position in collection of object to be saved</param>
        /// <returns>Object from collection that has been saved</returns>
        public Client SaveClient(int collectionIndex)
        {
            this.Clients[collectionIndex].ClientCode = this.clientCode;
            this.Clients[collectionIndex].CompanyName = this.companyName;
            this.Clients[collectionIndex].Address1 = this.address1;
            this.Clients[collectionIndex].Address2 = this.address2;
            this.Clients[collectionIndex].City = this.city;
            this.Clients[collectionIndex].Province = this.province;
            this.Clients[collectionIndex].PostalCode = this.postalCode;
            this.Clients[collectionIndex].YtdSales = this.ytdSales;
            this.Clients[collectionIndex].CreditHold = this.creditHold;
            this.Clients[collectionIndex].Notes = this.notes;

            return this.Clients[collectionIndex];
        }

        /// <summary>
        /// Gets values for object to be displayed
        /// </summary>
        /// <returns>New Client object</returns>
        public Client GetDisplayClient()
        {
            return new Client {   ClientCode = this.ClientCode
                                , CompanyName = this.CompanyName
                                , Address1 = this.Address1
                                , Address2 = this.Address2
                                , City = this.City
                                , Province = this.Province
                                , PostalCode = this.PostalCode
                                , YtdSales = this.YtdSales
                                , CreditHold = this.CreditHold
                                , Notes = this.Notes };
        }
    }
}