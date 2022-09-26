using WinFormsTestYV.Data;
using WinFormsTestYV.Models;
using System.Windows.Forms;
using System;
using DevExpress.XtraEditors.Controls;

namespace WinFormsTestYV
{
    public partial class AddOrder : DevExpress.XtraEditors.XtraForm
    {
        DataSourceDefault _DS { set; get; }

        public Order Order { get; private set; }
        public AddOrder(DataSourceDefault _ds)
        {
            _DS = _ds;
            Order = new Order();

            InitializeComponent();
            clientBindingSource.DataSource = _DS.Clients;
            productBindingSource.DataSource = _DS.Products;
            dLC_Order.DataSource = Order;
            gridOrderItems.DataSource = Order.OrderItems;

        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            if (Order.ClientID < 1)
            {
                MessageBox.Show("Выберите клиента", "Ошибка");
                return;
            }
            if (Order.OrderItems.Count == 0)
            {
                MessageBox.Show("Выберите товары", "Ошибка");
                return;
            }
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void viewOrderItem_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            viewOrderItem.SetRowCellValue(e.RowHandle, viewOrderItem.Columns["OrderID"], Order.ID);
        }

        private void ItemLookUpEdit_Products_EditValueChanged(object sender, EventArgs e)
        {
            object id = ((ChangingEventArgs)e).NewValue;
            if (id is long)
            {
                viewOrderItem.SetRowCellValue(
                viewOrderItem.FocusedRowHandle,
                viewOrderItem.Columns["Price"],
                _DS.GetPrice((long)id));
            }
        }
    }
}