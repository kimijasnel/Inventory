using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Form1 : Form
    {
        private Inv invForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaveProd_Click(object sender, EventArgs e)
        {
            if (invForm == null || invForm.IsDisposed)
            {
                invForm = new Inv(this);
                invForm.Show();
            }

            string productName = txtProdName.Text;
            string sku = txtSKU.Text;
            string status = cmbStatus.SelectedItem?.ToString();

            invForm.AddProduct(productName, sku, status);
        }

        public DataGridView GetGridViewProds()
        {
            return invForm.GetGridViewProds();
        }
    }
}