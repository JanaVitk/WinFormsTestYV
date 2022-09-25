using DevExpress.XtraReports.UI;
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

namespace WinFormsTestYV.UserControls
{
    public partial class StatisticPage : UserControl
    {
        public DataSourceDefault DataSource { set; get; }
        public StatisticPage()
        {
            InitializeComponent();
            DataSource = new DataSourceDefault();
        }

        private void StatisticPage_Load(object sender, EventArgs e)
        {
            gridControl.DataSource = DataSource.OrderItems;
            gridControl.BestFit();

        }

        private void gridControl_VisibleChanged(object sender, EventArgs e)
        {
            gridControl.RefreshData();
            gridControl.Refresh();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ClientReport report = new ClientReport();
            report.DataSource = DataSource.OrderItems;
            report.Parameters["Client"].Value = 1;
          
            report.Parameters["End"].Value = DateTime.Now;
            ReportPrintTool rpt = new ReportPrintTool(report);
            rpt.ShowPreviewDialog();
        }
    }
}
