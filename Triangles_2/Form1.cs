using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangles_2
{
    public partial class Form1 : Form
    {
        private RightTriangle R;
        private IsoscelesTriangle I;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            R = null;
            I = null;
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);

                double third = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(c));

                if (c == 90 || (a > b && third == Math.Sqrt(Math.Pow(a, 2) - Math.Pow(b, 2))))
                {
                    R = new RightTriangle(a, b, c);
                    MessageBox.Show("A right triangle is created");
                }
                else if (c == 90 || (a < b && third == Math.Sqrt(Math.Pow(b, 2) - Math.Pow(a, 2))))
                {
                    R = new RightTriangle(a, b, c);
                    MessageBox.Show("A right triangle is created");
                }
                else
                {
                    I = new IsoscelesTriangle(a, b, c);
                    MessageBox.Show("An isosceles triangle is created");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create triangle");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (R != null)
                MessageBox.Show(R.GetPerimetr().ToString());
            else if (I != null)
                MessageBox.Show(I.GetPerimetr().ToString());
            else
                MessageBox.Show("Create a triangle!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (R != null)
                MessageBox.Show(R.GetArea().ToString());
            else if (I != null)
                MessageBox.Show(I.GetArea().ToString());
            else
                MessageBox.Show("Create a triangle!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
