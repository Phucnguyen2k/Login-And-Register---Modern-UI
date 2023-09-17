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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        // Chuỗi kết nối đến cơ sở dữ liệu Access
        string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb;";

        private void frmRegister_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPasswork.Text))
                MessageBox.Show("Username and Password fields cannot be empty.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtPasswork.Text != txtComPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtPasswork.Text = "";
                txtComPassword.Text = "";
                txtPasswork.Focus();
            }
            else
            {
                conn.Open();
                string checkUserQuery = "SELECT COUNT(*) FROM tbl_users WHERE username = @username";
                cmd = new OleDbCommand(checkUserQuery, conn);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                int userCount = (int)cmd.ExecuteScalar();
                conn.Close();

                if (userCount > 0)
                    MessageBox.Show("Username already exists. Please choose a different username.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    conn.Open();
                    string register = "INSERT INTO tbl_users VALUES ('" + txtUsername.Text + "','" + txtPasswork.Text + "')";
                    cmd = new OleDbCommand(register, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show(
                        "Your Account has been Successlly Created", 
                        "Regiser Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
            }

        }

        private void chkShowPas_CheckedChanged(object sender, EventArgs e)
        {
            //show/hide password
            if (chkShowPas.Checked)
            {
                txtPasswork.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPasswork.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPasswork.Text = "";
            txtComPassword.Text = "";

            txtUsername.Focus();
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

        private void lbBackLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}
