using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes_2
{
    public partial class Form1 : Form
    {
        private Square S;
        private Rectangle R;
        private Rhomb RH;
        private Triangle T;
        private Circle C;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            S = null;
            R = null;
            RH = null;
            T = null;
            C = null;
            try
            {
                double a = Convert.ToDouble(textBox1.Text);

                S = new Square(a);
                MessageBox.Show("The square is created");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create square");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            S = null;
            R = null;
            RH = null;
            T = null;
            C = null;
            try
            {
                double a = Convert.ToDouble(textBox2.Text);
                double b = Convert.ToDouble(textBox3.Text);

                R = new Rectangle(a, b);
                MessageBox.Show("A rectangle is created");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create rectangle");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            S = null;
            R = null;
            RH = null;
            T = null;
            C = null;
            try
            {
                double a = Convert.ToDouble(textBox4.Text);
                double b = Convert.ToDouble(textBox5.Text);
                double c = Convert.ToDouble(textBox6.Text);

                T = new Triangle(a, b, c);
                MessageBox.Show("A triangle is created");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create triangle");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            S = null;
            R = null;
            RH = null;
            T = null;
            C = null;
            try
            {
                double a = Convert.ToDouble(textBox7.Text);
                double alpha = Convert.ToDouble(textBox9.Text);

                RH = new Rhomb(a, alpha);
                MessageBox.Show("A rhomb is created");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create rhomb");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            S = null;
            R = null;
            RH = null;
            T = null;
            C = null;
            try
            {
                double r = Convert.ToDouble(textBox10.Text);

                C = new Circle(r);
                MessageBox.Show("A circle is created");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create circle");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(S != null)
                MessageBox.Show(S.GetPerimetr().ToString());
            else if(R != null)
                MessageBox.Show(R.GetPerimetr().ToString());
            else if(RH != null)
                MessageBox.Show(RH.GetPerimetr().ToString());
            else if(T != null)
                MessageBox.Show(T.GetPerimetr().ToString());
            else if (C != null)
                MessageBox.Show(C.GetPerimetr().ToString());
            else
                MessageBox.Show("Create a shape first!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (S != null)
                MessageBox.Show(S.GetArea().ToString());
            else if (R != null)
                MessageBox.Show(R.GetArea().ToString());
            else if (RH != null)
                MessageBox.Show(RH.GetArea().ToString());
            else if (T != null)
                MessageBox.Show(T.GetArea().ToString());
            else if (C != null)
                MessageBox.Show(C.GetArea().ToString());
            else
                MessageBox.Show("Create a shape first!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
