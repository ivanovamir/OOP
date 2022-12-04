namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.figuresListBox = new System.Windows.Forms.ListBox();
            this.btn_move = new System.Windows.Forms.Button();
            this.btn_change_rect = new System.Windows.Forms.Button();
            this.btn_change_sq = new System.Windows.Forms.Button();
            this.btn_change_el = new System.Windows.Forms.Button();
            this.btn_change_circle = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_square = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.move_to_y = new System.Windows.Forms.TextBox();
            this.move_to_x = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_house = new System.Windows.Forms.Button();
            this.btn_triangle = new System.Windows.Forms.Button();
            this.btn_poly = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 418);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(0, 152);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(143, 33);
            this.btn_delete.TabIndex = 33;
            this.btn_delete.Text = "удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // figuresListBox
            // 
            this.figuresListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figuresListBox.FormattingEnabled = true;
            this.figuresListBox.ItemHeight = 18;
            this.figuresListBox.Location = new System.Drawing.Point(610, 8);
            this.figuresListBox.Name = "figuresListBox";
            this.figuresListBox.Size = new System.Drawing.Size(142, 418);
            this.figuresListBox.TabIndex = 34;
            // 
            // btn_move
            // 
            this.btn_move.Location = new System.Drawing.Point(0, 113);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(143, 33);
            this.btn_move.TabIndex = 35;
            this.btn_move.Text = "переместить";
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // btn_change_rect
            // 
            this.btn_change_rect.Location = new System.Drawing.Point(0, 209);
            this.btn_change_rect.Name = "btn_change_rect";
            this.btn_change_rect.Size = new System.Drawing.Size(143, 50);
            this.btn_change_rect.TabIndex = 40;
            this.btn_change_rect.Text = "изменить прямоугольник";
            this.btn_change_rect.UseVisualStyleBackColor = true;
            this.btn_change_rect.Click += new System.EventHandler(this.btn_change_rect_Click);
            // 
            // btn_change_sq
            // 
            this.btn_change_sq.Location = new System.Drawing.Point(0, 265);
            this.btn_change_sq.Name = "btn_change_sq";
            this.btn_change_sq.Size = new System.Drawing.Size(143, 47);
            this.btn_change_sq.TabIndex = 41;
            this.btn_change_sq.Text = "изменить квадрат";
            this.btn_change_sq.UseVisualStyleBackColor = true;
            this.btn_change_sq.Click += new System.EventHandler(this.btn_change_sq_Click);
            // 
            // btn_change_el
            // 
            this.btn_change_el.Location = new System.Drawing.Point(0, 318);
            this.btn_change_el.Name = "btn_change_el";
            this.btn_change_el.Size = new System.Drawing.Size(143, 45);
            this.btn_change_el.TabIndex = 42;
            this.btn_change_el.Text = "изменить эллипс";
            this.btn_change_el.UseVisualStyleBackColor = true;
            this.btn_change_el.Click += new System.EventHandler(this.btn_change_el_Click);
            // 
            // btn_change_circle
            // 
            this.btn_change_circle.Location = new System.Drawing.Point(0, 369);
            this.btn_change_circle.Name = "btn_change_circle";
            this.btn_change_circle.Size = new System.Drawing.Size(143, 42);
            this.btn_change_circle.TabIndex = 43;
            this.btn_change_circle.Text = "изменить окружность";
            this.btn_change_circle.UseVisualStyleBackColor = true;
            this.btn_change_circle.Click += new System.EventHandler(this.btn_change_circle_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.Location = new System.Drawing.Point(7, 21);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(122, 42);
            this.btn_rect.TabIndex = 44;
            this.btn_rect.Text = "Прямоугольник";
            this.btn_rect.UseVisualStyleBackColor = true;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_square
            // 
            this.btn_square.Location = new System.Drawing.Point(135, 21);
            this.btn_square.Name = "btn_square";
            this.btn_square.Size = new System.Drawing.Size(106, 42);
            this.btn_square.TabIndex = 45;
            this.btn_square.Text = "Квадрат";
            this.btn_square.UseVisualStyleBackColor = true;
            this.btn_square.Click += new System.EventHandler(this.btn_sq_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.Location = new System.Drawing.Point(247, 21);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(118, 42);
            this.btn_ellipse.TabIndex = 46;
            this.btn_ellipse.Text = "Эллипс";
            this.btn_ellipse.UseVisualStyleBackColor = true;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_circle
            // 
            this.btn_circle.Location = new System.Drawing.Point(371, 21);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(123, 42);
            this.btn_circle.TabIndex = 47;
            this.btn_circle.Text = "Окружность";
            this.btn_circle.UseVisualStyleBackColor = true;
            this.btn_circle.Click += new System.EventHandler(this.btn_circle_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(6, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 25);
            this.label16.TabIndex = 52;
            this.label16.Text = "Y:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(6, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 25);
            this.label15.TabIndex = 51;
            this.label15.Text = "X:";
            // 
            // move_to_y
            // 
            this.move_to_y.Location = new System.Drawing.Point(56, 73);
            this.move_to_y.Name = "move_to_y";
            this.move_to_y.Size = new System.Drawing.Size(81, 22);
            this.move_to_y.TabIndex = 50;
            // 
            // move_to_x
            // 
            this.move_to_x.Location = new System.Drawing.Point(56, 45);
            this.move_to_x.Name = "move_to_x";
            this.move_to_x.Size = new System.Drawing.Size(81, 22);
            this.move_to_x.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.move_to_x);
            this.groupBox1.Controls.Add(this.move_to_y);
            this.groupBox1.Controls.Add(this.btn_move);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.btn_change_circle);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_change_el);
            this.groupBox1.Controls.Add(this.btn_change_rect);
            this.groupBox1.Controls.Add(this.btn_change_sq);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(758, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 418);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление фигурой";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.btn_house);
            this.groupBox2.Controls.Add(this.btn_triangle);
            this.groupBox2.Controls.Add(this.btn_poly);
            this.groupBox2.Controls.Add(this.btn_square);
            this.groupBox2.Controls.Add(this.btn_rect);
            this.groupBox2.Controls.Add(this.btn_circle);
            this.groupBox2.Controls.Add(this.btn_ellipse);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 446);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(889, 87);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Создание фигур";
            // 
            // btn_house
            // 
            this.btn_house.Location = new System.Drawing.Point(758, 21);
            this.btn_house.Name = "btn_house";
            this.btn_house.Size = new System.Drawing.Size(123, 42);
            this.btn_house.TabIndex = 50;
            this.btn_house.Text = "Дом";
            this.btn_house.UseVisualStyleBackColor = true;
            this.btn_house.Click += new System.EventHandler(this.btn_house_Click);
            // 
            // btn_triangle
            // 
            this.btn_triangle.Location = new System.Drawing.Point(629, 21);
            this.btn_triangle.Name = "btn_triangle";
            this.btn_triangle.Size = new System.Drawing.Size(123, 42);
            this.btn_triangle.TabIndex = 49;
            this.btn_triangle.Text = "Треугольник";
            this.btn_triangle.UseVisualStyleBackColor = true;
            this.btn_triangle.Click += new System.EventHandler(this.btn_triangle_Click);
            // 
            // btn_poly
            // 
            this.btn_poly.Location = new System.Drawing.Point(500, 21);
            this.btn_poly.Name = "btn_poly";
            this.btn_poly.Size = new System.Drawing.Size(123, 42);
            this.btn_poly.TabIndex = 48;
            this.btn_poly.Text = "Многоугольник";
            this.btn_poly.UseVisualStyleBackColor = true;
            this.btn_poly.Click += new System.EventHandler(this.btn_poly_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(912, 545);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.figuresListBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Lab2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ListBox figuresListBox;
        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.Button btn_change_rect;
        private System.Windows.Forms.Button btn_change_sq;
        private System.Windows.Forms.Button btn_change_el;
        private System.Windows.Forms.Button btn_change_circle;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_square;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox move_to_y;
        private System.Windows.Forms.TextBox move_to_x;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_house;
        private System.Windows.Forms.Button btn_triangle;
        private System.Windows.Forms.Button btn_poly;
    }
}

