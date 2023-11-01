namespace Work5
{
    partial class Readers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Readers));
            label2 = new Label();
            dataGridView1 = new DataGridView();
            textBox3 = new TextBox();
            label6 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yandex Sans Display Bold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 24);
            label2.Name = "label2";
            label2.Size = new Size(187, 44);
            label2.TabIndex = 37;
            label2.Text = "Читатели";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(813, 288);
            dataGridView1.TabIndex = 36;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(11, 591);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 23);
            textBox3.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yandex Sans Text Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 569);
            label6.Name = "label6";
            label6.Size = new Size(64, 19);
            label6.TabIndex = 42;
            label6.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yandex Sans Text Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 510);
            label3.Name = "label3";
            label3.Size = new Size(46, 19);
            label3.TabIndex = 41;
            label3.Text = "ФИО";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 532);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 23);
            textBox2.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yandex Sans Text Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 451);
            label1.Name = "label1";
            label1.Size = new Size(137, 19);
            label1.TabIndex = 39;
            label1.Text = "Номер телефона";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 473);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 23);
            textBox1.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yandex Sans Text Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(11, 391);
            label4.Name = "label4";
            label4.Size = new Size(25, 19);
            label4.TabIndex = 45;
            label4.Text = "ID";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 413);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(250, 23);
            textBox4.TabIndex = 44;
            textBox4.Text = "2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SpringGreen;
            label5.Font = new Font("Yandex Sans Text Regular", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(315, 468);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 46;
            label5.Text = "добавить";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientActiveCaption;
            label7.Font = new Font("Yandex Sans Text Regular", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(315, 505);
            label7.Name = "label7";
            label7.Size = new Size(105, 25);
            label7.TabIndex = 47;
            label7.Text = "обновить";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.IndianRed;
            label8.Font = new Font("Yandex Sans Text Regular", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(315, 543);
            label8.Name = "label8";
            label8.Size = new Size(91, 25);
            label8.TabIndex = 48;
            label8.Text = "удалить";
            // 
            // Readers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 637);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Readers";
            Text = "Библиотека // Читатели (Администратор)";
            Load += Readers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private Label label6;
        private Label label3;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Label label7;
        private Label label8;
    }
}