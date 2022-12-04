using System;
using System.Windows.Forms;
using Figures;

namespace Lab2
{
    public partial class Form_house : Form
    {
        Form1 form_1;
        public Form_house(Form1 form_1)
        {
            InitializeComponent();
            this.form_1 = form_1;
        }

        private void House_create_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(house_x.Text);
                int y = int.Parse(house_y.Text);
                if (Init.Coords_check(x, y, 100, 180))
                {
                    form_1.house_count += 1;
                    House house = new House(form_1.house_count, x, y, 100, 180);
                    ShapeContainer.AddFigure(house);
                    form_1.bs.ResetBindings(false);
                    house.Draw();
                }
                else
                {
                    MessageBox.Show("Фигура вышла за границы.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода.");
            }
        }
    }
}
