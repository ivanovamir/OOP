using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Task73 : Form
    {
        public Task73()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Rational left = Create_Rational_left();
                Rational right = Create_Rational_right();
                Rational res = left + right;
                textBox6.Text = res.a.ToString();
                textBox7.Text = res.b.ToString();
            }
            catch
            {
                MessageBox.Show("Некорректный ввод.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Rational left = Create_Rational_left();
                Rational right = Create_Rational_right();
                Rational res = left - right;
                textBox6.Text = res.a.ToString();
                textBox7.Text = res.b.ToString();
            }
            catch
            {
                MessageBox.Show("Некорректный ввод.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Rational left = Create_Rational_left();
                Rational right = Create_Rational_right();
                Rational res = left * right;
                textBox6.Text = res.a.ToString();
                textBox7.Text = res.b.ToString();
            }
            catch
            {
                MessageBox.Show("Некорректный ввод.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Rational left = Create_Rational_left();
                Rational right = Create_Rational_right();
                if (right.a == 0)
                {
                    MessageBox.Show("Некорректный ввод. Нельзя делить на 0");
                }
                else
                {
                    Rational res = left / right;
                    textBox6.Text = res.a.ToString();
                    textBox7.Text = res.b.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Некорректный ввод.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Rational left = Create_Rational_left();
                Rational right = Create_Rational_right();
                if (left > right)
                {
                    textBox5.Text = ">";
                }
                else if (left < right)
                {
                    textBox5.Text = "<";
                }
                else
                {
                    textBox5.Text = "=";
                }
            }
            catch
            {
                MessageBox.Show("Некорректный ввод.");
            }
        }
        private Rational Create_Rational_left()
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            if (b == 0)
            {
                MessageBox.Show("Знаменатель должен быть отличен от 0.");
                throw new Exception("Длина имени меньше 2 символов");
            }
            return new Rational(a, b);
        }
        private Rational Create_Rational_right()
        {
            int a = int.Parse(textBox3.Text);
            int b = int.Parse(textBox4.Text);
            if (b == 0)
            {
                MessageBox.Show("Знаменатель должен быть отличен от 0.");
                throw new Exception("Длина имени меньше 2 символов");
            }
            return new Rational(a, b);
        }
    }
}
