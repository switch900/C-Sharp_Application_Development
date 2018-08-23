using COMP2614Assign06.Business;
using COMP2614Assign06.Common;
//using COMP2614Assign06;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace COMP2614Assign06

{
    public partial class ClientEditDialog : Form
    {
        public ClientViewModel ClientVM { get; set; }

        public ClientEditDialog()
        {
            InitializeComponent();
        }

        private void ProductEditDialog_Load(object sender, EventArgs e)
        {
            SetBindings();
        }
        //    string connString = @"Server=tcp:comp2614.database.windows.net,1433; 
        //                          Initial Catalog=mc1810;
        //                          User ID=student;
        //                          Password=93nu5#S163;
        //                          Encrypt=True;
        //                          TrustServerCertificate=False;
        //                          Connection Timeout=30;";

        //    SqlConnection conn = new SqlConnection(connString);
        //    conn.Open();
        //    SqlCommand sc = new SqlCommand("select Abbreviation from Province", conn);
        //    SqlDataReader reader;

        //    reader = sc.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("provinceAbbreviation", typeof(string));
        //    dt.Load(reader);

        //    comboBox1.ValueMember = "provinceAbbreviation";
        //    comboBox1.DataSource = dt;

        //    conn.Close();
        //}


        public void SetBindings()
        {
            textBoxClientCode.DataBindings.Add("Text", ClientVM, "ClientCode", true, DataSourceUpdateMode.OnValidation, nullValue: "");
            textBoxCompanyName.DataBindings.Add("Text", ClientVM, "CompanyName");
            textBoxAddress1.DataBindings.Add("Text", ClientVM, "Address1");
            textBoxAddress2.DataBindings.Add("Text", ClientVM, "Address2");
            textBoxCity.DataBindings.Add("Text", ClientVM, "City");
            comboBox1.DataBindings.Add("Text", ClientVM, "Province");
            textBoxPostalCode.DataBindings.Add("Text", ClientVM, "PostalCode");
            textBoxNotes.DataBindings.Add("Text", ClientVM, "Notes");
            textBoxYTDSales.DataBindings.Add("Text", ClientVM, "YTDSales", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");
            checkBoxCreditHold.DataBindings.Add("Checked", ClientVM, "CreditHold");
        }

        /// <summary>
        /// Validates that user input is valid when Button1 is clicked.
        /// If user input is valid then passes on input.  If
        /// user input is not valid then displays Error containing
        /// the error message string from ClientValidation Class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {

            string errorMessage = "";
            errorProvider1.SetError(button1, "");

            if (ClientValidation.Validate(ClientVM.GetDisplayClient()))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                errorMessage = ClientValidation.ErrorMessage;
                errorProvider1.SetError(button1, errorMessage);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }

        private void TextBoxClientCode_Click(object sender, EventArgs e)
        {
            textBoxClientCode.Focus();
        }

        private void TextBoxCompanyName_Click(object sender, EventArgs e)
        {
            textBoxCompanyName.Focus();
        }

        private void TextBoxAddress2_Click(object sender, EventArgs e)
        {
            textBoxAddress2.Focus();
        }

        private void TextBoxNotes_Click(object sender, EventArgs e)
        {
            textBoxNotes.Focus();
        }

        private void TextBoxCity_Click(object sender, EventArgs e)
        {
            textBoxCity.Focus();
        }

        private void TextBoxPostalCode_Click(object sender, EventArgs e)
        {
            textBoxPostalCode.Focus();
        }

        private void TextBoxYTDSales_Click(object sender, EventArgs e)
        {
            textBoxYTDSales.Focus();
        }

        private void CheckBoxCreditHold_Click(object sender, EventArgs e)
        {
            checkBoxCreditHold.Focus();
        }

        private void TextBoxAddress1_Click_1(object sender, EventArgs e)
        {
            textBoxAddress1.Focus();
        }

        public string GetProvinceFromList(int x)
        {
            return (comboBox1.Items[x].ToString());
        }

        private void TextBoxClientCode_DoubleClick(object sender, EventArgs e)
        {
            textBoxClientCode.SelectAll();
        }

        private void TextBoxCompanyName_DoubleClick(object sender, EventArgs e)
        {
            textBoxCompanyName.SelectAll();
        }

        private void TextBoxAddress1_DoubleClick(object sender, EventArgs e)
        {
            textBoxAddress1.SelectAll();
        }

        private void TextBoxAddress2_DoubleClick(object sender, EventArgs e)
        {
            textBoxAddress2.SelectAll();
        }

        private void TextBoxNotes_DoubleClick(object sender, EventArgs e)
        {
            textBoxNotes.SelectAll();
        }

        private void TextBoxCity_TextChanged(object sender, EventArgs e)
        {
            textBoxCity.SelectAll();
        }

        private void ComboBox1_Enter(object sender, EventArgs e)
        {
            comboBox1.SelectAll();
        }

        private void TextBoxPostalCode_DoubleClick(object sender, EventArgs e)
        {
            textBoxPostalCode.SelectAll();
        }

        private void TextBoxYTDSales_DoubleClick(object sender, EventArgs e)
        {
            textBoxYTDSales.SelectAll();
        }

        private void TextBoxClientCode_Leave(object sender, EventArgs e)
        {
            if (textBoxClientCode.Text == "")
            {
                textBoxClientCode.Focus();
                textBoxClientCode.Text = ClientVM.clientCode;
            }
        }
    }
}