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
    public partial class Payment : Form
    {
        public static bool isDone = false;
        private int pizza1, pizza2, pizza3, pizza4, pizza5,
                drink1, drink2, drink3;

        int order1, order2, order3, order4, order5,
            price1, price2, price3, price4, price5;


        private void nightControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void Pay_Click(object sender, EventArgs e)
        {

        }

        int dOrder1, dOrder2, dOrder3,
            dPrice1, dPrice2, dPrice3;

        int OrderP1, OrderP2, OrderP3, OrderP4, OrderP5;

        int orderD1, orderD2, orderD3;

        int totalOrderPizza, totalPricePizza, totalOrderDrink, totalPriceDrink;

        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            pizza1 = MenuFood.pizza1;
            pizza2 = MenuFood.pizza2;
            pizza3 = MenuFood.pizza3;
            pizza4 = MenuFood.pizza4;
            pizza5 = MenuFood.pizza5;

            drink1 = MenuDrink.drink1;
            drink2 = MenuDrink.drink2;
            drink3 = MenuDrink.drink3;

            OrderP1 = MenuFood.OrderP1;
            OrderP2 = MenuFood.OrderP2;
            OrderP3 = MenuFood.OrderP3;
            OrderP4 = MenuFood.OrderP4;
            OrderP5 = MenuFood.OrderP5;

            orderD1 = MenuDrink.dOrder1;
            orderD2 = MenuDrink.dOrder2;
            orderD3 = MenuDrink.dOrder3;

            double payment = 0;
            payment = MenuFood.totalPrice + MenuDrink.totalPrice2;
            nightTextBox1.Text = payment.ToString();
        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {
        }

        private void nightLabel1_Click(object sender, EventArgs e)
        {

        }

        private void nightTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void headerLabel1_Click(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {
        }

        private void multi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void multi_MouseClick(object sender, MouseEventArgs e)
        {
            int clicks = 0;

            if (clicks < 1)
            {
                Address.Text = "";
                clicks = 100000;
            }
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            if (Name.Text != string.Empty && EmailAddress.Text != string.Empty && PhoneNumber.Text != string.Empty && Address.Text != string.Empty)
            {
                MessageBox.Show("Your order has been accepted. Please wait for a text.", "Order successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                backBtn.Text = "Order Again";

                using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"))
                {
                    cn.Open();

                    //pizza order
                    //chicago
                    using (SqlCommand cmd1 = new SqlCommand("SELECT * FROM Pizza WHERE Id = 1", cn))
                    {


                        using (SqlDataReader dr1 = cmd1.ExecuteReader())
                        {

                            if (dr1.Read())
                            {
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
                                dOrder3 = Convert.ToInt32(dr13["Order"]);
                                dPrice3 = Convert.ToInt32(dr13["Price"]);
                            }
                        }
                    }
                    //Order
                    totalOrderPizza = (order1 + order2 + order3 + order4 + order5);
                    totalPricePizza = (price1 + price2 + price3 + price4 + price5);


                    //DRINKS
                    totalOrderDrink = (dOrder1 + dOrder2 + dOrder3);
                    totalPriceDrink = (dPrice1 + dPrice2 + dPrice3);

                    if (OrderP1 == 1)
                    {
                        int orderp11 = order1 + 1;
                        int price11 = price1 + pizza1;

                        SqlDataAdapter dA = new SqlDataAdapter();
                        dA.UpdateCommand = cn.CreateCommand();
                        dA.UpdateCommand.CommandText = "UPDATE Pizza SET[Order] ='" + orderp11 + "', Price ='" + price11 + "' WHERE Id = 1";
                        dA.UpdateCommand.ExecuteNonQuery();

                        //DRINKS
                        if (orderD1 == 1)
                        {
                            int orderd11 = dOrder1 + 1;
                            int priced11 = dPrice1 + drink1;

                            SqlDataAdapter dAD1 = new SqlDataAdapter();
                            dAD1.UpdateCommand = cn.CreateCommand();
                            dAD1.UpdateCommand.CommandText = "UPDATE Drink SET[Order] ='" + orderd11 + "', Price ='" + priced11 + "' WHERE Id = 1";
                            dAD1.UpdateCommand.ExecuteNonQuery();
                        }
                        else if (orderD2 == 1)
                        {
                            int orderd21 = dOrder2 + 1;
                            int priced21 = dPrice2 + drink2;

                            SqlDataAdapter dAD2 = new SqlDataAdapter();
                            dAD2.UpdateCommand = cn.CreateCommand();
                            dAD2.UpdateCommand.CommandText = "UPDATE Drink SET[Order] ='" + orderd21 + "', Price ='" + priced21 + "' WHERE Id = 2";
                            dAD2.UpdateCommand.ExecuteNonQuery();
                        }
                        else if (orderD3 == 1)
                        {
                            int orderd31 = dOrder3 + 1;
                            int priced31 = dPrice3 + drink3;

                            SqlDataAdapter dAD3 = new SqlDataAdapter();
                            dAD3.UpdateCommand = cn.CreateCommand();
                            dAD3.UpdateCommand.CommandText = "UPDATE Drink SET[Order] ='" + orderd31 + "', Price ='" + priced31 + "' WHERE Id = 3";
                            dAD3.UpdateCommand.ExecuteNonQuery();
                        }
                    }
                    else if (OrderP2 == 1)
                    {
                        int orderp12 = order2 + 1;
                        int price12 = price2 + pizza2;

                        SqlDataAdapter dA2 = new SqlDataAdapter();
                        dA2.UpdateCommand = cn.CreateCommand();
                        dA2.UpdateCommand.CommandText = "UPDATE Pizza SET[Order] ='" + orderp12 + "', Price ='" + price12 + "' WHERE Id = 2";
                        dA2.UpdateCommand.ExecuteNonQuery();


                        //DRINKS
                        if (orderD1 == 1)
                        {
                            int orderd11 = dOrder1 + 1;
                            int priced11 = dPrice1 + drink1;

                            SqlDataAdapter dAD1 = new SqlDataAdapter();
                            dAD1.UpdateCommand = cn.CreateCommand();
                            dAD1.UpdateCommand.CommandText = "UPDATE Drink SET[Order] ='" + orderd11 + "', Price ='" + priced11 + "' WHERE Id = 1";
                            dAD1.UpdateCommand.ExecuteNonQuery();
                        }
                        else if (orderD2 == 1)
                        {
                            int orderd21 = dOrder2 + 1;
                            int priced21 = dPrice2 + drink2;

                            SqlDataAdapter dAD2 = new SqlDataAdapter();
                            dAD2.UpdateCommand = cn.CreateCommand();
                            dAD2.UpdateCommand.CommandText = "UPDATE Drink SET[Order] ='" + orderd21 + "', Price ='" + priced21 + "' WHERE Id = 2";
                            dAD2.UpdateCommand.ExecuteNonQuery();
                        }
                        else if (orderD3 == 1)
                        {
                            int orderd31 = dOrder3 + 1;
                            int priced31 = dPrice3 + drink3;

                            SqlDataAdapter dAD3 = new SqlDataAdapter();
                            dAD3.UpdateCommand = cn.CreateCommand();
                            dAD3.UpdateCommand.CommandText = "UPDATE Drink SET[Order] ='" + orderd31 + "', Price ='" + priced31 + "' WHERE Id = 3";
                            dAD3.UpdateCommand.ExecuteNonQuery();
                        }
                    }
                    else if (OrderP3 == 1)
                    {

                        int orderp13 = order3 + 1;
                        int price13 = price3 + pizza3;

                        SqlDataAdapter dA3 = new SqlDataAdapter();
                        dA3.UpdateCommand = cn.CreateCommand();
                        dA3.UpdateCommand.CommandText = "UPDATE Pizza SET[Order] ='" + orderp13 + "', Price ='" + price13 + "' WHERE Id = 3";
                        dA3.UpdateCommand.ExecuteNonQuery();
                        //DRINKS
                        if (orderD1 == 1)
                        {
                            int orderd11 = dOrder1 + 1;
                            int priced11 = dPrice1 + drink1;

                            SqlDataAdapter dAD1 = new SqlDataAdapter();
                            dAD1.UpdateCommand = cn.CreateCommand();
                            dAD1.UpdateCommand.CommandText = "UPDATE Drink SET[Order] ='" + orderd11 + "', Price ='" + priced11 + "' WHERE Id = 1";
                            dAD1.UpdateCommand.ExecuteNonQuery();
                        }
                        else if (orderD2 == 1)
                        {
                            int orderd21 = dOrder2 + 1;
                            int priced21 = dPrice2 + drink2;

                            SqlDataAdapter dAD2 = new SqlDataAdapter();
                            dAD2.UpdateCommand = cn.CreateCommand();
                            dAD2.UpdateCommand.CommandText = "UPDATE Drink SET[Order] ='" + orderd21 + "', Price ='" + priced21 + "' WHERE Id = 2";
                            dAD2.UpdateCommand.ExecuteNonQuery();
                        }
                        else if (orderD3 == 1)
                        {
                            int orderd31 = dOrder3 + 1;
                            int priced31 = dPrice3 + drink3;

                            SqlDataAdapter dAD3 = new SqlDataAdapter();
                            dAD3.UpdateCommand = cn.CreateCommand();
                            dAD3.UpdateCommand.CommandText = "UPDATE Drink SET[Order] ='" + orderd31 + "', Price ='" + priced31 + "' WHERE Id = 3";
                            dAD3.UpdateCommand.ExecuteNonQuery();
                        }


                    }
                    else if (OrderP4 == 1)
                    {

                        int orderp14 = order4 + 1;
                        int price14 = price4 + pizza4;

                        SqlDataAdapter dA4 = new SqlDataAdapter();
                        dA4.UpdateCommand = cn.CreateCommand();
                        dA4.UpdateCommand.CommandText = "UPDATE Pizza SET[Order] ='" + orderp14 + "', Price ='" + price14 + "' WHERE Id = 4";
                        dA4.UpdateCommand.ExecuteNonQuery();
                        //DRINKS
                        if (orderD1 == 1)
                        {
                            int orderd11 = dOrder1 + 1;
                            int priced11 = dPrice1 + drink1;

                            SqlDataAdapter dAD1 = new SqlDataAdapter();
                            dAD1.UpdateCommand = cn.CreateCommand();
                            dAD1.UpdateCommand.CommandText = "UPDATE Drink SET[Order] ='" + orderd11 + "', Price ='" + priced11 + "' WHERE Id = 1";
                            dAD1.UpdateCommand.ExecuteNonQuery();
                        }
                        else if (orderD2 == 1)
                        {
                            int orderd21 = dOrder2 + 1;
                            int priced21 = dPrice2 + drink2;

                            SqlDataAdapter dAD2 = new SqlDataAdapter();
                            dAD2.UpdateCommand = cn.CreateCommand();
                            dAD2.UpdateCommand.CommandText = "UPDATE Drink SET[Order] ='" + orderd21 + "', Price ='" + priced21 + "' WHERE Id = 2";
                            dAD2.UpdateCommand.ExecuteNonQuery();
                        }
                        else if (orderD3 == 1)
                        {
                            int orderd31 = dOrder3 + 1;
                            int priced31 = dPrice3 + drink3;

                            SqlDataAdapter dAD3 = new SqlDataAdapter();
                            dAD3.UpdateCommand = cn.CreateCommand();
                            dAD3.UpdateCommand.CommandText = "UPDATE Drink SET[Order] ='" + orderd31 + "', Price ='" + priced31 + "' WHERE Id = 3";
                            dAD3.UpdateCommand.ExecuteNonQuery();
                        }


                    }
                    else if (OrderP5 == 1)
                    {

                        int orderp15 = order5 + 1;
                        int price15 = price5 + pizza5;

                        SqlDataAdapter dA5 = new SqlDataAdapter();
                        dA5.UpdateCommand = cn.CreateCommand();
                        dA5.UpdateCommand.CommandText = "UPDATE Pizza SET[Order] ='" + orderp15 + "', Price ='" + price15 + "' WHERE Id = 5";
                        dA5.UpdateCommand.ExecuteNonQuery();
                        //DRINKS
                        if (orderD1 == 1)
                        {
                            int orderd11 = dOrder1 + 1;
                            int priced11 = dPrice1 + drink1;

                            SqlDataAdapter dAD1 = new SqlDataAdapter();
                            dAD1.UpdateCommand = cn.CreateCommand();
                            dAD1.UpdateCommand.CommandText = "UPDATE Drink SET[Order] ='" + orderd11 + "', Price ='" + priced11 + "' WHERE Id = 1";
                            dAD1.UpdateCommand.ExecuteNonQuery();
                        }
                        else if (orderD2 == 1)
                        {
                            int orderd21 = dOrder2 + 1;
                            int priced21 = dPrice2 + drink2;

                            SqlDataAdapter dAD2 = new SqlDataAdapter();
                            dAD2.UpdateCommand = cn.CreateCommand();
                            dAD2.UpdateCommand.CommandText = "UPDATE Drink SET[Order] ='" + orderd21 + "', Price ='" + priced21 + "' WHERE Id = 2";
                            dAD2.UpdateCommand.ExecuteNonQuery();
                        }
                        else if (orderD3 == 1)
                        {
                            int orderd31 = dOrder3 + 1;
                            int priced31 = dPrice3 + drink3;

                            SqlDataAdapter dAD3 = new SqlDataAdapter();
                            dAD3.UpdateCommand = cn.CreateCommand();
                            dAD3.UpdateCommand.CommandText = "UPDATE Drink SET[Order] ='" + orderd31 + "', Price ='" + priced31 + "' WHERE Id = 3";
                            dAD3.UpdateCommand.ExecuteNonQuery();
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Please don't leave empty space on the text box.", "Incomplete Details",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lostButton1_Click(object sender, EventArgs e)
        {
            MenuFood food = new MenuFood();
            this.Hide();
            food.ShowDialog();
            this.Close();
            
        }
    }
}
