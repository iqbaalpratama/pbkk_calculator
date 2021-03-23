using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBKK_Calculator
{
    public partial class Form1 : Form
    {
        double angka;
        string operasi;
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void seven_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void eight_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void nine_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void divide_button_Click(object sender, EventArgs e)
        {
            angka = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operasi = "/";
        }

        private void multiple_button_Click(object sender, EventArgs e)
        {
            angka = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operasi = "*";
        }

        private void six_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void five_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void four_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void two_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            angka = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operasi = "-";
        }

        private void equal_button_Click(object sender, EventArgs e)
        {
            double angka_kedua;
            double hasil;

            angka_kedua = Convert.ToDouble(textBox1.Text);

            if (operasi == "+")
            {
                hasil = (angka + angka_kedua);
                textBox1.Text = Convert.ToString(hasil);
                angka = hasil;
            }
            if (operasi == "-")
            {
                hasil = (angka - angka_kedua);
                textBox1.Text = Convert.ToString(hasil);
                angka = hasil;
            }
            if (operasi == "*")
            {
                hasil = (angka * angka_kedua);
                textBox1.Text = Convert.ToString(hasil);
                angka = hasil;
            }
            if (operasi == "/")
            {
                if (angka_kedua == 0)
                {
                    textBox1.Text = "Tidak dapat membagi dengan 0";

                }
                else
                {
                    hasil = (angka / angka_kedua);
                    textBox1.Text = Convert.ToString(hasil);
                    angka = hasil;
                }
            }
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            angka = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operasi = "+";
        }

        private void dot_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void zero_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

    }
}
