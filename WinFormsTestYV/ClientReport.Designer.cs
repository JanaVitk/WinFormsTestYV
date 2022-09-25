
namespace WinFormsTestYV
{
    partial class ClientReport
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo objectConstructorInfo1 = new DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.Client = new DevExpress.XtraReports.Parameters.Parameter();
            this.Start = new DevExpress.XtraReports.Parameters.Parameter();
            this.End = new DevExpress.XtraReports.Parameters.Parameter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Name = "Detail";
            // 
            // Client
            // 
            this.Client.Description = "Клиент";
            this.Client.Name = "Client";
            this.Client.Type = typeof(long);
            this.Client.ValueInfo = "0";
            dynamicListLookUpSettings1.DataMember = null;
            dynamicListLookUpSettings1.DataSource = this.bindingSource1;
            dynamicListLookUpSettings1.DisplayMember = "Name";
            dynamicListLookUpSettings1.FilterString = null;
            dynamicListLookUpSettings1.SortMember = null;
            dynamicListLookUpSettings1.ValueMember = "ID";
            this.Client.ValueSourceSettings = dynamicListLookUpSettings1;
            // 
            // Start
            // 
            this.Start.Description = "От";
            this.Start.Name = "Start";
            this.Start.Type = typeof(System.DateTime);
            this.Start.ValueInfo = "2022-09-25";
            // 
            // End
            // 
            this.End.Description = "До";
            this.End.Name = "End";
            this.End.Type = typeof(System.DateTime);
            this.End.ValueInfo = "2022-09-25";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WinFormsTestYV.Models.Client);
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.Constructor = objectConstructorInfo1;
            this.objectDataSource1.DataMember = "Client";
            this.objectDataSource1.DataSource = typeof(WinFormsTestYV.Models.OrderItem);
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(WinFormsTestYV.Models.OrderItem);
            // 
            // ClientReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.bindingSource1,
            this.objectDataSource1,
            this.bindingSource2});
            this.DataSource = this.bindingSource2;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Client, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Start, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.End, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.Client,
            this.Start,
            this.End});
            this.Version = "22.1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraReports.Parameters.Parameter Client;
        private DevExpress.XtraReports.Parameters.Parameter Start;
        private DevExpress.XtraReports.Parameters.Parameter End;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}
