using System;
using System.Windows.Forms;

namespace WinFormsTestYV.UserControls
{
    public partial class EditButtons : UserControl
    {
        public event EventHandler AddClickEvent;
        public event EventHandler DeleteClickEvent;

        public EditButtons()
        {
            InitializeComponent();
            DeleteButton.Enabled = false;
        }

        public void SetDeleteButtonEnabled(bool enabled)
        {
            DeleteButton.Enabled = enabled;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AddClickEvent != null)
            {
                AddClickEvent(this, e);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DeleteClickEvent != null)
            {
                DeleteClickEvent(this, e);
            }
        }
    }

}
