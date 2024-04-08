using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SomaFamilyRestaurant
{
    public partial class MonWedFri : Form
    {
        private double price = 0;
        private double quantity = 0;
        public MonWedFri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.AppendText("Gotong Batangas, ");
            price += 70;
            quantity++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.AppendText("Carbonara, ");
            price += 120;
            quantity++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.AppendText("Instant Noodles, ");
            price += 40;
            quantity++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double discount = 0;
            if (quantity > 5)
            {
                discount = price * 0.10;
                price -= discount;
            }
            MessageBox.Show($"Total: {price} PHP \nDiscount: {discount} PHP\n\nThank you for ordering!", "Soma's Family Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}