using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numerical_LOTTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] number = new int[50];
        int[] randomized = new int[6];
        
        private void sira()
        {
            Random rnd = new Random();
            for (int i = 0; i < number.Length; i++)
            {
                int sayi2;
                do
                {
                    sayi2 = rnd.Next(1, 100);
                } while (number.Contains(sayi2) == true);
                number[i] = sayi2;
            }
            Array.Sort(number);
            for (int i = 1; i < 50; i++)
            {
                Controls["label" + (i)].Text = number[i].ToString();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("First of all, enter the numbers in the entry");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < randomized.Length; i++)
            {
                int sayi;
                do
                {
                    sayi = rnd.Next(0, 50);
                } while (randomized.Contains(sayi)==true);
                randomized[i] = sayi;
            }
            int a = 50;
            for (int i = 0; i < randomized.Length; i++)
            {
                Controls["label" + (a)].Text = number[randomized[i]].ToString();
                a++;
            }
            if (textBox1.Text== label50.Text
                && textBox2.Text == label51.Text
                && textBox3.Text == label52.Text 
                && textBox4.Text == label53.Text 
                && textBox5.Text == label54.Text 
                && textBox6.Text == label55.Text)
            {
                MessageBox.Show("You've won the $1 million prize");
            }
            else if ((textBox1.Text == label50.Text  && textBox2.Text == label51.Text  && textBox4.Text == label53.Text)
                || (textBox4.Text == label53.Text&& textBox5.Text == label54.Text&& textBox6.Text == label55.Text))
            {
                MessageBox.Show("You've won the $500,000 million prize");
            }
            else
            {
                MessageBox.Show("Didn't win the award");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi, sayi2, sayi3, sayi4, sayi5, sayi6;
                sayi = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
                sayi3 = Convert.ToInt32(textBox3.Text);
                sayi4 = Convert.ToInt32(textBox4.Text);
                sayi5 = Convert.ToInt32(textBox5.Text);
                sayi6 = Convert.ToInt32(textBox6.Text); 
                sira();
                button1.Visible = true;
            }
            catch
            {
                MessageBox.Show("Fill in all entry numbers");
            }
        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 7; i++)
            {
                Controls["textbox" + i].Text = "";
            }
            int a = 1;
            while (a<56)
            {
                Controls["label" + a].Text = "";
                a++;
            }
            MessageBox.Show("First of all, enter the numbers in the entry");
        }
        private void textbox1_TextChanged(object sender, EventArgs e)
        {
           

        }
        private void label1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
