using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Login_And_Register___Modern_UI
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            this.Hide();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
        }
        private void exitApp()
        {
            DialogResult result = MessageBox.Show(
                           "Are You Exit?",
                           "Exit",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning
                           );
            if (result == DialogResult.Yes)
                Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            exitApp();
        }

        private void fullSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void MnuEditMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            exitApp();
        }

        private void cmsFormClose_Click(object sender, EventArgs e)
        {
            exitApp();
        }

        private void cmsFormMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
    }
}
