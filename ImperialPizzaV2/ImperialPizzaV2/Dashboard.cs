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
    public partial class Dashboard : Form
    {
        int order1, order2, order3, order4, order5,
            price1, price2, price3, price4, price5;

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"))
            {
                cn.Open();

                SqlDataAdapter dAD2 = new SqlDataAdapter();
                dAD2.UpdateCommand = cn.CreateCommand();
                dAD2.UpdateCommand.CommandText = "UPDATE Drink SET [Order] = 0, Price = 0";
                dAD2.UpdateCommand.ExecuteNonQuery();
                cn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"))
            {
                cn.Open();

                SqlDataAdapter dAD2 = new SqlDataAdapter();
                dAD2.UpdateCommand = cn.CreateCommand();
                dAD2.UpdateCommand.CommandText = "UPDATE Pizza SET [Order] = 0, Price = 0";
                dAD2.UpdateCommand.ExecuteNonQuery();
                cn.Close();
            }
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void ResetLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"))
            {
                cn.Open();

                SqlDataAdapter dAD2 = new SqlDataAdapter();
                dAD2.UpdateCommand = cn.CreateCommand();
                dAD2.UpdateCommand.CommandText = "UPDATE LoginTable SET username = NULL, password = NULL ";
                dAD2.UpdateCommand.ExecuteNonQuery();
                cn.Close();
            }
            
        }

        int dOrder1, dOrder2, dOrder3, dOrder4, dOrder5,
            dPrice1, dPrice2, dPrice3, dPrice4, dPrice5;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            this.MaximumSize = this.Size;
        }

        private void DashboardForm_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"))
            {
                cn.Open();

                //pizza order
                //chicago
                using (SqlCommand cmd1 = new SqlCommand("SELECT * FROM Pizza WHERE Id = 1", cn))
                {
                    cmd1.Connection = cn;

                    using (SqlDataReader dr1 = cmd1.ExecuteReader())
                    {

                        if (dr1.Read())
                        {
                            ChicagoOrders.Text = dr1["Order"].ToString();
                            ChicagoPrice.Text = dr1["Price"].ToString();
                            order1 = Convert.ToInt32(dr1["Order"]);
                            price1 = Convert.ToInt32(dr1["Price"]);
                        }
                    }
                }

                //California
                using (SqlCommand cmd2 = new SqlCommand("SELECT * FROM Pizza WHERE Id = 2", cn))
                {
                    cmd2.Connection = cn;

                    using (SqlDataReader dr2 = cmd2.ExecuteReader())
                    {

                        if (dr2.Read())
                        {
                            CaliforniaOrder.Text = dr2["Order"].ToString();
                            CaliforniaPrice.Text = dr2["Price"].ToString();
                            order2 = Convert.ToInt32(dr2["Order"]);
                            price2 = Convert.ToInt32(dr2["Price"]);
                        }
                    }
                }

                //Detroit
                using (SqlCommand cmd3 = new SqlCommand("SELECT * FROM Pizza WHERE Id = 3", cn))
                {
                    cmd3.Connection = cn;

                    using (SqlDataReader dr3 = cmd3.ExecuteReader())
                    {

                        if (dr3.Read())
                        {
                            DetroitOrder.Text = dr3["Order"].ToString();
                            DetroitPirce.Text = dr3["Price"].ToString();
                            order3 = Convert.ToInt32(dr3["Order"]);
                            price3 = Convert.ToInt32(dr3["Price"]);
                        }
                    }
                }

                //Hawaiian
                using (SqlCommand cmd4 = new SqlCommand("SELECT * FROM Pizza WHERE Id = 4", cn))
                {
                    cmd4.Connection = cn;

                    using (SqlDataReader dr4 = cmd4.ExecuteReader())
                    {

                        if (dr4.Read())
                        {
                            HawaiianOrder.Text = dr4["Order"].ToString();
                            HawaiianPrice.Text = dr4["Price"].ToString();
                            order4 = Convert.ToInt32(dr4["Order"]);
                            price4 = Convert.ToInt32(dr4["Price"]);
                        }
                    }
                }
                //st luois
                using (SqlCommand cmd5 = new SqlCommand("SELECT * FROM Pizza WHERE Id = 5", cn))
                {
                    cmd5.Connection = cn;

                    using (SqlDataReader dr5 = cmd5.ExecuteReader())
                    {

                        if (dr5.Read())
                        {
                            LouisOrder.Text = dr5["Order"].ToString();
                            LouisPrice.Text = dr5["Price"].ToString();
                            order5 = Convert.ToInt32(dr5["Order"]);
                            price5 = Convert.ToInt32(dr5["Price"]);
                        }
                    }
                }

                //Coke
                using (SqlCommand cmd11 = new SqlCommand("SELECT * FROM Drink WHERE Id = 1", cn))
                {


                    using (SqlDataReader dr11 = cmd11.ExecuteReader())
                    {

                        if (dr11.Read())
                        {
                            cokeOrder.Text = dr11["Order"].ToString();
                            cokePrice.Text = dr11["Price"].ToString();
                            dOrder1 = Convert.ToInt32(dr11["Order"]);
                            dPrice1 = Convert.ToInt32(dr11["Price"]);
                        }
                    }
                }
                //Sprite
                using (SqlCommand cmd12 = new SqlCommand("SELECT * FROM Drink WHERE Id = 2", cn))
                {


                    using (SqlDataReader dr12 = cmd12.ExecuteReader())
                    {

                        if (dr12.Read())
                        {
                            spriteOrder.Text = dr12["Order"].ToString();
                            spritePrice.Text = dr12["Price"].ToString();
                            dOrder2 = Convert.ToInt32(dr12["Order"]);
                            dPrice2 = Convert.ToInt32(dr12["Price"]);
                        }
                    }
                }
                //mtndew
                using (SqlCommand cmd13 = new SqlCommand("SELECT * FROM Drink WHERE Id = 3", cn))
                {


                    using (SqlDataReader dr13 = cmd13.ExecuteReader())
                    {

                        if (dr13.Read())
                        {
                            mountainDewOrder.Text = dr13["Order"].ToString();
                            MountainPrice.Text = dr13["Price"].ToString();
                            dOrder3 = Convert.ToInt32(dr13["Order"]);
                            dPrice3 = Convert.ToInt32(dr13["Price"]);
                        }
                    }
                }
                //Order
                PizzaOrder.Text = "" + (order1 + order2 + order3 + order4 + order5);
                PizzaPrice.Text = "" + (price1 + price2 + price3 + price4 + price5);


                //DRINKS
                drinkOrder.Text = "" + (dOrder1 + dOrder2 + dOrder3);
                drinkPrice.Text = "" + (dPrice1 + dPrice2 + dPrice3);

                cn.Close();
            }
        }
    }
}
