using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImperialPizzaV2
{
    public partial class Login : Form
    {

        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        private static bool isStart = false;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            cn.Open();

            if (isStart == false)
            {
                isStart = true;
                announcement ann = new announcement();
                ann.ShowDialog();
            }
        }

        private void nightLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.ShowDialog();
            cn.Close();
            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from LoginTable where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    MenuFood food = new MenuFood();
                    food.ShowDialog();
                    cn.Close();
                    this.Close();
                    return;
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

        private void lostPanel1_Click(object sender, EventArgs e)
        {

        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            dashboard_login dLogin = new dashboard_login();
            this.Hide();
            dLogin.ShowDialog();
            this.Close();
        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {
        }

        private void metroControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void foxLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
