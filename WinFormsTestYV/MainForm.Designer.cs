
namespace WinFormsTestYV
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            WinFormsTestYV.Data.DataSourceDefault dataSourceDefault1 = new WinFormsTestYV.Data.DataSourceDefault();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.ClientsTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.ProductsTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem1 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem2 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.clients_Page = new WinFormsTestYV.UserControls.ClientsPage();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.products_Page = new WinFormsTestYV.UserControls.ProductPage();
            this.navigationPage3 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage4 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.order_Page = new WinFormsTestYV.UserControls.OrderPage();
            this.statistic_Page = new WinFormsTestYV.UserControls.StatisticPage();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            this.navigationPage3.SuspendLayout();
            this.navigationPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tileBar.MaxId = 5;
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 110);
            this.tileBar.MinimumSize = new System.Drawing.Size(100, 110);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(29, 11, 29, 11);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileBar.SelectedItem = this.ClientsTileBarItem;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar.ShowGroupText = false;
            this.tileBar.Size = new System.Drawing.Size(1016, 110);
            this.tileBar.TabIndex = 1;
            this.tileBar.Text = "tileBar";
            this.tileBar.WideTileWidth = 150;
            this.tileBar.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // tileBarGroupTables
            // 
            this.tileBarGroupTables.Items.Add(this.ClientsTileBarItem);
            this.tileBarGroupTables.Items.Add(this.ProductsTileBarItem);
            this.tileBarGroupTables.Items.Add(this.tileBarItem1);
            this.tileBarGroupTables.Items.Add(this.tileBarItem2);
            this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "TABLES";
            // 
            // ClientsTileBarItem
            // 
            this.ClientsTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.ClientsTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.ClientsTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            tileItemElement1.Text = "Клиенты";
            this.ClientsTileBarItem.Elements.Add(tileItemElement1);
            this.ClientsTileBarItem.Name = "ClientsTileBarItem";
            // 
            // ProductsTileBarItem
            // 
            this.ProductsTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageOptions.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement2.Text = "Товар";
            this.ProductsTileBarItem.Elements.Add(tileItemElement2);
            this.ProductsTileBarItem.Id = 2;
            this.ProductsTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.ProductsTileBarItem.Name = "ProductsTileBarItem";
            // 
            // tileBarItem1
            // 
            this.tileBarItem1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
            tileItemElement3.Text = "Покупки";
            this.tileBarItem1.Elements.Add(tileItemElement3);
            this.tileBarItem1.Id = 3;
            this.tileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem1.Name = "tileBarItem1";
            // 
            // tileBarItem2
            // 
            this.tileBarItem2.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage2")));
            tileItemElement4.Text = "Статистика";
            this.tileBarItem2.Elements.Add(tileItemElement4);
            this.tileBarItem2.Id = 4;
            this.tileBarItem2.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem2.Name = "tileBarItem2";
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.navigationPage1);
            this.navigationFrame1.Controls.Add(this.navigationPage2);
            this.navigationFrame1.Controls.Add(this.navigationPage3);
            this.navigationFrame1.Controls.Add(this.navigationPage4);
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame1.Location = new System.Drawing.Point(0, 110);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2,
            this.navigationPage3,
            this.navigationPage4});
            this.navigationFrame1.SelectedPage = this.navigationPage1;
            this.navigationFrame1.Size = new System.Drawing.Size(1016, 623);
            this.navigationFrame1.TabIndex = 2;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Controls.Add(this.clients_Page);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(1016, 623);
            // 
            // clients_Page
            // 
            this.clients_Page.clients = null;
            this.clients_Page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clients_Page.Location = new System.Drawing.Point(0, 0);
            this.clients_Page.Name = "clients_Page";
            this.clients_Page.Size = new System.Drawing.Size(1016, 623);
            this.clients_Page.TabIndex = 0;
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "navigationPage2";
            this.navigationPage2.Controls.Add(this.products_Page);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(1016, 623);
            // 
            // products_Page
            // 
            this.products_Page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.products_Page.Location = new System.Drawing.Point(0, 0);
            this.products_Page.Name = "products_Page";
            this.products_Page.Products = null;
            this.products_Page.Size = new System.Drawing.Size(1016, 623);
            this.products_Page.TabIndex = 0;
            // 
            // navigationPage3
            // 
            this.navigationPage3.Caption = "navigationPage3";
            this.navigationPage3.Controls.Add(this.order_Page);
            this.navigationPage3.Name = "navigationPage3";
            this.navigationPage3.Size = new System.Drawing.Size(1016, 623);
            // 
            // navigationPage4
            // 
            this.navigationPage4.Caption = "navigationPage4";
            this.navigationPage4.Controls.Add(this.statistic_Page);
            this.navigationPage4.Name = "navigationPage4";
            this.navigationPage4.Size = new System.Drawing.Size(1016, 623);
            // 
            // order_Page
            // 
            this.order_Page.DataSource = dataSourceDefault1;
            this.order_Page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_Page.Location = new System.Drawing.Point(0, 0);
            this.order_Page.Name = "order_Page";
            this.order_Page.Size = new System.Drawing.Size(1016, 623);
            this.order_Page.TabIndex = 0;
            // 
            // statistic_Page
            // 
            this.statistic_Page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statistic_Page.Location = new System.Drawing.Point(0, 0);
            this.statistic_Page.Name = "statistic_Page";
            this.statistic_Page.Size = new System.Drawing.Size(1016, 623);
            this.statistic_Page.TabIndex = 0;
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 733);
            this.Controls.Add(this.navigationFrame1);
            this.Controls.Add(this.tileBar);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage3.ResumeLayout(false);
            this.navigationPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.TileBarItem ClientsTileBarItem;
        private DevExpress.XtraBars.Navigation.TileBarItem ProductsTileBarItem;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem1;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem2;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage3;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage4;
        private UserControls.ClientsPage clients_Page;
        private UserControls.ProductPage products_Page;
        private UserControls.OrderPage order_Page;
        private UserControls.StatisticPage statistic_Page;
    }
}