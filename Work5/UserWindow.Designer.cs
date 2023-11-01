namespace Work5
{
    partial class UserWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserWindow));
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yandex Sans Text Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(202, 125);
            label3.Name = "label3";
            label3.Size = new Size(362, 25);
            label3.TabIndex = 12;
            label3.Text = "Квасов Арсений Александрович";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yandex Sans Display Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(85, 19);
            label2.TabIndex = 10;
            label2.Text = "Мои книги";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yandex Sans Display Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(103, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 19);
            label1.TabIndex = 16;
            label1.Text = "Библиотека";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yandex Sans Display Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(202, 9);
            label6.Name = "label6";
            label6.Size = new Size(70, 19);
            label6.TabIndex = 17;
            label6.Text = "Новости";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Font = new Font("Yandex Sans Display Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(719, 9);
            label7.Name = "label7";
            label7.Size = new Size(106, 19);
            label7.TabIndex = 18;
            label7.Text = "Мой профиль";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yandex Sans Display Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(204, 167);
            label8.Name = "label8";
            label8.Size = new Size(149, 19);
            label8.TabIndex = 19;
            label8.Text = "+7 (999) 520-50-47";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yandex Sans Display Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(207, 195);
            label9.Name = "label9";
            label9.Size = new Size(114, 19);
            label9.TabIndex = 20;
            label9.Text = "2 января 2005";
            // 
            // button1
            // 
            button1.Font = new Font("Yandex Sans Display Bold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(207, 228);
            button1.Name = "button1";
            button1.Size = new Size(114, 31);
            button1.TabIndex = 23;
            button1.Text = "изменить";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yandex Sans Display Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(204, 102);
            label4.Name = "label4";
            label4.Size = new Size(73, 19);
            label4.TabIndex = 34;
            label4.Text = "читатель";
            // 
            // UserWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 353);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserWindow";
            Text = "Библиотека // Главная";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
        private Label label4;
    }
}