
namespace WinFormsTestYV.UserControls
{
    partial class OrderPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridViewProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditProduct = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColClientID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_Client = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.editBtns = new WinFormsTestYV.UserControls.EditButtons();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewProduct
            // 
            this.gridViewProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduct,
            this.collCount,
            this.colPrice,
            this.Sum});
            this.gridViewProduct.GridControl = this.gridControl1;
            this.gridViewProduct.Name = "gridViewProduct";
            this.gridViewProduct.OptionsView.ShowFooter = true;
            // 
            // colProduct
            // 
            this.colProduct.Caption = "Продукты";
            this.colProduct.ColumnEdit = this.repositoryItemLookUpEditProduct;
            this.colProduct.FieldName = "ProductID";
            this.colProduct.Name = "colProduct";
            this.colProduct.Visible = true;
            this.colProduct.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEditProduct
            // 
            this.repositoryItemLookUpEditProduct.AutoHeight = false;
            this.repositoryItemLookUpEditProduct.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditProduct.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Найменование", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PriceNow", "Цена")});
            this.repositoryItemLookUpEditProduct.DataSource = this.productBindingSource;
            this.repositoryItemLookUpEditProduct.DisplayMember = "Name";
            this.repositoryItemLookUpEditProduct.KeyMember = "ID";
            this.repositoryItemLookUpEditProduct.Name = "repositoryItemLookUpEditProduct";
            this.repositoryItemLookUpEditProduct.ValueMember = "ID";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WinFormsTestYV.Models.Product);
            // 
            // collCount
            // 
            this.collCount.Caption = "Количество";
            this.collCount.FieldName = "Count";
            this.collCount.Name = "collCount";
            this.collCount.Visible = true;
            this.collCount.VisibleIndex = 1;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Цена";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            // 
            // Sum
            // 
            this.Sum.Caption = "Сумма";
            this.Sum.FieldName = "Sum";
            this.Sum.Name = "Sum";
            this.Sum.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Sum", "Сумма={0:0.##}")});
            this.Sum.UnboundDataType = typeof(decimal);
            this.Sum.UnboundExpression = "[Count] * [Price]";
            this.Sum.Visible = true;
            this.Sum.VisibleIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.orderBindingSource;
            gridLevelNode1.LevelTemplate = this.gridViewProduct;
            gridLevelNode1.RelationName = "OrderItems";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(12, 75);
            this.gridControl1.MainView = this.gridViewOrder;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit_Client,
            this.repositoryItemLookUpEditProduct});
            this.gridControl1.Size = new System.Drawing.Size(641, 369);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrder,
            this.gridViewProduct});
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(WinFormsTestYV.Models.Order);
            // 
            // gridViewOrder
            // 
            this.gridViewOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colTime,
            this.ColClientID});
            this.gridViewOrder.GridControl = this.gridControl1;
            this.gridViewOrder.Name = "gridViewOrder";
            this.gridViewOrder.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewOrder_SelectionChanged);
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            // 
            // colTime
            // 
            this.colTime.FieldName = "Time";
            this.colTime.Name = "colTime";
            this.colTime.Visible = true;
            this.colTime.VisibleIndex = 1;
            // 
            // ColClientID
            // 
            this.ColClientID.Caption = "Клиент";
            this.ColClientID.ColumnEdit = this.repositoryItemLookUpEdit_Client;
            this.ColClientID.FieldName = "ClientID";
            this.ColClientID.Name = "ColClientID";
            this.ColClientID.Visible = true;
            this.ColClientID.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEdit_Client
            // 
            this.repositoryItemLookUpEdit_Client.AutoHeight = false;
            this.repositoryItemLookUpEdit_Client.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_Client.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Имя"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "Адрес")});
            this.repositoryItemLookUpEdit_Client.DataSource = this.clientBindingSource;
            this.repositoryItemLookUpEdit_Client.DisplayMember = "Name";
            this.repositoryItemLookUpEdit_Client.KeyMember = "ID";
            this.repositoryItemLookUpEdit_Client.Name = "repositoryItemLookUpEdit_Client";
            this.repositoryItemLookUpEdit_Client.ValueMember = "ID";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(WinFormsTestYV.Models.Client);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.editBtns);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(665, 456);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // editBtns
            // 
            this.editBtns.Location = new System.Drawing.Point(12, 12);
            this.editBtns.Name = "editBtns";
            this.editBtns.Size = new System.Drawing.Size(641, 59);
            this.editBtns.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(665, 456);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 63);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(645, 373);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.editBtns;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(0, 63);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(209, 63);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(645, 63);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "OrderPage";
            this.Size = new System.Drawing.Size(665, 456);
            this.Load += new System.EventHandler(this.OrderPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit repositoryItemTreeListLookUpEdit1;
        private DevExpress.XtraTreeList.TreeList repositoryItemTreeListLookUpEdit1TreeList;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Client;
        private DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox repositoryItemResourcesComboBox1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProduct;
        private DevExpress.XtraGrid.Columns.GridColumn ColClientID;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct;
        private DevExpress.XtraGrid.Columns.GridColumn collCount;
        private EditButtons editBtns;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn Sum;
    }
}
