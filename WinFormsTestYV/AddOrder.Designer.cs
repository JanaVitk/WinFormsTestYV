
namespace WinFormsTestYV
{
    partial class AddOrder
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
            this.components = new System.ComponentModel.Container();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dLC_Order = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.gridOrderItems = new DevExpress.XtraGrid.GridControl();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewOrderItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookUpEdit_Products = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TimeTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.ClientIDLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTime = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForClientID = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dLC_Order)).BeginInit();
            this.dLC_Order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpEdit_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientIDLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForClientID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // Total
            // 
            this.Total.Caption = "Сумма";
            this.Total.FieldName = "Total";
            this.Total.Name = "Total";
            this.Total.OptionsEditForm.StartNewRow = true;
            this.Total.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.Total.OptionsEditForm.VisibleIndex = 3;
            this.Total.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "Всего={0:0.##}")});
            this.Total.UnboundDataType = typeof(decimal);
            this.Total.UnboundExpression = "[Count] * [Price]";
            this.Total.Visible = true;
            this.Total.VisibleIndex = 3;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dLC_Order);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(502, 413);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dLC_Order
            // 
            this.dLC_Order.Controls.Add(this.btnOk);
            this.dLC_Order.Controls.Add(this.gridOrderItems);
            this.dLC_Order.Controls.Add(this.DateDateEdit);
            this.dLC_Order.Controls.Add(this.TimeTimeEdit);
            this.dLC_Order.Controls.Add(this.ClientIDLookUpEdit);
            this.dLC_Order.DataSource = this.orderBindingSource;
            this.dLC_Order.Location = new System.Drawing.Point(12, 12);
            this.dLC_Order.Name = "dLC_Order";
            this.dLC_Order.Root = this.layoutControlGroup1;
            this.dLC_Order.Size = new System.Drawing.Size(478, 389);
            this.dLC_Order.TabIndex = 4;
            this.dLC_Order.Text = "dataLayoutControl1";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(372, 355);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 22);
            this.btnOk.StyleController = this.dLC_Order;
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // gridOrderItems
            // 
            this.gridOrderItems.DataSource = this.orderItemBindingSource;
            this.gridOrderItems.Location = new System.Drawing.Point(12, 84);
            this.gridOrderItems.MainView = this.viewOrderItem;
            this.gridOrderItems.Name = "gridOrderItems";
            this.gridOrderItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemLookUpEdit_Products});
            this.gridOrderItems.Size = new System.Drawing.Size(454, 267);
            this.gridOrderItems.TabIndex = 7;
            this.gridOrderItems.UseEmbeddedNavigator = true;
            this.gridOrderItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewOrderItem});
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataSource = typeof(WinFormsTestYV.Models.OrderItem);
            // 
            // viewOrderItem
            // 
            this.viewOrderItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductID,
            this.colCount,
            this.colPrice,
            this.OrderID,
            this.Total});
            this.viewOrderItem.GridControl = this.gridOrderItems;
            this.viewOrderItem.Name = "viewOrderItem";
            this.viewOrderItem.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.viewOrderItem.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.viewOrderItem.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.viewOrderItem.OptionsEditForm.EditFormColumnCount = 2;
            this.viewOrderItem.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.viewOrderItem.OptionsView.ShowFooter = true;
            this.viewOrderItem.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.viewOrderItem_InitNewRow);
            // 
            // colProductID
            // 
            this.colProductID.ColumnEdit = this.ItemLookUpEdit_Products;
            this.colProductID.FieldName = "ProductID";
            this.colProductID.MinWidth = 75;
            this.colProductID.Name = "colProductID";
            this.colProductID.OptionsEditForm.ColumnSpan = 2;
            this.colProductID.OptionsEditForm.UseEditorColRowSpan = false;
            this.colProductID.Visible = true;
            this.colProductID.VisibleIndex = 0;
            // 
            // ItemLookUpEdit_Products
            // 
            this.ItemLookUpEdit_Products.AutoHeight = false;
            this.ItemLookUpEdit_Products.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookUpEdit_Products.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Найменование"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PriceNow", "Цена сейчас")});
            this.ItemLookUpEdit_Products.DataSource = this.productBindingSource;
            this.ItemLookUpEdit_Products.DisplayMember = "Name";
            this.ItemLookUpEdit_Products.KeyMember = "ID";
            this.ItemLookUpEdit_Products.Name = "ItemLookUpEdit_Products";
            this.ItemLookUpEdit_Products.ValueMember = "ID";
            this.ItemLookUpEdit_Products.EditValueChanged += new System.EventHandler(this.ItemLookUpEdit_Products_EditValueChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WinFormsTestYV.Models.Product);
            // 
            // colCount
            // 
            this.colCount.FieldName = "Count";
            this.colCount.Name = "colCount";
            this.colCount.OptionsEditForm.StartNewRow = true;
            this.colCount.OptionsEditForm.VisibleIndex = 1;
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 1;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsEditForm.VisibleIndex = 2;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            // 
            // OrderID
            // 
            this.OrderID.Caption = "gridColumn1";
            this.OrderID.FieldName = "OrderID";
            this.OrderID.Name = "OrderID";
            this.OrderID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrderID", "SUM={0:0.##}")});
            // 
            // DateDateEdit
            // 
            this.DateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderBindingSource, "Date", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DateDateEdit.EditValue = null;
            this.DateDateEdit.Location = new System.Drawing.Point(61, 12);
            this.DateDateEdit.Name = "DateDateEdit";
            this.DateDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.DateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateDateEdit.Properties.DisplayFormat.FormatString = "{0:d}";
            this.DateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateDateEdit.Properties.EditFormat.FormatString = "{0:d}";
            this.DateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateDateEdit.Size = new System.Drawing.Size(405, 20);
            this.DateDateEdit.StyleController = this.dLC_Order;
            this.DateDateEdit.TabIndex = 4;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(WinFormsTestYV.Models.Order);
            // 
            // TimeTimeEdit
            // 
            this.TimeTimeEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderBindingSource, "Time", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TimeTimeEdit.EditValue = new System.DateTime(2022, 9, 25, 0, 0, 0, 0);
            this.TimeTimeEdit.Location = new System.Drawing.Point(61, 36);
            this.TimeTimeEdit.Name = "TimeTimeEdit";
            this.TimeTimeEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TimeTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TimeTimeEdit.Properties.DisplayFormat.FormatString = "{0:t}";
            this.TimeTimeEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TimeTimeEdit.Properties.EditFormat.FormatString = "{0:t}";
            this.TimeTimeEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TimeTimeEdit.Size = new System.Drawing.Size(405, 20);
            this.TimeTimeEdit.StyleController = this.dLC_Order;
            this.TimeTimeEdit.TabIndex = 5;
            // 
            // ClientIDLookUpEdit
            // 
            this.ClientIDLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderBindingSource, "ClientID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ClientIDLookUpEdit.EditValue = ((long)(0));
            this.ClientIDLookUpEdit.Location = new System.Drawing.Point(61, 60);
            this.ClientIDLookUpEdit.Name = "ClientIDLookUpEdit";
            this.ClientIDLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.ClientIDLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ClientIDLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ClientIDLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ClientIDLookUpEdit.Properties.DataSource = this.clientBindingSource;
            this.ClientIDLookUpEdit.Properties.DisplayMember = "Name";
            this.ClientIDLookUpEdit.Properties.NullText = "";
            this.ClientIDLookUpEdit.Properties.ValidateOnEnterKey = true;
            this.ClientIDLookUpEdit.Properties.ValueMember = "ID";
            this.ClientIDLookUpEdit.Size = new System.Drawing.Size(405, 20);
            this.ClientIDLookUpEdit.StyleController = this.dLC_Order;
            this.ClientIDLookUpEdit.TabIndex = 6;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(WinFormsTestYV.Models.Client);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(478, 389);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForDate,
            this.ItemForTime,
            this.ItemForClientID,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(458, 369);
            // 
            // ItemForDate
            // 
            this.ItemForDate.Control = this.DateDateEdit;
            this.ItemForDate.Location = new System.Drawing.Point(0, 0);
            this.ItemForDate.Name = "ItemForDate";
            this.ItemForDate.Size = new System.Drawing.Size(458, 24);
            this.ItemForDate.Text = "Дата";
            this.ItemForDate.TextSize = new System.Drawing.Size(37, 13);
            // 
            // ItemForTime
            // 
            this.ItemForTime.Control = this.TimeTimeEdit;
            this.ItemForTime.Location = new System.Drawing.Point(0, 24);
            this.ItemForTime.Name = "ItemForTime";
            this.ItemForTime.Size = new System.Drawing.Size(458, 24);
            this.ItemForTime.Text = "Время";
            this.ItemForTime.TextSize = new System.Drawing.Size(37, 13);
            // 
            // ItemForClientID
            // 
            this.ItemForClientID.Control = this.ClientIDLookUpEdit;
            this.ItemForClientID.Location = new System.Drawing.Point(0, 48);
            this.ItemForClientID.Name = "ItemForClientID";
            this.ItemForClientID.Size = new System.Drawing.Size(458, 24);
            this.ItemForClientID.Text = "Клиент";
            this.ItemForClientID.TextSize = new System.Drawing.Size(37, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridOrderItems;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(458, 271);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnOk;
            this.layoutControlItem3.Location = new System.Drawing.Point(360, 343);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(98, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 343);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(360, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(502, 413);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dLC_Order;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(482, 393);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 413);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AddOrder";
            this.Text = "Добавить покупку";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dLC_Order)).EndInit();
            this.dLC_Order.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpEdit_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientIDLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForClientID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource orderBindingSource;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraDataLayout.DataLayoutControl dLC_Order;
        private DevExpress.XtraEditors.DateEdit DateDateEdit;
        private DevExpress.XtraEditors.TimeEdit TimeTimeEdit;
        private DevExpress.XtraEditors.LookUpEdit ClientIDLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTime;
        private DevExpress.XtraLayout.LayoutControlItem ItemForClientID;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraGrid.GridControl gridOrderItems;
        private DevExpress.XtraGrid.Views.Grid.GridView viewOrderItem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookUpEdit_Products;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn OrderID;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
    }
}