using System;
using System.Windows.Forms;
using WinFormsTestYV.Data;
using WinFormsTestYV.Models;

namespace WinFormsTestYV.UserControls
{
    public partial class OrderPage : UserControl
    {
        public DataSourceDefault DataSource { set; get; }

        public OrderPage()
        {
            InitializeComponent();
            DataSource = new DataSourceDefault();
        }

        private void OrderPage_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = DataSource.Orders;
            clientBindingSource.DataSource = DataSource.Clients;
            productBindingSource.DataSource = DataSource.Products;
            editBtns.AddClickEvent += AddButton_Click;
            editBtns.DeleteClickEvent += DeleteButton_Click;
        }

        private void gridViewOrder_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            object id = gridViewOrder.GetRowCellValue(gridViewOrder.FocusedRowHandle, "ID");

            if (id != null)
                editBtns.SetDeleteButtonEnabled(true);
        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            AddOrder dlg = new AddOrder(DataSource);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                dlg.Order.setSumForClient += DataSource.SetSumClient;
                foreach (var oi in dlg.Order.OrderItems)
                {
                    oi.setSumForClient += DataSource.SetSumClientFromOrder;
                    oi.getPriceFromProduct += DataSource.GetPrice;
                    oi.getClient += DataSource.GetClient;
                    oi.getOrder += DataSource.GetOrder;
                    oi.getProduct += DataSource.GetProduct;

                    DataSource.OrderItems.Add(oi);
                }

                DataSource.Orders.Add(dlg.Order);
                DataSource.SetSumClient(dlg.Order.ClientID);
                gridViewOrder.RefreshData();
            }
        }

        public void DeleteButton_Click(object sender, EventArgs e)
        {
            Order order = gridViewOrder.GetRow(gridViewOrder.FocusedRowHandle) as Order;

            foreach (var oi in order.OrderItems)
                DataSource.OrderItems.Remove(oi);
            gridViewOrder.DeleteRow(gridViewOrder.FocusedRowHandle);

            DataSource.SetSumClient(order.ClientID);
        }

    }
}
