/*
 * Name: Bradley Schapf
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-03-18
 * Updated: 2023-04-19
 */
  
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schapf.Bradley.RRCAGApp
{
    /// <summary>
    /// The Main Form is the startup Form for the application and is used to open all other Forms in the application.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The constructor method for main form.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            this.mnuFileOpenSalesQuote.Click += MnuFileOpenSalesQuote_Click;
            this.mnuFileOpenCarWash.Click += MnuFileOpenCarWash_Click;
            this.mnuFileExit.Click += MnuFileExit_Click;
            this.mnuDataVehicle.Click += MnuDataVehicle_Click;
            this.mnuHelpAbout.Click += MnuHelpAbout_Click;
        }

        /// <summary>
        /// Handles the click event of the Help - About menu item.
        /// </summary>
        private void MnuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();

            form.ShowDialog();
        }

        /// <summary>
        /// Handles the click event of the Data - Vehicle menu item.
        /// </summary>
        private void MnuDataVehicle_Click(object sender, EventArgs e)
        {
               VehicleDataForm1 form = new VehicleDataForm1();

                form.MdiParent = this;
                //form.Show();
            try
            {
                form.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to Load Vehicle Data.", "Data Load Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                form.Close();
            }
        }

        /// <summary>
        /// Handles the click event of the File - Exit menu item.
        /// </summary>
        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the click event of the File - Open - Car Wash menu item.
        /// </summary>
        private void MnuFileOpenCarWash_Click(object sender, EventArgs e)
        {
            CarWashForm1 form = new CarWashForm1();

            if (!form.IsDisposed)
            {
                form.MdiParent = this;
                form.Show();
            }
            
        }

        /// <summary>
        /// Handles the click event of the File - Open - Sales Quote menu item.
        /// </summary>
        private void MnuFileOpenSalesQuote_Click(object sender, EventArgs e)
        {
            SalesQuoteForm form = new SalesQuoteForm();

            form.MdiParent = this;
            form.Show(); 
        }
    }
}
