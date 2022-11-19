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
    public partial class Task18 : Form
    {
        public Task18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double z;
                float x = float.Parse(textBox1.Text);
                float y = float.Parse(textBox2.Text);
                if (y < 0)
                {
                    z = Math.Max(Math.Pow(x, 2), Math.Pow(y, 2));
                }
                else
                {
                    z = Math.Min(x, y);
                }
                textBox3.Text = $"Число Z = {z}";
            }
            catch
            {
                MessageBox.Show("Некорректный ввод.");
            }
        }
    }
}
