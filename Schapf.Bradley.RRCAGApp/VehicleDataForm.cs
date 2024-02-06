using ACE.BIT.ADEV.Forms;
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
using System.Data.OleDb;

namespace Schapf.Bradley.RRCAGApp
{
    public partial class VehicleDataForm1 : VehicleDataForm
    {
        DataSet dataset;
        BindingSource vehicleBindingSource;

        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter adapter;
        OleDbCommandBuilder commandBuilder;
        

        public VehicleDataForm1()
        {
            InitializeComponent();
            

            vehicleBindingSource = new BindingSource();
            Reader();
            BindControls();

            mnuFileClose.Click += MnuFileClose_Click;
            mnuFileSave.Click += MnuFileSave_Click;
            mnuEditDelete.Click += MnuEditDelete_Click;
            dataset.Tables["VehicleStock"].RowChanged += VehicleDataForm1_RowChanged;
            dgvVehicles.CellClick += DgvVehicles_SelectionChanged;
        }

        private void MnuEditDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvVehicles.SelectedRows[0];
            DataRowView rowView = (DataRowView)selectedRow.DataBoundItem;
            DataRow rowToDelete = rowView.Row;

            string message = string.Format("Are you sure you want to permanently Delete stock item {0}?", rowToDelete["StockNumber"].ToString());
            DialogResult result = MessageBox.Show(message, "Delete Stock Item", MessageBoxButtons.YesNo, 
                                                  MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
           
            if (result == DialogResult.Yes)
            {
                
                rowToDelete.Delete();

                adapter.Update(dataset.Tables["VehicleStock"]);

                mnuEditDelete.Enabled = false;
                this.Text = "Vehicle Data";
            }
            
        }

        private void DgvVehicles_SelectionChanged(object sender, EventArgs e)
        {
           if (dgvVehicles.SelectedRows.Count > 0)
           {
                mnuEditDelete.Enabled = true;
           }
           else
           {
                mnuEditDelete.Enabled = false;
           }
            

        }

        private void VehicleDataForm1_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            mnuFileSave.Enabled = true;
            this.Text = "* Vehicle Data";
        }

        private void MnuFileSave_Click(object sender, EventArgs e)
        {
            SaveChanges(false);
        }

        private void MnuFileClose_Click(object sender, EventArgs e)
        {
            if (dataset.HasChanges() == true)
            {
                DialogResult result = MessageBox.Show("Do you wish to save changes?", "Save", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);

                switch (result)
                {
                    case DialogResult.Yes:
                        SaveChanges(true);
                        this.Close();
                        break;
                    case DialogResult.No:
                        this.Close();
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }    
            else
            {
                this.Close();
            }
            
        }

        private void Reader()
        {
            connection = null;
            
            try
            {
                connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; " +
                                                            "Data Source = C:\\Users\\bradl\\OneDrive\\Documents\\BIT Term 2\\Dev 2\\VS projects\\Assignment7BradleySchapf\\RRCAGAppBradleySchapf\\Schapf.Bradley.RRCAGApp\\bin\\Debug\\AMDatabase.mdb");
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to Load Vehicle Data.", "Data Load Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.Close();
            }

            command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM VehicleStock";

            adapter = new OleDbDataAdapter();
            adapter.SelectCommand = command;

            commandBuilder = new OleDbCommandBuilder();
            commandBuilder.ConflictOption = ConflictOption.OverwriteChanges;
            commandBuilder.DataAdapter = adapter;

            dataset = new DataSet();
            

            adapter.Fill(dataset, "VehicleStock");
            
            
        }

        private void BindControls()
        {
            vehicleBindingSource.DataSource = dataset.Tables["VehicleStock"];
            dgvVehicles.DataSource = vehicleBindingSource;
        }

        private void VehicleDataForm1_Load(object sender, EventArgs e)
        {
            mnuFileSave.Enabled = false;
            mnuEditDelete.Enabled = false;
            dgvVehicles.AllowUserToDeleteRows = false;
            dgvVehicles.AllowUserToResizeRows = false;
            dgvVehicles.Columns["ID"].Visible = false;
            dgvVehicles.Columns["SoldBy"].Visible = false;
        }

        private void SaveChanges(bool closingForm)
        {
            if (dataset.HasChanges() == true)
            {
                try
                {
                    adapter.Update(dataset, "VehicleStock");
                    mnuFileSave.Enabled = false;
                    this.Text = "Vehicle Data";
                }
                catch (Exception)
                {
                    if (!closingForm)
                    {
                        MessageBox.Show("An error has occurred while saving the changes to the vehicle data.", "Save Error",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (closingForm) 
                    {
                        MessageBox.Show("An error has occurred while saving. Do you still wish to close?", "Save Error",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                    }
                    
                }

            }
        }

    }
}
