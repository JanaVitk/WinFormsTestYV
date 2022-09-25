using DevExpress.Mvvm;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
    public partial class ClientsPage : UserControl
    {
        public BindingList<Client> clients { set; get; }
        public event Func<long, bool> UsedClientEvent;
        public ClientsPage()
        {
            InitializeComponent();
        }

        private void GridClients_Load(object sender, EventArgs e)
        {
            GridClients.DataSource = clients;
            editBtns.AddClickEvent += AddButton_Click;
            editBtns.DeleteClickEvent += DeleteButton_Click;
        }

        private void gridView1_EditFormPrepared(object sender, DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventArgs e)
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

        public void AddButton_Click(object sender, EventArgs e)
        {
            AddClient dlg = new AddClient();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                clients.Add(dlg.Client);
                viewClient.RefreshData();
            }
        }

        public void DeleteButton_Click(object sender, EventArgs e)
        {
            viewClient.DeleteRow(viewClient.FocusedRowHandle);
        }

        private void viewClient_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            object id = viewClient.GetRowCellValue(viewClient.FocusedRowHandle, "ID");
            
            if (UsedClientEvent != null && id != null)
                editBtns.SetDeleteButtonEnabled(!UsedClientEvent((long)id));
        }

        private void GridClients_VisibleChanged(object sender, EventArgs e)
        {
            viewClient.RefreshData();
        }
    }
}
