namespace Work5
{
    partial class News
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(News));
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Yandex Sans Display Bold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 91);
            label1.Name = "label1";
            label1.Size = new Size(577, 50);
            label1.TabIndex = 45;
            label1.Text = "День социально-правовой информации для граждан \r\nстаршего поколения «Ваши права — вопросы и ответы»\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Yandex Sans Display Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(16, 149);
            label4.Name = "label4";
            label4.Size = new Size(555, 57);
            label4.TabIndex = 46;
            label4.Text = "9 ноября 2023 года с 14.00 до 19.00 в ЦГПБ им. В. В. Маяковского по адресу: \r\nнаб. реки Фонтанки, д. 44 пройдет День социально-правовой \r\nинформации для граждан старшего поколения";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Info;
            label5.Font = new Font("Yandex Sans Display Regular", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(16, 215);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(119, 19);
            label5.TabIndex = 47;
            label5.Text = "читать далее...";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Info;
            label8.Font = new Font("Yandex Sans Display Regular", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(17, 405);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(119, 19);
            label8.TabIndex = 50;
            label8.Text = "читать далее...";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Yandex Sans Display Regular", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(17, 339);
            label9.Name = "label9";
            label9.Size = new Size(629, 57);
            label9.TabIndex = 49;
            label9.Text = "4 и 6 октября приглашаем на мероприятия в рамках Недели \r\nинформационной поддержки граждан пожилого возраста и \r\nцелевой программы ЦГПБ им. В. В. Маяковского «Библиотека – старшему поколению».";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Control;
            label10.Font = new Font("Yandex Sans Display Bold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(16, 281);
            label10.Name = "label10";
            label10.Size = new Size(737, 50);
            label10.TabIndex = 48;
            label10.Text = "Мероприятия в рамках Недели информационной поддержки граждан \r\nпожилого возраста";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yandex Sans Display Bold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 22);
            label2.Name = "label2";
            label2.Size = new Size(171, 44);
            label2.TabIndex = 52;
            label2.Text = "Новости";
            // 
            // News
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 697);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "News";
            Text = "Библиотека // Новости";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label2;
    }
}