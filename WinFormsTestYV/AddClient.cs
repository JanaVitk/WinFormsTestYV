
using System;
using System.Windows.Forms;
using WinFormsTestYV.Models;

namespace WinFormsTestYV
{
    public partial class AddClient : DevExpress.XtraEditors.XtraForm
    {
        public Client Client { get; private set; }
        public AddClient()
        {
            InitializeComponent();
            Client = new Client();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            dLC_Client.DataSource = Client;
        }
    }
}