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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string day = textBox1.Text.Trim().ToLower();

            switch (day)
            {
                case "lunes":
                case "miyerkules":
                case "biyernes":
                    MonWedFri MonWedFri = new MonWedFri();
                    MonWedFri.Show();
                    break;
                case "martes":
                case "huwebes":
                case "sabado":
                    TueThSat TueThSat = new TueThSat();
                    TueThSat.Show();
                    break;
                case "linggo":
                    MessageBox.Show("Soma's Family Restaurant is closed on Sundays", "Soma's Family Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}