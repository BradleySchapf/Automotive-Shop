using ACE.BIT.ADEV.Forms;
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
    public partial class CarWashInvoiceForm1 : CarWashInvoiceForm
    {
        private CarWashInvoice carWashInvoice;
        private BindingSource carWashInvoiceSource;

        private CarWashForm1 carWashForm1;

        public CarWashInvoiceForm1(CarWashInvoice carWashInvoice, CarWashForm1 carWashForm1)
        {
            InitializeComponent();

            carWashInvoiceSource = new BindingSource();
            carWashInvoiceSource.DataSource = carWashInvoice;
            this.carWashInvoice = carWashInvoice;
            this.carWashForm1 = carWashForm1;

            BindControls();
        }

        private void BindControls()
        {
            Binding packageCostBind = new Binding("Text", this.carWashInvoiceSource, "PackageCost");
            lblPackagePrice.DataBindings.Add(packageCostBind);

            Binding fragranceCostBind = new Binding("Text", this.carWashInvoiceSource, "FragranceCost");
            lblFragrancePrice.DataBindings.Add(fragranceCostBind);

            Binding subTotalBind = new Binding("Text", this.carWashInvoiceSource, "SubTotal");
            lblSubtotal.DataBindings.Add(subTotalBind);

            Binding pstBind = new Binding("Text", this.carWashInvoiceSource, "ProvincialSalesTaxCharged");
            lblProvincialSalesTax.DataBindings.Add(pstBind);

            Binding gstBind = new Binding("Text", this.carWashInvoiceSource, "GoodsAndServicesTaxCharged");
            lblGoodsAndServicesTax.DataBindings.Add(gstBind);

            Binding totalBind = new Binding("Text", this.carWashInvoiceSource, "Total");
            lblTotal.DataBindings.Add(totalBind);
        }

    }
}
