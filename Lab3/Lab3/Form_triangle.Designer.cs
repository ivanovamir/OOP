namespace Lab2
{
    partial class Form_triangle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.x_1 = new System.Windows.Forms.TextBox();
            this.y_1 = new System.Windows.Forms.TextBox();
            this.x_2 = new System.Windows.Forms.TextBox();
            this.y_2 = new System.Windows.Forms.TextBox();
            this.x_3 = new System.Windows.Forms.TextBox();
            this.y_3 = new System.Windows.Forms.TextBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите точки треугольника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y:";
            // 
            // x_1
            // 
            this.x_1.Location = new System.Drawing.Point(86, 41);
            this.x_1.Name = "x_1";
            this.x_1.Size = new System.Drawing.Size(57, 22);
            this.x_1.TabIndex = 3;
            // 
            // y_1
            // 
            this.y_1.Location = new System.Drawing.Point(86, 76);
            this.y_1.Name = "y_1";
            this.y_1.Size = new System.Drawing.Size(57, 22);
            this.y_1.TabIndex = 4;
            // 
            // x_2
            // 
            this.x_2.Location = new System.Drawing.Point(183, 41);
            this.x_2.Name = "x_2";
            this.x_2.Size = new System.Drawing.Size(57, 22);
            this.x_2.TabIndex = 5;
            // 
            // y_2
            // 
            this.y_2.Location = new System.Drawing.Point(183, 76);
            this.y_2.Name = "y_2";
            this.y_2.Size = new System.Drawing.Size(57, 22);
            this.y_2.TabIndex = 6;
            // 
            // x_3
            // 
            this.x_3.Location = new System.Drawing.Point(281, 41);
            this.x_3.Name = "x_3";
            this.x_3.Size = new System.Drawing.Size(57, 22);
            this.x_3.TabIndex = 7;
            // 
            // y_3
            // 
            this.y_3.Location = new System.Drawing.Point(281, 76);
            this.y_3.Name = "y_3";
            this.y_3.Size = new System.Drawing.Size(57, 22);
            this.y_3.TabIndex = 8;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(226, 9);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(112, 23);
            this.btnDraw.TabIndex = 9;
            this.btnDraw.Text = "Нарисовать";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // Form_triangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 127);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.y_3);
            this.Controls.Add(this.x_3);
            this.Controls.Add(this.y_2);
            this.Controls.Add(this.x_2);
            this.Controls.Add(this.y_1);
            this.Controls.Add(this.x_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_triangle";
            this.Text = "Form_trianglecs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox x_1;
        private System.Windows.Forms.TextBox y_1;
        private System.Windows.Forms.TextBox x_2;
        private System.Windows.Forms.TextBox y_2;
        private System.Windows.Forms.TextBox x_3;
        private System.Windows.Forms.TextBox y_3;
        private System.Windows.Forms.Button btnDraw;
    }
}