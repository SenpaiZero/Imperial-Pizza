using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImperialPizzaV2
{
    public partial class MenuFood : Form
    {
        public static double totalPrice;
        public static double totalPrice2;

        public static int pizza1, pizza2, pizza3, pizza4, pizza5;
        public static int OrderP1, OrderP2, OrderP3, OrderP4, OrderP5;

        private void MenuFood_Load_1(object sender, EventArgs e)
        {

            this.MaximumSize = this.Size;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
        }

        public MenuFood()
        {
            InitializeComponent();
        }


        private void Water_Click(object sender, EventArgs e)
        {
            MenuDrink drink = new MenuDrink();
            if (Chicago.Checked)
            {
                totalPrice2 = 580;
                pizza1 = 580;
                OrderP1 = 1;
                this.Hide();
                drink.ShowDialog();
            }
            else if (California.Checked)
            {
                totalPrice2 = 260;
                pizza2 = 260;
                OrderP2 = 1;
                this.Hide();
                drink.ShowDialog();
            }
            else if (Detroit.Checked)
            {
                totalPrice2 = 300;
                pizza3 = 300;
                OrderP3 = 1;
                this.Hide();
                drink.ShowDialog();
            }
            else if (Hawaiian.Checked)
            {
                totalPrice2 = 400;
                pizza4 = 400;
                OrderP4 = 1;
                this.Hide();
                drink.ShowDialog();
            }
            else if (stLouis.Checked)
            {
                totalPrice2 = 800;
                pizza5 = 500;
                OrderP5 = 1;
                this.Hide();
                drink.ShowDialog();
            }
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            if(Chicago.Checked)
            {
                totalPrice = 580;
                OrderP1 = 1;
                pizza1 = 580;
                this.Hide();
                pay.ShowDialog();

            }
            else if (California.Checked) 
            {
                totalPrice = 260;
                OrderP2 = 1;
                pizza2 = 260;
                this.Hide();
                pay.ShowDialog();
            } 
            else if (Detroit.Checked) 
            {
                totalPrice = 300;
                pizza3 = 300;
                OrderP3 = 1;
                this.Hide();
                pay.ShowDialog();
            }
            else if (Hawaiian.Checked)
            {
                totalPrice = 400;
                pizza4 = 400;
                OrderP4 = 1;
                this.Hide();
                pay.ShowDialog();
            }
            else if (stLouis.Checked)
            {
                totalPrice = 800;
                pizza5 = 800;
                OrderP5 = 1;
                this.Hide();
                pay.ShowDialog();
            }
        }

        private void nightForm1_Click(object sender, EventArgs e)
        {

        }


        private void nightControlBox1_Click(object sender, EventArgs e)
        {
        }

    }
}
