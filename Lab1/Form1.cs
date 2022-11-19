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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\task_images\23.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Task23();
            form.Show();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\task_images\48.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Task48();
            form.Show();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\task_images\73.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Task73();
            form.Show();
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\task_images\18.png");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new Task18();
            form.Show();
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\task_images\43.png");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new Task43();
            form.Show();
        }
    }
}
