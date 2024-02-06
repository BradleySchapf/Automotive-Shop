using ACE.BIT.ADEV.CarWash;
using ACE.BIT.ADEV.Forms;
using Schapf.Bradley.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schapf.Bradley.RRCAGApp
{
    public partial class CarWashForm1 : CarWashForm
    {

        private BindingList<Package> carWashPackages;
        private BindingSource carWashPackagesSource;

        private List<string> interiorServices = new List<string> { };
        private BindingSource interiorServicesSource;

        private List<string> exteriorServices = new List<string> { };
        private BindingSource exteriorServicesSource;

        private BindingList<CarWashItem> carWashFragrances;
        private BindingSource carWashFragrancesSource;

        public CarWashInvoice carWashInvoice = new CarWashInvoice(0.00M, 0.05M);
        private BindingSource carWashInvoiceSource;

        private Package package1;
        private Package package2;
        private Package package3;
        private Package package4;

        private List<string> interiorServicesPackage1 = new List<string> { "Fragrance - " };
        private List<string> interiorServicesPackage2 = new List<string> { "Fragrance - ", "Shampoo Carpets" };
        private List<string> interiorServicesPackage3 = new List<string> { "Fragrance - ", "Shampoo Carpets", "Shampoo Upholstery"};
        private List<string> interiorServicesPackage4 = new List<string> { "Fragrance - ", "Shampoo Carpets", "Shampoo Upholstery", "Interior Protection Coat" };

        private List<string> exteriorServicesPackage1 = new List<string> { "Hand Wash" };
        private List<string> exteriorServicesPackage2 = new List<string> { "Hand Wash", "Hand Wax" };
        private List<string> exteriorServicesPackage3 = new List<string> { "Hand Wash", "Hand Wax", "Wheel Polish" };
        private List<string> exteriorServicesPackage4 = new List<string> { "Hand Wash", "Hand Wax", "Wheel Polish", "Detail Engine Compartment" };

        private string filepath = "fragrances.txt";

        public CarWashForm1()
        {
            InitializeComponent();
            
            this.carWashPackages = new BindingList<Package>();

            package1 = new Package("Standard", 7.50M, interiorServicesPackage1, exteriorServicesPackage1);
            package2 = new Package("Deluxe", 15.00M, interiorServicesPackage2, exteriorServicesPackage2);
            package3 = new Package("Executive", 35.00M, interiorServicesPackage3, exteriorServicesPackage3);
            package4 = new Package("Luxury", 55.00M, interiorServicesPackage4, exteriorServicesPackage4);

            carWashPackages.Add(package1);
            carWashPackages.Add(package2);
            carWashPackages.Add(package3);
            carWashPackages.Add(package4);

            this.carWashPackagesSource = new BindingSource();
            this.carWashPackagesSource.DataSource = this.carWashPackages;

            this.interiorServicesSource = new BindingSource();
            this.interiorServicesSource.DataSource = this.interiorServices;

            carWashFragrances = new BindingList<CarWashItem>(ReadFromFile(filepath));
            this.carWashFragrancesSource = new BindingSource();
            this.carWashFragrancesSource.DataSource = this.carWashFragrances;

            this.exteriorServicesSource = new BindingSource();
            this.exteriorServicesSource.DataSource = exteriorServices;

            this.carWashInvoiceSource = new BindingSource();
            this.carWashInvoiceSource.DataSource = this.carWashInvoice;

            BindControls();

            this.cboPackage.SelectedIndexChanged += CboPackage_SelectedIndexChanged;
            this.cboFragrance.SelectedIndexChanged += CboPackage_SelectedIndexChanged;
            this.mnuToolsGenerateInvoice.Click += MnuToolsGenerateInvoice_Click;
        }

        private void MnuToolsGenerateInvoice_Click(object sender, EventArgs e)
        {
            CarWashInvoiceForm1 carWashInvoiceForm1 = new CarWashInvoiceForm1(carWashInvoice, this);

            carWashInvoiceForm1.Show();

            cboPackage.SelectedIndex = -1;
            cboFragrance.SelectedIndex = 3;

            lstInterior.Text = string.Empty;
            
        }

        private void CboPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            interiorServices.Clear();
            exteriorServices.Clear();

            if (cboPackage.SelectedIndex != -1 )
            {
                string selectedFragrance = carWashFragrances[cboFragrance.SelectedIndex].Description;

                for (int i = 0; i < carWashPackages[cboPackage.SelectedIndex].InteriorServices.Count; i++)
                {
                    interiorServices.Add(carWashPackages[cboPackage.SelectedIndex].InteriorServices[i]);
                    exteriorServices.Add(carWashPackages[cboPackage.SelectedIndex].ExteriorServices[i]);
                }

                interiorServices[0] = interiorServices[0] + selectedFragrance;

                interiorServicesSource.ResetBindings(false);
                exteriorServicesSource.ResetBindings(false);
                mnuToolsGenerateInvoice.Enabled = true;


                carWashInvoice.PackageCost = carWashPackages[cboPackage.SelectedIndex].Price;
                carWashInvoice.FragranceCost = carWashFragrances[cboFragrance.SelectedIndex].Price;
            }   
        }

        private void BindControls()
        {
            this.cboPackage.DataSource = this.carWashPackagesSource;

            this.cboFragrance.DataSource = this.carWashFragrancesSource;

            this.lstInterior.DataSource = this.interiorServicesSource;

            this.lstExterior.DataSource = this.exteriorServicesSource;

            Binding subtotalBind = new Binding("Text", this.carWashInvoiceSource, "SubTotal");
            this.lblSubtotal.DataBindings.Add(subtotalBind);

            Binding pstBind = new Binding("Text", this.carWashInvoiceSource, "provincialSalesTaxCharged");
            this.lblProvincialSalesTax.DataBindings.Add(pstBind);

            Binding GstBind = new Binding("Text", this.carWashInvoiceSource, "GoodsAndServicesTaxCharged");
            this.lblGoodsAndServicesTax.DataBindings.Add(GstBind);

            Binding totalBind = new Binding("Text", this.carWashInvoiceSource, "Total");
            this.lblTotal.DataBindings.Add(totalBind);

        }

        private void CarWashForm1_Load(object sender, EventArgs e)
        {
            mnuToolsGenerateInvoice.Enabled = false;
            cboPackage.SelectedIndex = -1;
            cboFragrance.SelectedIndex = 3;
            //lblSubtotal.Text = string.Empty;
        }


        private BindingList<CarWashItem> ReadFromFile(string filePath)
        {
            FileStream filestream = null;
            BindingList<CarWashItem> fragrances = new BindingList<CarWashItem>();
            //opens the file with read only access
            try
            {
                filestream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Fragrances data file not found", "Data File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); 
            }

            if (filestream != null)
            {
                StreamReader fileReader = new StreamReader(filestream);

                while (fileReader.Peek() != -1)
                {
                    string record = fileReader.ReadLine();

                    Char[] delimiters = { ',' };

                    String[] fields = record.Split(delimiters);

                    String description = fields[0];
                    String price = fields[1];
                    decimal result = decimal.Parse(price);

                    CarWashItem item = new CarWashItem(description, result);

                    fragrances.Add(item);
                }

                filestream.Close();
            }
            
            return fragrances;
        }
    }
}
