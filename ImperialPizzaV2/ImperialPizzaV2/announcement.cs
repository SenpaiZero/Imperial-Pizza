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
    public partial class announcement : Form
    {
        public announcement()
        {
            InitializeComponent();
        }

        private void announcement_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
        }

        private void lostButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
