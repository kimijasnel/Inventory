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
    public partial class Inv : Form
    {
        private Form1 form1;

        public Inv(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        public void AddProduct(string productName, string sku, string status)
        {
            DataGridView gridViewProds = form1.GetGridViewProds();

            if (gridViewProds != null)
            {
                gridViewProds.Rows.Add(sku, productName, status, "", DateTime.Now.ToString("yyyy-MM-dd"));
            }
        }

        public DataGridView GetGridViewProds()
        {
            return GridViewProds;
        }

        private void btnCreateNewProd_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }
    }
}