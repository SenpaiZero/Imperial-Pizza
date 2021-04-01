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
    public partial class dashboard_Register : Form
    {
        SqlConnection cn;
        public dashboard_Register()
        {
            InitializeComponent();
        }

        private void nightForm1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {

            if (txtconfirmpassword.Text != string.Empty || txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {
                if (txtpassword.Text == txtconfirmpassword.Text)
                {
                    using (cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"))
                    {
                        cn.Open();
                        SqlCommand cmd = new SqlCommand("select * from adminLogin where username='" + txtusername.Text + "'", cn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dr.Close();
                            cmd = new SqlCommand("insert into adminLogin values(@username,@password)", cn);
                            cmd.Parameters.AddWithValue("username", txtusername.Text);
                            cmd.Parameters.AddWithValue("password", txtpassword.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lostButton2_Click(object sender, EventArgs e)
        {
            dashboard_login dLogin = new dashboard_login();
            this.Hide();
            dLogin.ShowDialog();
            this.Close();
        }

        private void dashboard_Register_Load(object sender, EventArgs e)
        {

            this.MaximumSize = this.Size;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
        }
    }
}
