namespace Work5
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yandex Sans Text Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(253, 200);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 12;
            label3.Text = "Ваше ФИО";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 226);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 23);
            textBox2.TabIndex = 11;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yandex Sans Text Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(233, 129);
            label2.Name = "label2";
            label2.Size = new Size(137, 19);
            label2.TabIndex = 10;
            label2.Text = "Номер телефона";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yandex Sans Display Bold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(89, 68);
            label1.Name = "label1";
            label1.Size = new Size(477, 44);
            label1.TabIndex = 8;
            label1.Text = "Библиотека. Регистрация";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yandex Sans Text Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(216, 274);
            label6.Name = "label6";
            label6.Size = new Size(161, 19);
            label6.TabIndex = 16;
            label6.Text = "Придумайте пароль";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(207, 301);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(182, 23);
            textBox3.TabIndex = 17;
            textBox3.UseSystemPasswordChar = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(207, 366);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(182, 23);
            textBox4.TabIndex = 19;
            textBox4.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yandex Sans Text Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(223, 339);
            label4.Name = "label4";
            label4.Size = new Size(148, 19);
            label4.TabIndex = 18;
            label4.Text = "Повторите пароль";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.openEye;
            pictureBox1.Location = new Point(395, 301);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.openEye;
            pictureBox2.Location = new Point(395, 366);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Yandex Sans Display Bold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(179, 412);
            button1.Name = "button1";
            button1.Size = new Size(247, 47);
            button1.TabIndex = 22;
            button1.Text = "зарегистрироваться";
            button1.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 531);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Register";
            Text = "Библиотека // Регистрация";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
    }
}