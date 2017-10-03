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
    public partial class FormGetHostname : Form
    {
        public string Hostname;

        public FormGetHostname(string hostname)
        {
            InitializeComponent();
            tbHostname.Text = hostname.Trim();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Hostname = tbHostname.Text.Trim();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
