using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atomiki_ergasia_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int a = 0;
        //εδω ειναι το 1 απο powerpoint 
        private void button1_Click(object sender, EventArgs e)
        {
            if (a == 0) timer1.Enabled = true;
            if (a == 1)
            {
                pictureBox1.ImageLocation = "ORANGE LIGHT.jpg";
                a = 2;
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = "RED LIGHT.jpg";
                a = 4;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a == 0)
            {
                pictureBox1.ImageLocation = "GREEN LIGHT.jpg";
                a = 1;
            }
            if (a == 2)
            {
                a = 3;
            }
            if (a == 4)
            {
                a = 0;
                timer1.Enabled = false;
            }
        }
        //2 powerpoint
        public int c = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            if (!timer2.Enabled)
                timer2.Enabled = true;
            else
                timer2.Enabled = false;
            if (!timer3.Enabled)
                timer3.Enabled = true;
            else
                timer3.Enabled = false;
            if (!timer4.Enabled)
                timer4.Enabled = true;
            else
                timer4.Enabled = false;
            //3 powerpoint
            if (string.IsNullOrEmpty(textBox1.Text))
            {
            }
            else
                timer2.Interval = int.Parse(textBox1.Text) * 1000;
            if (string.IsNullOrEmpty(textBox2.Text))
            {
            }
            else
                timer3.Interval = int.Parse(textBox2.Text) * 1000;
            if (string.IsNullOrEmpty(textBox3.Text))
            {
            }
            else
                timer4.Interval = int.Parse(textBox3.Text) * 1000;
        }
        //4 powerpoint
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (c == 3)
            {
                pictureBox1.ImageLocation = "RED LIGHT.jpg";
                c = 1;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (c == 1)
            {
                pictureBox1.ImageLocation = "GREEN LIGHT.jpg";
                c = 2;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (c == 2)
            {
                pictureBox1.ImageLocation = "ORANGE LIGHT.jpg";
                c = 3;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Green;
            pictureBox3.BackColor = Color.Green;
            pictureBox4.BackColor = Color.Red;
            pictureBox5.BackColor = Color.Red;
            pictureBox6.BackColor = Color.Red;
            pictureBox7.BackColor = Color.Red;
            pictureBox8.BackColor = Color.Red;
            pictureBox9.BackColor = Color.Red;
            pictureBox10.BackColor = Color.Red;
            pictureBox11.BackColor = Color.Red;
        }
        //5 powerpoint
        public int b = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (b == 0)
            {
                timer5.Enabled = true;

            }
            if (b == 1)
            {
                pictureBox12.ImageLocation = "RED LIGHT.jpg";
                pictureBox13.ImageLocation = "GREEN LIGHT.jpg";
                b = 2;
            }

            if (b == 4)
            {
                pictureBox13.ImageLocation = "RED LIGHT.jpg";
                pictureBox12.ImageLocation = "GREEN LIGHT.jpg";
                b = 5;
            }
            if (b == 3)
            {
                pictureBox13.ImageLocation = "ORANGE LIGHT.jpg";
                b = 4;
            }
        }
        //7 powerpoint
        private void timer5_Tick(object sender, EventArgs e)
        {
            if (b == 0)
            {
                pictureBox12.ImageLocation = "ORANGE LIGHT.jpg";
                b = 1;
            }
            if (b == 2)
            {
                b = 3;
            }
            if (b == 5)
            {
                b = 0;
                timer5.Enabled = false;
            } 
        }
        //6power point
        private void button4_Click(object sender, EventArgs e)
        {
            if (b == 0)
            {
                timer5.Enabled = true;
            }
            if (b == 1)
            {
                pictureBox12.ImageLocation = "RED LIGHT.jpg";
                pictureBox13.ImageLocation = "GREEN LIGHT.jpg";
                b = 2;
            }

            if (b == 4)
            {
                pictureBox13.ImageLocation = "RED LIGHT.jpg";
                pictureBox12.ImageLocation = "GREEN LIGHT.jpg";
                b = 5;
            }
            if (b == 3)
            {
                pictureBox13.ImageLocation = "ORANGE LIGHT.jpg";
                b = 4;
            }
        }
        //8 powerpoint
        private void button5_Click(object sender, EventArgs e)
        {
            if (!timer6.Enabled)
                timer6.Enabled = true;
            else
                timer6.Enabled = false;
            if (!timer7.Enabled)
                timer7.Enabled = true;
            else
                timer7.Enabled = false;
            if (!timer8.Enabled)
                timer8.Enabled = true;
            else
                timer8.Enabled = false;
            if (!timer9.Enabled)
                timer9.Enabled = true;
            else
                timer9.Enabled = false;
            if (!timer10.Enabled)
                timer10.Enabled = true;
            else
                timer10.Enabled = false;
            if (!timer11.Enabled)
                timer11.Enabled = true;
            else
                timer11.Enabled = false;
            //9 power point
            if (string.IsNullOrEmpty(textBox4.Text))
            {
            }
            else
                timer6.Interval = int.Parse(textBox4.Text) * 1000;
            if (string.IsNullOrEmpty(textBox5.Text))
            {
            }
            else
                timer7.Interval = int.Parse(textBox5.Text) * 1000;
            if (string.IsNullOrEmpty(textBox6.Text))
            {
            }
            else
                timer8.Interval = int.Parse(textBox6.Text) * 1000;
            if (string.IsNullOrEmpty(textBox7.Text))
            {
            }
            else
                timer9.Interval = int.Parse(textBox7.Text) * 1000;
            if (string.IsNullOrEmpty(textBox8.Text))
            {
            }
            else
                timer10.Interval = int.Parse(textBox8.Text) * 1000;
            if (string.IsNullOrEmpty(textBox9.Text))
            {
            }
            else
                timer11.Interval = int.Parse(textBox9.Text) * 1000;
        }
        public int d = 0;
        private void timer6_Tick(object sender, EventArgs e)
        {
            if (d == 7)
            {
                pictureBox13.ImageLocation = "RED LIGHT.jpg";
                pictureBox12.ImageLocation = "GREEN LIGHT.jpg";
                d = 8;
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (d == 4) d = 5;
            if (d == 3)
            {
                pictureBox13.ImageLocation = "GREEN LIGHT.jpg";
                d = 4;
            } 
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (d == 6) d = 7;
            if (d == 5)
            {
                pictureBox13.ImageLocation = "ORANGE LIGHT.jpg";
                d = 6;
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (d == 2)
            {
                pictureBox12.ImageLocation = "RED LIGHT.jpg";
                pictureBox13.ImageLocation = "GREEN LIGHT.jpg";
                d = 3;
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            if (d == 1)
                d = 2;
            if (d == 0)
            {
                pictureBox12.ImageLocation = "ORANGE LIGHT.jpg";
                d = 1;
            } 
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            if (d == 9) d = 0;
            if (d == 8)
            {
                pictureBox12.ImageLocation = "GREEN LIGHT.jpg";
                d = 9;
            }
        }
    }
}
