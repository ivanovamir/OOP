namespace Lab2
{
    partial class Form_house
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
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.house_y = new System.Windows.Forms.TextBox();
            this.house_x = new System.Windows.Forms.TextBox();
            this.House_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Введите координаты";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(19, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 25);
            this.label6.TabIndex = 46;
            this.label6.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "X:";
            // 
            // house_y
            // 
            this.house_y.Location = new System.Drawing.Point(56, 71);
            this.house_y.Name = "house_y";
            this.house_y.Size = new System.Drawing.Size(49, 22);
            this.house_y.TabIndex = 43;
            // 
            // house_x
            // 
            this.house_x.Location = new System.Drawing.Point(57, 43);
            this.house_x.Name = "house_x";
            this.house_x.Size = new System.Drawing.Size(48, 22);
            this.house_x.TabIndex = 42;
            // 
            // House_create
            // 
            this.House_create.Location = new System.Drawing.Point(111, 41);
            this.House_create.Name = "House_create";
            this.House_create.Size = new System.Drawing.Size(92, 52);
            this.House_create.TabIndex = 41;
            this.House_create.Text = "Создать";
            this.House_create.UseVisualStyleBackColor = true;
            this.House_create.Click += new System.EventHandler(this.House_create_Click);
            // 
            // Form_house
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 114);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.house_y);
            this.Controls.Add(this.house_x);
            this.Controls.Add(this.House_create);
            this.Name = "Form_house";
            this.Text = "Дом";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox house_y;
        private System.Windows.Forms.TextBox house_x;
        private System.Windows.Forms.Button House_create;
    }
}