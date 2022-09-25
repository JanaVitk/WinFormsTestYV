using System;
using System.Windows.Forms;
using WinFormsTestYV.Models;

namespace WinFormsTestYV
{
    public partial class AddProduct : DevExpress.XtraEditors.XtraForm
    {
        public Product Product{get; private set;}
        public AddProduct()
        {
            InitializeComponent();
            Product = new Product();
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            dLC_Product.DataSource = Product;
        }
    }
}