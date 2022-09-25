
namespace WinFormsTestYV.UserControls
{
    partial class ClientsPage
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.editBtns = new WinFormsTestYV.UserControls.EditButtons();
            this.GridClients = new DevExpress.XtraGrid.GridControl();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewClient = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.editBtns);
            this.layoutControl1.Controls.Add(this.GridClients);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(787, 540);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // editBtns
            // 
            this.editBtns.Location = new System.Drawing.Point(12, 12);
            this.editBtns.Name = "editBtns";
            this.editBtns.Size = new System.Drawing.Size(763, 61);
            this.editBtns.TabIndex = 6;
            // 
            // GridClients
            // 
            this.GridClients.DataSource = this.clientBindingSource;
            this.GridClients.Location = new System.Drawing.Point(12, 77);
            this.GridClients.MainView = this.viewClient;
            this.GridClients.Name = "GridClients";
            this.GridClients.Size = new System.Drawing.Size(763, 451);
            this.GridClients.TabIndex = 5;
            this.GridClients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewClient});
            this.GridClients.Load += new System.EventHandler(this.GridClients_Load);
            this.GridClients.VisibleChanged += new System.EventHandler(this.GridClients_VisibleChanged);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(WinFormsTestYV.Models.Client);
            // 
            // viewClient
            // 
            this.viewClient.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colAddress,
            this.colPhone,
            this.colSum});
            this.viewClient.GridControl = this.GridClients;
            this.viewClient.Name = "viewClient";
            this.viewClient.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.viewClient.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.viewClient.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.viewClient.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.viewClient.EditFormPrepared += new DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventHandler(this.gridView1_EditFormPrepared);
            this.viewClient.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.viewClient_SelectionChanged);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colID.Name = "colID";
            this.colID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 56;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsEditForm.ColumnSpan = 3;
            this.colName.OptionsEditForm.StartNewRow = true;
            this.colName.OptionsEditForm.UseEditorColRowSpan = false;
            this.colName.OptionsEditForm.VisibleIndex = 1;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 120;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsEditForm.ColumnSpan = 3;
            this.colAddress.OptionsEditForm.StartNewRow = true;
            this.colAddress.OptionsEditForm.UseEditorColRowSpan = false;
            this.colAddress.OptionsEditForm.VisibleIndex = 2;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            this.colAddress.Width = 397;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.OptionsEditForm.StartNewRow = true;
            this.colPhone.OptionsEditForm.VisibleIndex = 3;
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 3;
            this.colPhone.Width = 100;
            // 
            // colSum
            // 
            this.colSum.FieldName = "Sum";
            this.colSum.Name = "colSum";
            this.colSum.OptionsEditForm.VisibleIndex = 4;
            this.colSum.Visible = true;
            this.colSum.VisibleIndex = 4;
            this.colSum.Width = 65;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(787, 540);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.GridClients;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 65);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(767, 455);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.editBtns;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(767, 65);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(767, 65);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(767, 65);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ClientsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ClientsPage";
            this.Size = new System.Drawing.Size(787, 540);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl GridClients;
        private DevExpress.XtraGrid.Views.Grid.GridView viewClient;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private EditButtons editBtns;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colSum;
        private System.Windows.Forms.BindingSource clientBindingSource;
    }
}
