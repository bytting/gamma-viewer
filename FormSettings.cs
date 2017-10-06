using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gamma_viewer
{
    public partial class FormSettings : Form
    {
        private GVSettings settings;

        public FormSettings(GVSettings s)
        {
            InitializeComponent();
            settings = s;
            tbHostname.Text = settings.Hostname.Trim();
            tbUsername.Text = settings.Username.Trim();
            tbPassword.Text = settings.Password;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            settings.Hostname = tbHostname.Text.Trim();
            settings.Username = tbUsername.Text.Trim();
            settings.Password = tbPassword.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
