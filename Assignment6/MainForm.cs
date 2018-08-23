using COMP2614Assign06.Business;
using COMP2614Assign06.Common;
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
    public partial class MainForm : Form
    {
        private ClientViewModel clientVM;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                bool configured = false;
                clientVM = new ClientViewModel(ClientValidation.GetClients());
                SetBindings(configured);
                labelTotalYTDSales.Text = clientVM.Clients.TotalYTDSales.ToString();
                labelTotalCreditHold.Text = clientVM.Clients.CreditHoldCount().ToString();
                if (configured)
                {
                    SetupDataGridView();
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetBindings(bool configured)
        {
            dataGridViewClients.AutoGenerateColumns = !configured;
            dataGridViewClients.DataSource = clientVM.Clients;
        }

        private void SetupDataGridView()
        {
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClients.MultiSelect = false;
            dataGridViewClients.AllowUserToAddRows = false;
            dataGridViewClients.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewClients.AllowUserToOrderColumns = false;
            dataGridViewClients.AllowUserToResizeColumns = false;
            dataGridViewClients.AllowUserToResizeRows = false;
            dataGridViewClients.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            DataGridViewTextBoxColumn clientCode = new DataGridViewTextBoxColumn
            {
                Name = "clientCode",
                DataPropertyName = "ClientCode",
                HeaderText = "ClientCode",
                Width = 50
            };
            clientCode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            clientCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(clientCode);

            DataGridViewTextBoxColumn companyName = new DataGridViewTextBoxColumn
            {
                Name = "companyName",
                DataPropertyName = "CompanyName",
                HeaderText = "CompanyName",
                Width = 200,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            dataGridViewClients.Columns.Add(companyName);

            DataGridViewTextBoxColumn address1 = new DataGridViewTextBoxColumn
            {
                Name = "address1",
                DataPropertyName = "Address1",
                HeaderText = "Address1",
                Width = 200,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            dataGridViewClients.Columns.Add(address1);

            DataGridViewTextBoxColumn address2 = new DataGridViewTextBoxColumn
            {
                Name = "address2",
                DataPropertyName = "Address2",
                HeaderText = "Address2",
                Width = 100
            };
            address2.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            address2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            address2.DefaultCellStyle.Format = "N2";
            address2.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(address2);

            DataGridViewTextBoxColumn city = new DataGridViewTextBoxColumn
            {
                Name = "city",
                DataPropertyName = "City",
                HeaderText = "City",
                Width = 100
            };
            city.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            city.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            city.DefaultCellStyle.Format = "N2";
            city.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(city);

            DataGridViewTextBoxColumn province = new DataGridViewTextBoxColumn
            {
                Name = "province",
                DataPropertyName = "Province",
                HeaderText = "Province",
                Width = 20
            };
            province.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            province.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            province.DefaultCellStyle.Format = "N2";
            province.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(province);

            DataGridViewTextBoxColumn postalCode = new DataGridViewTextBoxColumn
            {
                Name = "postalCode",
                DataPropertyName = "PostalCode",
                HeaderText = "PostalCode",
                Width = 10
            };
            postalCode.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            postalCode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            postalCode.DefaultCellStyle.Format = "N2";
            postalCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(postalCode);

            DataGridViewTextBoxColumn ytdSales = new DataGridViewTextBoxColumn
            {
                Name = "ytdSales",
                DataPropertyName = "YTDSales",
                HeaderText = "YTD Sales",
                Width = 10
            };
            ytdSales.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            ytdSales.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ytdSales.DefaultCellStyle.Format = "N2";
            ytdSales.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(ytdSales);

            DataGridViewCheckBoxColumn creditHold = new DataGridViewCheckBoxColumn
            {
                Name = "creditHold",
                DataPropertyName = "creditHold",
                HeaderText = "CreditHold",
                Width = 50,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            dataGridViewClients.Columns.Add(creditHold);

            DataGridViewTextBoxColumn notes = new DataGridViewTextBoxColumn
            {
                Name = "notes",
                DataPropertyName = "notes",
                HeaderText = "Notes",
                Width = 10
            };
            notes.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            notes.DefaultCellStyle.Format = "N2";
            notes.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(notes);

            DataGridViewCheckBoxColumn verifyDelete = new DataGridViewCheckBoxColumn
            {
                Name = "verifyDelete",
                DataPropertyName = "verifyDelete",
                HeaderText = "VerifyDelete",
                Width = 50,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            dataGridViewClients.Columns.Add(verifyDelete);
        }

        /// <summary>
        /// Opens ClientEditDialog Form which allows user to update client info.  If info is valid it updates the
        /// SQL table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewClients_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridViewClients.CurrentRow.Index;
                clientVM.SetDisplayClient(clientVM.Clients[index]);

                ClientEditDialog dlg = new ClientEditDialog
                {
                    ClientVM = clientVM
                };

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    clientVM.SaveClient(index);
                    clientVM.Clients.ResetItem(index);
                    ClientValidation.UpdateClient(clientVM.Clients[index]);
                    RefreshMainForm();
                }

                dlg.Dispose();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Opens ClientEditDialog Form which allows user to update client info.  If info is valid it updates the
        /// SQL table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridViewClients.CurrentRow.Index;
                clientVM.SetDisplayClient(clientVM.Clients[index]);

                ClientEditDialog dlg = new ClientEditDialog
                {
                    ClientVM = clientVM
                };

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    clientVM.SaveClient(index);
                    clientVM.Clients.ResetItem(index);
                    ClientValidation.UpdateClient(clientVM.Clients[index]);
                    RefreshMainForm();
                }

                dlg.Dispose();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Opens ClientEditDialog Form which allows user to update client info.  If info is valid it creates a new client
        /// in the SQL Table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNewClient_Click(object sender, EventArgs e)
        {
            try
            {
                clientVM.SetDisplayClient(new Client());

                ClientEditDialog dlg = new ClientEditDialog
                {
                    ClientVM = clientVM
                };

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ClientValidation.AddClient(clientVM.GetDisplayClient());
                    ClientValidation.UpdateClient(clientVM.GetDisplayClient());
                    RefreshMainForm();
                }
                dlg.Dispose();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// If the CheckboxVerifyDelete is clicked it opens a messagebox asking user to confirm deletion of record.
        /// If Checkbox is checked and user hits OK in message box then client is removed from the SQL table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxVerifyDelete.Checked)
                {
                    DialogResult dialogResult = MessageBox.Show("Press Yes to delete item from table", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int index = dataGridViewClients.CurrentRow.Index;
                        clientVM.SetDisplayClient(clientVM.Clients[index]);
                        ClientValidation.DeleteClient(clientVM.GetDisplayClient());
                        RefreshMainForm();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                    }
                }
                else
                {
                    MessageBox.Show("Check Verify Delete Box to delete customer", "Verify Delete not checked", MessageBoxButtons.OK);
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Refreshes dataGridViewClients, labelTotalYTDSales and labelTotalCreditHold
        /// </summary>
        private void RefreshMainForm()
        {
            clientVM.Clients = ClientValidation.GetClients();
            dataGridViewClients.DataSource = clientVM.Clients;
            labelTotalYTDSales.Text = clientVM.Clients.TotalYTDSales.ToString();
            labelTotalCreditHold.Text = clientVM.Clients.CreditHoldCount().ToString();
        }
    }
}