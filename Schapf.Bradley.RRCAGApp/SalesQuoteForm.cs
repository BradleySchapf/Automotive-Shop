using Schapf.Bradley.Business;
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
    /// The Sales Quote Form is the form to represent the sales quote class.
    /// </summary>
    public partial class SalesQuoteForm : Form
    {
        /// <summary>
        /// The Constructor for the Sales Quote Form class.
        /// </summary>
        public SalesQuoteForm()
        {
            InitializeComponent();

            this.btnCalculateQuote.Click += BtnCalculateQuote_Click;
            this.txtVehicleSalePrice.TextChanged += Txtbox_TextChanged;
            this.txtTradeInValue.TextChanged += Txtbox_TextChanged;
            this.cbStereoSystem.CheckedChanged += OtherControls_StateChanged;
            this.cbLeatherInterior.CheckedChanged += OtherControls_StateChanged;
            this.cbComputerNavigation.CheckedChanged += OtherControls_StateChanged;
            this.rbStandard.CheckedChanged += OtherControls_StateChanged;
            this.rbPearlized.CheckedChanged += OtherControls_StateChanged;
            this.rbCustom.CheckedChanged += OtherControls_StateChanged;
            this.nupNumOfYears.ValueChanged += OtherControls_StateChanged;
            this.nupAnnualInterestRate.ValueChanged += OtherControls_StateChanged;
            this.btnReset.Click += BtnReset_Click;
        }

        /// <summary>
        /// Handles the reset button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to reset the form?", "Reset Form", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            
            switch (result)
            {
                case DialogResult.Yes:
                    Txtbox_TextChanged(this, new EventArgs());
                    break;
                case DialogResult.No:
                    break;
            }
        }
        
        /// <summary>
        /// Handles the events for the checkbox, radiobox, and numericUpDown values changing.
        /// </summary>
        private void OtherControls_StateChanged(object sender, EventArgs e)
        {
            if (lblMonthlyPayment.Text != String.Empty)
            {
                BtnCalculateQuote_Click(sender, e);
            }
        }

        /// <summary>
        /// Handles the textbox text changing event.
        /// </summary>
        private void Txtbox_TextChanged(object sender, EventArgs e)
        {
            lblVehicleSalePrice.Text = String.Empty;
            lblOptions.Text = String.Empty;
            lblSubTotal.Text = String.Empty;
            lblSalesTaxOutput.Text = String.Empty;
            lblTotal.Text = String.Empty;
            lblTradeIn.Text = String.Empty;
            lblAmountDue.Text = String.Empty;
            lblMonthlyPayment.Text = String.Empty;     
        }

        /// <summary>
        /// Handles the Calculate Quote Button event
        /// </summary>
        private void BtnCalculateQuote_Click(object sender, EventArgs e)
        {

            
            decimal vehicleSalePrice = 0, tradeInValue = 0;
            Accessories accessoriesChosen = Accessories.None;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None;
            bool hasError = false;

            this.errorProvider.SetError(txtVehicleSalePrice, String.Empty);
            this.errorProvider.SetError(txtTradeInValue, String.Empty);
            

            decimal[] decimals = { vehicleSalePrice, tradeInValue };
            TextBox[] txtboxs = { this.txtVehicleSalePrice, this.txtTradeInValue };
            String[] strings = { "Vehicle Sale Price", "Trade-in Value" };

            for (int x = 0; x < decimals.Length; x++)
            {  
                //try catch for string errors
                try
                {
                    decimals[x] = decimal.Parse(txtboxs[x].Text);
                }
                catch (Exception)
                {
                    if (txtboxs[x].Text == string.Empty)
                    {
                        errorProvider.SetError(txtboxs[x], String.Format("{0} is a required field.", strings[x]));
                        hasError = true;
                    }
                    if (txtboxs[x].Text is string )
                    {
                        errorProvider.SetError(txtboxs[x], String.Format("{0} cannot contain letters or special characters.", strings[x]));
                        hasError = true;
                    }
                    //check for numerical errors
                    if (decimals[x] <= 0)
                    {
                        errorProvider.SetError(txtboxs[x], String.Format("{0} cannot be less than or equal to 0.", strings[x]));
                        hasError = true;
                    }
                }


            }

            //check to see if trade-in value is less than vehicle sale price
            if (decimals[1] > decimals[0])
            {
                errorProvider.SetError(txtTradeInValue, "Trade-in value cannot exceed the vehicle sale price.");
                hasError = true;
            }

            //check the Accessories
            if (cbStereoSystem.Checked == true && cbLeatherInterior.Checked == true && cbComputerNavigation.Checked == true)
            {
                accessoriesChosen = Accessories.All;
            }
            else if (cbStereoSystem.Checked == true && cbLeatherInterior.Checked == true)
            {
                accessoriesChosen = Accessories.StereoAndLeather;
            }
            else if (cbStereoSystem.Checked == true && cbComputerNavigation.Checked == true)
            {
                accessoriesChosen = Accessories.StereoAndNavigation;
            }
            else if (cbLeatherInterior.Checked == true && cbComputerNavigation.Checked == true)
            {
                accessoriesChosen = Accessories.LeatherAndNavigation;
            }
            else if (cbStereoSystem.Checked == true)
            {
                accessoriesChosen = Accessories.StereoSystem;
            }
            else if (cbLeatherInterior.Checked == true)
            {
                accessoriesChosen = Accessories.LeatherInterior;
            }
            else if (cbComputerNavigation.Checked == true)
            {
                accessoriesChosen = Accessories.ComputerNavigation;
            }
            else
            {
                accessoriesChosen = Accessories.None;
            }

            //check the exterior finish
            if (rbStandard.Checked == true)
            {
                exteriorFinishChosen = ExteriorFinish.Standard;
            }
            if (rbPearlized.Checked == true)
            {
                exteriorFinishChosen = ExteriorFinish.Pearlized;
            }
            if (rbCustom.Checked == true)
            {
                exteriorFinishChosen = ExteriorFinish.Custom;
            }

            if (hasError == false)
            {
                SalesQuote salesQuote1 = new SalesQuote(decimals[0], decimals[1], 0.13M, accessoriesChosen, exteriorFinishChosen);
                decimal monthlyPayment = Financial.GetPayment((decimal.Parse(nupAnnualInterestRate.Text) / 100), (int.Parse(nupNumOfYears.Text) * 12), salesQuote1.AmountDue);

                this.lblVehicleSalePrice.Text = "$" + salesQuote1.VehicleSalePrice.ToString();
                this.lblOptions.Text = salesQuote1.TotalOptions.ToString();
                this.lblSubTotal.Text = "$" + salesQuote1.SubTotal.ToString();
                this.lblSalesTaxOutput.Text = salesQuote1.SalesTax.ToString();
                this.lblTotal.Text = "$" + salesQuote1.Total.ToString();
                this.lblTradeIn.Text = "-" + salesQuote1.TradeInAmount.ToString();
                this.lblAmountDue.Text = "$" + salesQuote1.AmountDue.ToString();
                this.lblMonthlyPayment.Text = "$" + monthlyPayment.ToString();    
            }
        }
    }
}
