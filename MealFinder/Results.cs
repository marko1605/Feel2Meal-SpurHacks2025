using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealFinder
{
    public partial class Results : Form
    {
        ToolTip toolTip = new ToolTip();
        string[] toolValue = new string[5];
        public Results()
        {
            InitializeComponent();
        }

        public void UpdateLabelsValue(List<List<string>> ls)
        {
            firstRestaurant.Text = ls[0][0];
            rate1.Text = ls[0][1];
            toolValue[0] = ls[0][2];

            secondRestaurant.Text = ls[1][0];
            rate2.Text = ls[1][1];
            toolValue[1] = ls[1][2];

            thirdRestaurant.Text = ls[2][0];
            rate3.Text = ls[2][1];
            toolValue[2] = ls[2][2];

            fourthRestaurant.Text = ls[3][0];
            rate4.Text = ls[3][1];
            toolValue[3] = ls[3][2];

            fifthRestaurant.Text = ls[4][0];
            rate5.Text = ls[4][1];
            toolValue[4] = ls[4][2];

        }

        private void Results_Load(object sender, EventArgs e)
        {

        }

        private void label9_MouseHover(object sender, EventArgs e)
        {

            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.SetToolTip(label9, toolValue[0]);

        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.SetToolTip(label10, toolValue[1]);
        }

        private void label11_MouseHover(object sender, EventArgs e)
        {
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.SetToolTip(label11, toolValue[2]);
        }

        private void label12_MouseHover(object sender, EventArgs e)
        {
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.SetToolTip(label12, toolValue[3]);
        }

        private void label13_MouseHover(object sender, EventArgs e)
        {
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.SetToolTip(label13, toolValue[4]);
        }
    }
}
