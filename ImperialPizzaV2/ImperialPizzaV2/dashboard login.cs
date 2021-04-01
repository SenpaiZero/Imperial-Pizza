using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ImperialPizzaV2
{
    public partial class dashboard_login : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public dashboard_login()
        {
            InitializeComponent();
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {

            if (txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from adminLogin where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Dashboard dash = new Dashboard();
                    dash.ShowDialog();
                    cn.Close();
                    this.Close();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nightForm1_Click(object sender, EventArgs e)
        {

        }

        private void nightLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dashboard_Register dReg = new dashboard_Register();
            this.Hide();
            dReg.ShowDialog();
            this.Close();
        }

        private void metroControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_login_Load_1(object sender, EventArgs e)
        {

            this.MaximumSize = this.Size;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        private void lostButton1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
