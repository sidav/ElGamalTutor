namespace ElgamalTutor
{
    partial class TutorForm6
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
            this.gLabel = new System.Windows.Forms.Label();
            this.pLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kBox = new System.Windows.Forms.TextBox();
            this.generatekBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.calcaBtn = new System.Windows.Forms.Button();
            this.aBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.calcbbtn = new System.Windows.Forms.Button();
            this.bBox = new System.Windows.Forms.TextBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.wrongMLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Шифрование в схеме Эль-Гамаля осуществляется в три этапа.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Итак, по открытому каналу получен открытый ключ (g, p, y), со значениями:";
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.Location = new System.Drawing.Point(12, 22);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(25, 13);
            this.gLabel.TabIndex = 2;
            this.gLabel.Text = "g = ";
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Location = new System.Drawing.Point(12, 35);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(25, 13);
            this.pLabel.TabIndex = 3;
            this.pLabel.Text = "p = ";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(12, 48);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(24, 13);
            this.yLabel.TabIndex = 4;
            this.yLabel.Text = "y = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Теперь получившая открытый ключ сторона может зашифровать сообщение М.\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "1. Выбираем сессионный ключ: случайное k, такое, что 1 < k < p-1";
            // 
            // kBox
            // 
            this.kBox.Location = new System.Drawing.Point(117, 177);
            this.kBox.Name = "kBox";
            this.kBox.Size = new System.Drawing.Size(326, 20);
            this.kBox.TabIndex = 7;
            this.kBox.TextChanged += new System.EventHandler(this.kBox_TextChanged);
            // 
            // generatekBtn
            // 
            this.generatekBtn.Location = new System.Drawing.Point(15, 175);
            this.generatekBtn.Name = "generatekBtn";
            this.generatekBtn.Size = new System.Drawing.Size(96, 23);
            this.generatekBtn.TabIndex = 8;
            this.generatekBtn.Text = "Сгенерировать";
            this.generatekBtn.UseVisualStyleBackColor = true;
            this.generatekBtn.Click += new System.EventHandler(this.generatekBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "2. Вычисляем число а = g^k (mod p). ";
            // 
            // calcaBtn
            // 
            this.calcaBtn.Location = new System.Drawing.Point(15, 228);
            this.calcaBtn.Name = "calcaBtn";
            this.calcaBtn.Size = new System.Drawing.Size(96, 23);
            this.calcaBtn.TabIndex = 10;
            this.calcaBtn.Text = "Вычислить";
            this.calcaBtn.UseVisualStyleBackColor = true;
            this.calcaBtn.Click += new System.EventHandler(this.calcaBtn_Click);
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(117, 231);
            this.aBox.Name = "aBox";
            this.aBox.ReadOnly = true;
            this.aBox.Size = new System.Drawing.Size(326, 20);
            this.aBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Введите М:";
            // 
            // MBox
            // 
            this.MBox.Location = new System.Drawing.Point(82, 79);
            this.MBox.Name = "MBox";
            this.MBox.Size = new System.Drawing.Size(259, 20);
            this.MBox.TabIndex = 13;
            this.MBox.TextChanged += new System.EventHandler(this.MBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "3. Вычисляем число b = y^k * M (mod p)";
            // 
            // calcbbtn
            // 
            this.calcbbtn.Location = new System.Drawing.Point(15, 280);
            this.calcbbtn.Name = "calcbbtn";
            this.calcbbtn.Size = new System.Drawing.Size(96, 23);
            this.calcbbtn.TabIndex = 16;
            this.calcbbtn.Text = "Вычислить";
            this.calcbbtn.UseVisualStyleBackColor = true;
            this.calcbbtn.Click += new System.EventHandler(this.calcbbtn_Click);
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(117, 282);
            this.bBox.Name = "bBox";
            this.bBox.ReadOnly = true;
            this.bBox.Size = new System.Drawing.Size(326, 20);
            this.bBox.TabIndex = 17;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(336, 367);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(118, 45);
            this.nextBtn.TabIndex = 18;
            this.nextBtn.Text = "Далее";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Пара чисел (a, b) является шифротекстом.";
            // 
            // wrongMLabel
            // 
            this.wrongMLabel.AutoSize = true;
            this.wrongMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wrongMLabel.ForeColor = System.Drawing.Color.Red;
            this.wrongMLabel.Location = new System.Drawing.Point(22, 102);
            this.wrongMLabel.Name = "wrongMLabel";
            this.wrongMLabel.Size = new System.Drawing.Size(383, 13);
            this.wrongMLabel.TabIndex = 20;
            this.wrongMLabel.Text = "Размер открытого текста превысил размер ключа. Введите другой текст\r\n";
            this.wrongMLabel.Visible = false;
            this.wrongMLabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // TutorForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 424);
            this.Controls.Add(this.wrongMLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.calcbbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.aBox);
            this.Controls.Add(this.calcaBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.generatekBtn);
            this.Controls.Add(this.kBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.pLabel);
            this.Controls.Add(this.gLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TutorForm3";
            this.Text = "Шифрование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kBox;
        private System.Windows.Forms.Button generatekBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calcaBtn;
        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button calcbbtn;
        private System.Windows.Forms.TextBox bBox;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label wrongMLabel;
    }
}