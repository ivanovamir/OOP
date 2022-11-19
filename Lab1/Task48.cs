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
    public partial class Task48 : Form
    {
        public Task48()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float r1 = float.Parse(textBox1.Text);
                float r2 = float.Parse(textBox2.Text);
                float i = float.Parse(textBox3.Text);
                float res_r = r1 + r2;
                float u1 = i * r1;
                float u2 = i * r2;
                textBox6.Text = res_r.ToString();
                textBox5.Text = u1.ToString();
                textBox4.Text = u2.ToString();
            }
            catch
            {
                MessageBox.Show("Некорректный ввод.");
            }
        }
    }
}
