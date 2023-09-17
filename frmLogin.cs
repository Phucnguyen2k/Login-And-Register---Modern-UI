using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Login_And_Register___Modern_UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb"))
            {
                conn.Open();
                string login = "SELECT * FROM tbl_users WHERE username= '" + txtUsername.Text + "' and password='" + txtPasswork.Text + "'";
                cmd = new OleDbCommand(login, conn);
                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    new dashboard().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Invalid Usernam and Password, Pleae Try Again",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    txtUsername.Text = "";
                    txtPasswork.Text = "";
                    txtUsername.Focus();
                }
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPasswork.Text = "";
            txtUsername.Focus();
        }

        private void chkShowPas_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkShowPas.Checked)
                txtPasswork.PasswordChar = '\0';
            else txtPasswork.PasswordChar = '*';
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to exit registration?",
                "Exit Register",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (result == DialogResult.Yes)
                Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
