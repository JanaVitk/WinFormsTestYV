using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsTestYV.Models;

namespace WinFormsTestYV.UserControls
{
    public partial class ProductPage : UserControl
    {
        public BindingList<Product> Products { set; get; }
        public event Func<long, bool> UsedProductEvent;
        public ProductPage()
        {
            InitializeComponent();
        }
        private void gridProducts_Load(object sender, EventArgs e)
        {
            gridProducts.DataSource = Products;
            editBtns.AddClickEvent += AddButton_Click;
            editBtns.DeleteClickEvent += DeleteButton_Click;
        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            AddProduct dlg = new AddProduct();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Products.Add(dlg.Product);
                viewProducts.RefreshData();
            }
        }

        public void DeleteButton_Click(object sender, EventArgs e)
        {
            viewProducts.DeleteRow(viewProducts.FocusedRowHandle);
        }

        private void viewProducts_EditFormPrepared(object sender, DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventArgs e)
        {
            Control conts = e.Panel.Controls.Find("ButtonPanel", true).FirstOrDefault();

            foreach (Control c in conts.Controls)
            {
                switch (c.AccessibilityObject.Name)
                {
                    case "Update":
                        c.Text = "Обновить";
                        break;
                    case "Cancel":
                        c.Text = "Отмена";
                        break;
                }
            }
        }
        private void viewProducts_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            object id = viewProducts.GetRowCellValue(viewProducts.FocusedRowHandle, "ID");
            var handler = UsedProductEvent;
            if (handler != null && id != null)
                editBtns.SetDeleteButtonEnabled(!handler((long)id));
        }
    }
}
