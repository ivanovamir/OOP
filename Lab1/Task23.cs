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
    public partial class Task23 : Form
    {
        int len = 15;
        int i = 0;
        int[] int_lst = new int[15];
        int res_sum = 0;
        public Task23()
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
                    MessageBox.Show("Массив заполнен, для повторного ввода перезапустите форму).");
                }
            }
            catch
            {
                MessageBox.Show("Некорректный ввод.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            res_sum = 0;
            for (int i = 0; i < len; i++)
            {
                res_sum += int_lst[i];
            }
            textBox2.Text = "Сумма = " + res_sum.ToString();
        }
    }
}
