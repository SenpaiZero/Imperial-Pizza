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
    public partial class MenuDrink : Form
    {
        public static double totalPrice2 = 0;
        public static int drink1, drink2, drink3;
        public static int dOrder1, dOrder2, dOrder3;
        public MenuDrink()
        {
            InitializeComponent();
        }

        private void MenuDrink_Load(object sender, EventArgs e)
        {

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
        }

        private void food_Click(object sender, EventArgs e)
        {
            MenuFood food = new MenuFood();
            this.Hide();
            food.ShowDialog();
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            if (coca.Checked)
            {
                totalPrice2 = 25 + MenuFood.totalPrice2;
                drink1 = 25;
                dOrder1 = 1;
                Payment pay = new Payment();
                this.Hide();
                pay.ShowDialog();
            }
            else if (sprite.Checked)
            {
                totalPrice2 = 25 + MenuFood.totalPrice2;
                drink2 = 25;
                dOrder2 = 1;
                Payment pay = new Payment();
                this.Hide();
                pay.ShowDialog();
            }
            else if(MountainDew.Checked)
            {
                totalPrice2 = 25 + MenuFood.totalPrice2;
                drink3 = 25;
                dOrder3 = 1;
                Payment pay = new Payment();
                this.Hide();
                pay.ShowDialog();
            }
        }

        private void DRINK_Click(object sender, EventArgs e)
        {

        }
    }
}
