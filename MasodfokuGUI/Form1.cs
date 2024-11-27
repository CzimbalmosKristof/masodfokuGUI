using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasodfokuGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a;
                double b;
                double c;

                try
                {
                    a = double.Parse(textBox1.Text);
                }
                catch (Exception)
                {

                    throw new Exception("Nem számot adott meg az 1. együtthatóként!");
                }
                if (!double.TryParse(textBox2.Text, out b) ) 
                {
                    throw new Exception("Nem  számot adott meg az 2. együtthatóként!");
                }
                if (!double.TryParse(textBox3.Text, out c) ) 
                {
                    throw new Exception("Nem  számot adott meg az 3. együtthatóként!");
                }
                if(a==0)
                {
                    throw new Exception("Az első együttható nulla!");
                }

                double d = b * b - 4 * a * c;
                if (d < 0)
                {
                    throw new Exception("Az egyenletnek nincs valós gyöke (diszkr.=0)!");
                }
                if(d>0)
                {
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    label7.Text = $"x2 ={x2}";
                }
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    label6.Text = $"x1 ={x1}";

            }
            catch (Exception hiba)
            {

                label4.Text =hiba.Message;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label4.Text = "";
            label6.Text = "x1=";
            label7.Text = "x2=";
        }
    }
}
