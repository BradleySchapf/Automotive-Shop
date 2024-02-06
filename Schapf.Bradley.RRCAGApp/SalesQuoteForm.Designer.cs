namespace Schapf.Bradley.RRCAGApp
{
    partial class SalesQuoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVehicleSalePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTradeInValue = new System.Windows.Forms.TextBox();
            this.gpAccessories = new System.Windows.Forms.GroupBox();
            this.cbComputerNavigation = new System.Windows.Forms.CheckBox();
            this.cbLeatherInterior = new System.Windows.Forms.CheckBox();
            this.cbStereoSystem = new System.Windows.Forms.CheckBox();
            this.gbExteriorFinish = new System.Windows.Forms.GroupBox();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.rbPearlized = new System.Windows.Forms.RadioButton();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.gpSummary = new System.Windows.Forms.GroupBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblTradeIn = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSalesTaxOutput = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVehicleSalePrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbFinance = new System.Windows.Forms.GroupBox();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nupAnnualInterestRate = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nupNumOfYears = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCalculateQuote = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gpAccessories.SuspendLayout();
            this.gbExteriorFinish.SuspendLayout();
            this.gpSummary.SuspendLayout();
            this.gbFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAnnualInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumOfYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle\'s Sale Price:";
            // 
            // txtVehicleSalePrice
            // 
            this.txtVehicleSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicleSalePrice.Location = new System.Drawing.Point(121, 27);
            this.txtVehicleSalePrice.Name = "txtVehicleSalePrice";
            this.txtVehicleSalePrice.Size = new System.Drawing.Size(129, 20);
            this.txtVehicleSalePrice.TabIndex = 1;
            this.txtVehicleSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trade-in Value:";
            // 
            // txtTradeInValue
            // 
            this.txtTradeInValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTradeInValue.Location = new System.Drawing.Point(121, 65);
            this.txtTradeInValue.Name = "txtTradeInValue";
            this.txtTradeInValue.Size = new System.Drawing.Size(129, 20);
            this.txtTradeInValue.TabIndex = 2;
            this.txtTradeInValue.Text = "0";
            this.txtTradeInValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gpAccessories
            // 
            this.gpAccessories.Controls.Add(this.cbComputerNavigation);
            this.gpAccessories.Controls.Add(this.cbLeatherInterior);
            this.gpAccessories.Controls.Add(this.cbStereoSystem);
            this.gpAccessories.Location = new System.Drawing.Point(15, 127);
            this.gpAccessories.Name = "gpAccessories";
            this.gpAccessories.Size = new System.Drawing.Size(235, 138);
            this.gpAccessories.TabIndex = 5;
            this.gpAccessories.TabStop = false;
            this.gpAccessories.Text = "Accessories";
            // 
            // cbComputerNavigation
            // 
            this.cbComputerNavigation.AutoSize = true;
            this.cbComputerNavigation.Location = new System.Drawing.Point(24, 106);
            this.cbComputerNavigation.Name = "cbComputerNavigation";
            this.cbComputerNavigation.Size = new System.Drawing.Size(125, 17);
            this.cbComputerNavigation.TabIndex = 5;
            this.cbComputerNavigation.Text = "Computer Navigation";
            this.cbComputerNavigation.UseVisualStyleBackColor = true;
            // 
            // cbLeatherInterior
            // 
            this.cbLeatherInterior.AutoSize = true;
            this.cbLeatherInterior.Location = new System.Drawing.Point(24, 67);
            this.cbLeatherInterior.Name = "cbLeatherInterior";
            this.cbLeatherInterior.Size = new System.Drawing.Size(97, 17);
            this.cbLeatherInterior.TabIndex = 4;
            this.cbLeatherInterior.Text = "Leather Interior";
            this.cbLeatherInterior.UseVisualStyleBackColor = true;
            // 
            // cbStereoSystem
            // 
            this.cbStereoSystem.AutoSize = true;
            this.cbStereoSystem.Location = new System.Drawing.Point(24, 28);
            this.cbStereoSystem.Name = "cbStereoSystem";
            this.cbStereoSystem.Size = new System.Drawing.Size(94, 17);
            this.cbStereoSystem.TabIndex = 3;
            this.cbStereoSystem.Text = "Stereo System";
            this.cbStereoSystem.UseVisualStyleBackColor = true;
            // 
            // gbExteriorFinish
            // 
            this.gbExteriorFinish.Controls.Add(this.rbCustom);
            this.gbExteriorFinish.Controls.Add(this.rbPearlized);
            this.gbExteriorFinish.Controls.Add(this.rbStandard);
            this.gbExteriorFinish.Location = new System.Drawing.Point(15, 298);
            this.gbExteriorFinish.Name = "gbExteriorFinish";
            this.gbExteriorFinish.Size = new System.Drawing.Size(235, 159);
            this.gbExteriorFinish.TabIndex = 6;
            this.gbExteriorFinish.TabStop = false;
            this.gbExteriorFinish.Text = "Exterior Finish";
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(24, 109);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(123, 17);
            this.rbCustom.TabIndex = 2;
            this.rbCustom.Text = "Customized Detailing";
            this.rbCustom.UseVisualStyleBackColor = true;
            // 
            // rbPearlized
            // 
            this.rbPearlized.AutoSize = true;
            this.rbPearlized.Location = new System.Drawing.Point(24, 70);
            this.rbPearlized.Name = "rbPearlized";
            this.rbPearlized.Size = new System.Drawing.Size(68, 17);
            this.rbPearlized.TabIndex = 1;
            this.rbPearlized.Text = "Pearlized";
            this.rbPearlized.UseVisualStyleBackColor = true;
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Checked = true;
            this.rbStandard.Location = new System.Drawing.Point(24, 31);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(68, 17);
            this.rbStandard.TabIndex = 6;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "Standard";
            this.rbStandard.UseVisualStyleBackColor = true;
            // 
            // gpSummary
            // 
            this.gpSummary.Controls.Add(this.lblAmountDue);
            this.gpSummary.Controls.Add(this.lblTradeIn);
            this.gpSummary.Controls.Add(this.lblTotal);
            this.gpSummary.Controls.Add(this.lblSalesTaxOutput);
            this.gpSummary.Controls.Add(this.lblSubTotal);
            this.gpSummary.Controls.Add(this.label8);
            this.gpSummary.Controls.Add(this.label7);
            this.gpSummary.Controls.Add(this.label6);
            this.gpSummary.Controls.Add(this.lblSalesTax);
            this.gpSummary.Controls.Add(this.label5);
            this.gpSummary.Controls.Add(this.lblOptions);
            this.gpSummary.Controls.Add(this.label4);
            this.gpSummary.Controls.Add(this.lblVehicleSalePrice);
            this.gpSummary.Controls.Add(this.label3);
            this.gpSummary.Location = new System.Drawing.Point(280, 21);
            this.gpSummary.Name = "gpSummary";
            this.gpSummary.Size = new System.Drawing.Size(326, 300);
            this.gpSummary.TabIndex = 7;
            this.gpSummary.TabStop = false;
            this.gpSummary.Text = "Summary";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmountDue.Location = new System.Drawing.Point(147, 258);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(144, 23);
            this.lblAmountDue.TabIndex = 13;
            this.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTradeIn
            // 
            this.lblTradeIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTradeIn.Location = new System.Drawing.Point(147, 218);
            this.lblTradeIn.Name = "lblTradeIn";
            this.lblTradeIn.Size = new System.Drawing.Size(144, 23);
            this.lblTradeIn.TabIndex = 12;
            this.lblTradeIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(147, 179);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(144, 23);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalesTaxOutput
            // 
            this.lblSalesTaxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesTaxOutput.Location = new System.Drawing.Point(147, 142);
            this.lblSalesTaxOutput.Name = "lblSalesTaxOutput";
            this.lblSalesTaxOutput.Size = new System.Drawing.Size(144, 23);
            this.lblSalesTaxOutput.TabIndex = 10;
            this.lblSalesTaxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubTotal.Location = new System.Drawing.Point(147, 105);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(144, 23);
            this.lblSubTotal.TabIndex = 9;
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Amount Due:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Trade-in:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total:";
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Location = new System.Drawing.Point(55, 143);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(86, 13);
            this.lblSalesTax.TabIndex = 5;
            this.lblSalesTax.Text = "Sales Tax (13%):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Subtotal:";
            // 
            // lblOptions
            // 
            this.lblOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOptions.Location = new System.Drawing.Point(147, 68);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(144, 23);
            this.lblOptions.TabIndex = 3;
            this.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Options:";
            // 
            // lblVehicleSalePrice
            // 
            this.lblVehicleSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleSalePrice.Location = new System.Drawing.Point(147, 28);
            this.lblVehicleSalePrice.Name = "lblVehicleSalePrice";
            this.lblVehicleSalePrice.Size = new System.Drawing.Size(144, 24);
            this.lblVehicleSalePrice.TabIndex = 1;
            this.lblVehicleSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vehicle\'s Sale Price:";
            // 
            // gbFinance
            // 
            this.gbFinance.Controls.Add(this.lblMonthlyPayment);
            this.gbFinance.Controls.Add(this.label11);
            this.gbFinance.Controls.Add(this.nupAnnualInterestRate);
            this.gbFinance.Controls.Add(this.label10);
            this.gbFinance.Controls.Add(this.nupNumOfYears);
            this.gbFinance.Controls.Add(this.label9);
            this.gbFinance.Location = new System.Drawing.Point(280, 335);
            this.gbFinance.Name = "gbFinance";
            this.gbFinance.Size = new System.Drawing.Size(326, 122);
            this.gbFinance.TabIndex = 8;
            this.gbFinance.TabStop = false;
            this.gbFinance.Text = "Finance";
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(206, 60);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(89, 23);
            this.lblMonthlyPayment.TabIndex = 5;
            this.lblMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(206, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Monthly Payment";
            // 
            // nupAnnualInterestRate
            // 
            this.nupAnnualInterestRate.DecimalPlaces = 2;
            this.nupAnnualInterestRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nupAnnualInterestRate.Location = new System.Drawing.Point(116, 62);
            this.nupAnnualInterestRate.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nupAnnualInterestRate.Name = "nupAnnualInterestRate";
            this.nupAnnualInterestRate.Size = new System.Drawing.Size(60, 20);
            this.nupAnnualInterestRate.TabIndex = 8;
            this.nupAnnualInterestRate.Value = new decimal(new int[] {
            500,
            0,
            0,
            131072});
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(112, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 27);
            this.label10.TabIndex = 2;
            this.label10.Text = "Annual Interest Rate";
            // 
            // nupNumOfYears
            // 
            this.nupNumOfYears.Location = new System.Drawing.Point(28, 62);
            this.nupNumOfYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupNumOfYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupNumOfYears.Name = "nupNumOfYears";
            this.nupNumOfYears.Size = new System.Drawing.Size(60, 20);
            this.nupNumOfYears.TabIndex = 7;
            this.nupNumOfYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "No. of Years";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // btnCalculateQuote
            // 
            this.btnCalculateQuote.Location = new System.Drawing.Point(482, 476);
            this.btnCalculateQuote.Name = "btnCalculateQuote";
            this.btnCalculateQuote.Size = new System.Drawing.Size(124, 31);
            this.btnCalculateQuote.TabIndex = 9;
            this.btnCalculateQuote.Text = "Calculate Quote";
            this.btnCalculateQuote.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(15, 476);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 31);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // SalesQuoteForm
            // 
            this.AcceptButton = this.btnCalculateQuote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 520);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculateQuote);
            this.Controls.Add(this.gbFinance);
            this.Controls.Add(this.gpSummary);
            this.Controls.Add(this.gbExteriorFinish);
            this.Controls.Add(this.gpAccessories);
            this.Controls.Add(this.txtTradeInValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVehicleSalePrice);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SalesQuoteForm";
            this.Text = "Vehicle Sales Quote";
            this.gpAccessories.ResumeLayout(false);
            this.gpAccessories.PerformLayout();
            this.gbExteriorFinish.ResumeLayout(false);
            this.gbExteriorFinish.PerformLayout();
            this.gpSummary.ResumeLayout(false);
            this.gpSummary.PerformLayout();
            this.gbFinance.ResumeLayout(false);
            this.gbFinance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAnnualInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumOfYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVehicleSalePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTradeInValue;
        private System.Windows.Forms.GroupBox gpAccessories;
        private System.Windows.Forms.CheckBox cbComputerNavigation;
        private System.Windows.Forms.CheckBox cbLeatherInterior;
        private System.Windows.Forms.CheckBox cbStereoSystem;
        private System.Windows.Forms.GroupBox gbExteriorFinish;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.RadioButton rbPearlized;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.GroupBox gpSummary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVehicleSalePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblTradeIn;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSalesTaxOutput;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbFinance;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nupAnnualInterestRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nupNumOfYears;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculateQuote;
    }
}