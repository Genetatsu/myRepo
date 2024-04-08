using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomaFamilyRestaurant
{
    public partial class TueThSat : Form
    {
        public double price = 0;
        public double quantity = 0;
        public TueThSat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.AppendText("Arroz Caldo, ");
            price += 143;
            quantity++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.AppendText("Spaghetti, ");
            price += 59;
            quantity++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.AppendText("Palabok, ");
            price += 133;
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