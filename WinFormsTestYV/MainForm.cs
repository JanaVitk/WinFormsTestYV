﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsTestYV.Data;

namespace WinFormsTestYV
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        //FormVM VMs = new FormVM();
        DataSourceDefault dataSource = new DataSourceDefault();
        public MainForm()
        {
            InitializeComponent();
            clients_Page.clients = dataSource.Clients;
            clients_Page.UsedClientEvent += dataSource.UsedCliend;

            products_Page.Products = dataSource.Products;
            products_Page.UsedProductEvent += dataSource.UsedProduct;

            order_Page.DataSource = dataSource;
            statistic_Page.DataSource = dataSource;
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame1.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

      
    }
}