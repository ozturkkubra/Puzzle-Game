using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzle_Oyunu
{
    public partial class Form1 : Form
    {
        int num;
        public Form1()
        {
            InitializeComponent();
        }
        public void CheckButton(Button bttn1, Button bttn2)
        {
            if (bttn2.Text == "")
            {
                bttn2.Text = bttn1.Text;
                bttn1.Text = "";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CheckButton(button1, button2);
            CheckButton(button1, button4);
            checksolve();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CheckButton(button9, button6);
            CheckButton(button9, button8);
            checksolve();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CheckButton(button8, button5);
            CheckButton(button8, button7);
            CheckButton(button8, button9);
            checksolve();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CheckButton(button7, button4);
            CheckButton(button7, button8);
            checksolve();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CheckButton(button6, button3);
            CheckButton(button6, button5);
            CheckButton(button6, button9);
            checksolve();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CheckButton(button5, button2);
            CheckButton(button5, button4);
            CheckButton(button5, button6);
            CheckButton(button5, button8);
            checksolve();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckButton(button4, button1);
            CheckButton(button4, button5);
            CheckButton(button4, button7);
            checksolve();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckButton(button3, button2);
            CheckButton(button3, button6);
            checksolve();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckButton(button2, button1);
            CheckButton(button2, button3);
            CheckButton(button2, button5);
            checksolve();
        }

        
        public void checksolve()
        {
            num = num + 1;
            label1.Text = "Hamle Sayısı: " +num;
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button4.Text == "4" && button5.Text == "5" && button6.Text == "6" && button7.Text == "7" && button8.Text == "8" && button9.Text == "")
            {
                MessageBox.Show("TEBRİKLER... " + num + " Hamlede Oyunu Tamamladınız...");
            }
        }
        public void Shuffle()
        {
            int i, j, Rn;
            int[] a = new int[9];
            Boolean flag = false;
            i = 1;
            do
            {
                Random rnd = new Random();
                Rn = (rnd.Next(0, 8) + 1);
                for (j = 1; j <= i; j++)
                {
                    if (a[j] == Rn)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    a[i] = Rn;
                    i += 1;
                }
            }
            while (i <= 8);
                button1.Text = Convert.ToString(a[1]);
                button2.Text = Convert.ToString(a[2]);
                button3.Text = Convert.ToString(a[3]);
                button4.Text = Convert.ToString(a[4]);
                button5.Text = Convert.ToString(a[5]);
                button6.Text = Convert.ToString(a[6]);
                button7.Text = Convert.ToString(a[7]);
                button8.Text = Convert.ToString(a[8]);
                button9.Text = "";
                num = 0;
            

        }
        private void button10_Click(object sender, EventArgs e)
        {
            Shuffle();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Shuffle();
        }
    }
}
