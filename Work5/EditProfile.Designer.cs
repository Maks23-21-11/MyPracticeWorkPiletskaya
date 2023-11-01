namespace Work5
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            label7 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientActiveCaption;
            label7.Font = new Font("Yandex Sans Text Regular", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(500, 228);
            label7.Name = "label7";
            label7.Size = new Size(105, 25);
            label7.TabIndex = 58;
            label7.Text = "обновить";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yandex Sans Text Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(196, 114);
            label4.Name = "label4";
            label4.Size = new Size(25, 19);
            label4.TabIndex = 56;
            label4.Text = "ID";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(197, 136);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(250, 23);
            textBox4.TabIndex = 55;
            textBox4.Text = "1";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(196, 314);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 23);
            textBox3.TabIndex = 54;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yandex Sans Text Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(197, 292);
            label6.Name = "label6";
            label6.Size = new Size(64, 19);
            label6.TabIndex = 53;
            label6.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yandex Sans Text Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(197, 233);
            label3.Name = "label3";
            label3.Size = new Size(46, 19);
            label3.TabIndex = 52;
            label3.Text = "ФИО";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(197, 255);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 23);
            textBox2.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yandex Sans Text Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(196, 174);
            label1.Name = "label1";
            label1.Size = new Size(137, 19);
            label1.TabIndex = 50;
            label1.Text = "Номер телефона";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(197, 196);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 23);
            textBox1.TabIndex = 49;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditProfile";
            Text = "Библиотека // Изменить профиль";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label6;
        private Label label3;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
    }
}