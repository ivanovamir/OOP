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
    public partial class Task43 : Form
    {
        int len;
        int[] int_lst;
        int i = 0;
        public Task43()
        {
            InitializeComponent();
            label1.Text = $"Введите элемент массива с индексом {i}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int elem = int.Parse(textBox1.Text);
                if (i < len)
                {
                    int_lst[i] = elem;
                    i++;
                    label1.Text = $"Введите элемент массива с индексом {i}";
                }
                else
                {
                    MessageBox.Show("Массив заполнен.");
                }
            }
            catch
            {
                MessageBox.Show("Некорректный ввод.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = int_lst.Max().ToString() + " - максимальный элемент массива";
            }
            catch
            {
                MessageBox.Show("Массив не введен");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox3.Text);
                len = n;
                int_lst = new int[len];
                i = 0;
                label1.Text = $"Введите элемент массива с индексом {i}";
            }
            catch
            {
                MessageBox.Show("Некорректный ввод.");
            }
        }
    }
}
