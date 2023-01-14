using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Figures;

namespace Lab4
{
    public partial class Form1 : Form
    {
        private Stack<Operator> operators = new Stack<Operator>();
        private Stack<Operand> operands = new Stack<Operand>();
        public Form1()
        {
            InitializeComponent();
            Init.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Init.pen = new Pen(Color.Black, 3);
            Init.pictureBox = pictureBox1;
        }

        private void textBoxInputString_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                operators.Clear();
                operands.Clear();
                try
                {
                    string sourceExpression = textBoxInputString.Text.Replace(" ", "");
                    for (int i = 0; i < sourceExpression.Length; i++)
                    {
                        char c = sourceExpression[i];
                        if (IsNotOperation(c))
                        {
                            if (!Char.IsDigit(c))
                            {
                                operands.Push(new Operand(c));
                                while (i < sourceExpression.Length - 1 && IsNotOperation(sourceExpression[i + 1]))
                                {
                                    string temp_str = operands.Pop().value.ToString() + sourceExpression[i + 1].ToString();
                                    operands.Push(new Operand(temp_str));
                                    i++;
                                }
                            }
                            else if (Char.IsDigit(c))
                            {
                                operands.Push(new Operand(c.ToString()));
                                while (i < sourceExpression.Length - 1 && Char.IsDigit(sourceExpression[i + 1])
                                    && IsNotOperation(sourceExpression[i + 1]))
                                {
                                    int temp_num = Convert.ToInt32(operands.Pop().value.ToString()) * 10 +
                                        (int)Char.GetNumericValue(sourceExpression[i + 1]);
                                    operands.Push(new Operand(temp_num.ToString()));
                                    i++;
                                }
                            }
                        }

                        else if ((c == 'C') || (c == 'M') || (c == 'D') || (c == 'I') || (c == 'S') || (c == 'W'))
                        {
                            if (operators.Count == 0)
                            {
                                operators.Push(OperatorContainer.FindOperator(c));
                            }
                        }
                        else if (c == '(')
                        {
                            operators.Push(OperatorContainer.FindOperator(c));
                        }
                        else if (c == ')')
                        {
                            do
                            {
                                if (operators.Peek().symbolOperator == '(')
                                {
                                    operators.Pop();
                                    break;
                                }
                                if (operators.Count == 0)
                                {
                                    break;
                                }
                            }
                            while (operators.Peek().symbolOperator != '(');
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка ввода строки.");
                    comboBox1.Items.Add("Ошибка ввода строки.");
                }
                try
                {
                    SelectingPerformingOperation(operators.Peek());
                }
                catch
                {
                    MessageBox.Show("Ошибка при вводе аргументов.");
                    comboBox1.Items.Add("Ошибка при вводе аргументов.");
                }
            }
        }
        private void SelectingPerformingOperation(Operator op)
        {
            if (op.symbolOperator == 'C')
            {
                if (operands.Count == 4)
                {
                    int r = Convert.ToInt32(operands.Pop().value.ToString());
                    int y = Convert.ToInt32(operands.Pop().value.ToString());
                    int x = Convert.ToInt32(operands.Pop().value.ToString());
                    string name = operands.Pop().value.ToString();
                    if (Init.Coords_check(x, y, r * 2, r * 2))
                    {
                        Circle circle = new Circle(name, x, y, r);
                        ShapeContainer.figureList.Add(circle);
                        circle.Draw();
                        comboBox1.Items.Add($"Нарисован круг {circle.name}.");
                    }
                    else
                    {
                        MessageBox.Show("Фигура не может выйти за границы.");
                        comboBox1.Items.Add("Фигура не может выйти за границы.");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор C принимает 4 аргумента.");
                    comboBox1.Items.Add("Неверное число аргументов для оператора C.");
                }
            }
            else if (op.symbolOperator == 'S')
            {
                if (operands.Count == 4)
                {
                    int w = Convert.ToInt32(operands.Pop().value.ToString());
                    int y = Convert.ToInt32(operands.Pop().value.ToString());
                    int x = Convert.ToInt32(operands.Pop().value.ToString());
                    string name = operands.Pop().value.ToString();
                    if (Init.Coords_check(x, y, w, w))
                    {
                        Square sq = new Square(name, x, y, w);
                        ShapeContainer.figureList.Add(sq);
                        sq.Draw();
                        comboBox1.Items.Add($"Нарисован квадрат {name}.");
                    }
                    else
                    {
                        MessageBox.Show("Фигура не может выйти за границы.");
                        comboBox1.Items.Add("Фигура не может выйти за границы.");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор S принимает 4 аргумента.");
                    comboBox1.Items.Add("Неверное число аргументов для оператора S.");
                }
            }
            else if (op.symbolOperator == 'I')
            {
                if (operands.Count == 2)
                {
                    int r = Convert.ToInt32(operands.Pop().value.ToString());
                    string name = operands.Pop().value.ToString();
                    Circle circle = (Circle)FindByName(name);
                    if (circle != null)
                    {
                        if (Init.Coords_check(circle.x, circle.y, r * 2, r * 2))
                        {
                            circle.w = r * 2;
                            circle.h = r * 2;
                            circle.DeleteF(circle, false);
                            circle.Draw();
                            comboBox1.Items.Add($"Радиус окружности {name} изменен.");
                        }
                        else
                        {
                            MessageBox.Show("Фигура не может выйти за границы.");
                            comboBox1.Items.Add("Фигура не может выйти за границы.");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Окружность с именем {name} не найдена.");
                        comboBox1.Items.Add($"Окружность с именем {name} не найдена.");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор I принимает 2 аргумента.");
                    comboBox1.Items.Add("Неверное число аргументов для оператора I.");
                }
            }
            else if (op.symbolOperator == 'W')
            {
                if (operands.Count == 2)
                {
                    int w = Convert.ToInt32(operands.Pop().value.ToString());
                    string name = operands.Pop().value.ToString();
                    Square sq = (Square)FindByName(name);
                    if (sq != null)
                    {
                        if (Init.Coords_check(sq.x, sq.y, w, w))
                        {
                            sq.w = w;
                            sq.h = w;
                            sq.DeleteF(sq, false);
                            sq.Draw();
                            comboBox1.Items.Add($"Сторона квадрата {name} изменена.");
                        }
                        else
                        {
                            MessageBox.Show("Фигура не может выйти за границы.");
                            comboBox1.Items.Add("Фигура не может выйти за границы.");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Квадрат с именем {name} не найден.");
                        comboBox1.Items.Add($"Квадрат с именем {name} не найден.");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор W принимает 2 аргумента.");
                    comboBox1.Items.Add("Неверное число аргументов для оператора W.");
                }
            }

            else if (op.symbolOperator == 'M')
            {
                if (operands.Count == 3)
                {
                    int y = Convert.ToInt32(operands.Pop().value.ToString());
                    int x = Convert.ToInt32(operands.Pop().value.ToString());
                    string name = operands.Pop().value.ToString();
                    Figure figure = (Figure)FindByName(name);
                    if (figure != null)
                    {
                        if (Init.Coords_check(figure.x + x, figure.y + y, figure.w, figure.h))
                        {
                            figure.MoveTo(x, y);
                            comboBox1.Items.Add($"Фигура {figure.name} успешно перемещена.");
                        }
                        else
                        {
                            MessageBox.Show("Фигура не может выйти за границы.");
                            comboBox1.Items.Add("Фигура не может выйти за границы.");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Фигура с именем {name} не найдена.");
                        comboBox1.Items.Add($"Фигура с именем {name} не найдена.");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор M принимает 3 аргумента.");
                    comboBox1.Items.Add("Неверное число аргументов для оператора M.");
                }
            }
            else if (op.symbolOperator == 'D')
            {
                if (operands.Count == 1)
                {
                    string name = operands.Pop().value.ToString();
                    Figure figure = (Figure)FindByName(name);
                    if (figure != null)
                    {
                        figure.DeleteF(figure, true);
                        comboBox1.Items.Add($"Фигура {figure.name} удалена.");
                    }
                    else
                    {
                        MessageBox.Show($"Фигура с именем {name} не найдена.");
                        comboBox1.Items.Add($"Фигура с именем {name} не найдена.");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор D принимает 1 аргумент.");
                    comboBox1.Items.Add("Неверное число аргументов для оператора D.");
                }
            }
        }
        private bool IsNotOperation(char item)
        {
            if (!( item == 'S' || item == 'W' || item == 'I' || item == 'D' || item == 'M' ||
                item == 'C' || item == ',' || item == '(' || item == ')'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private Figure FindByName(string name)
        {
            foreach (Figure f in ShapeContainer.figureList)
            {
                if (f.name == name)
                {
                    return f;
                }
            }
            return null;
        }
    }
}
