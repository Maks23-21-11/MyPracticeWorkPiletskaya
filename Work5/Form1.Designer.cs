namespace Work5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label8 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yandex Sans Display Bold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(180, 47);
            label1.Name = "label1";
            label1.Size = new Size(233, 44);
            label1.TabIndex = 0;
            label1.Text = "Библиотека";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(202, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yandex Sans Text Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(224, 102);
            label2.Name = "label2";
            label2.Size = new Size(137, 19);
            label2.TabIndex = 2;
            label2.Text = "Номер телефона";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yandex Sans Text Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(256, 155);
            label3.Name = "label3";
            label3.Size = new Size(64, 19);
            label3.TabIndex = 4;
            label3.Text = "Пароль";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(212, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 23);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.openEye;
            pictureBox1.Location = new Point(370, 177);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yandex Sans Text Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(224, 215);
            label5.Name = "label5";
            label5.Size = new Size(134, 15);
            label5.TabIndex = 7;
            label5.Text = "зарегистрироваться";
            label5.Click += label5_Click;
            label5.MouseEnter += label5_MouseEnter;
            label5.MouseLeave += label5_MouseLeave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yandex Sans Text Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(267, 275);
            label6.Name = "label6";
            label6.Size = new Size(53, 19);
            label6.TabIndex = 9;
            label6.Text = "Капча";
            label6.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(220, 350);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(152, 23);
            textBox3.TabIndex = 8;
            textBox3.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yandex Sans Text Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(166, 302);
            label7.Name = "label7";
            label7.Size = new Size(270, 45);
            label7.TabIndex = 10;
            label7.Text = "Вы слишком много ошибаетесь.\r\nПозвольте нам убедиться, что вы не робот.\r\nДля этого введите текст с картинки";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(220, 389);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 50);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(190, 402);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaption;
            label8.Font = new Font("Yandex Sans Text Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(378, 408);
            label8.Name = "label8";
            label8.Size = new Size(103, 15);
            label8.TabIndex = 13;
            label8.Text = "проверьте меня";
            label8.Visible = false;
            label8.Click += label8_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.IndianRed;
            label4.Font = new Font("Yandex Sans Text Regular", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(256, 240);
            label4.Name = "label4";
            label4.Size = new Size(78, 23);
            label4.TabIndex = 14;
            label4.Text = "ВОЙТИ";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(607, 478);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Библиотека // Авторизация";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label8;
        private Label label4;
    }
}