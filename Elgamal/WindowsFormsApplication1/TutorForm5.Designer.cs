namespace ElgamalTutor
{
    partial class TutorForm5
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
            this.ptextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generatepBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.generategBtn = new System.Windows.Forms.Button();
            this.gtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.generatexBtn = new System.Windows.Forms.Button();
            this.xtextBox = new System.Windows.Forms.TextBox();
            this.ytextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.generateyBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.wrongpLabel = new System.Windows.Forms.Label();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ptextBox
            // 
            this.ptextBox.Location = new System.Drawing.Point(110, 81);
            this.ptextBox.Name = "ptextBox";
            this.ptextBox.Size = new System.Drawing.Size(407, 20);
            this.ptextBox.TabIndex = 1;
            this.ptextBox.TextChanged += new System.EventHandler(this.ptextBox_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "1. Генерируется случайное простое число p.";
            // 
            // generatepBtn
            // 
            this.generatepBtn.Location = new System.Drawing.Point(12, 78);
            this.generatepBtn.Name = "generatepBtn";
            this.generatepBtn.Size = new System.Drawing.Size(89, 23);
            this.generatepBtn.TabIndex = 3;
            this.generatepBtn.Text = "Генерировать";
            this.generatepBtn.UseVisualStyleBackColor = true;
            this.generatepBtn.Click += new System.EventHandler(this.generatepBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "2. Вычисляется число g, которое является первообразным корнем числа p.";
            // 
            // generategBtn
            // 
            this.generategBtn.Location = new System.Drawing.Point(12, 145);
            this.generategBtn.Name = "generategBtn";
            this.generategBtn.Size = new System.Drawing.Size(89, 23);
            this.generategBtn.TabIndex = 5;
            this.generategBtn.Text = "Вычислить";
            this.generategBtn.UseVisualStyleBackColor = true;
            this.generategBtn.Click += new System.EventHandler(this.generategBtn_Click);
            // 
            // gtextBox
            // 
            this.gtextBox.Location = new System.Drawing.Point(110, 147);
            this.gtextBox.Name = "gtextBox";
            this.gtextBox.ReadOnly = true;
            this.gtextBox.Size = new System.Drawing.Size(407, 20);
            this.gtextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "3. Выбирается целое случайное число x, такое, что 1 < x < p.\r\n";
            // 
            // generatexBtn
            // 
            this.generatexBtn.Location = new System.Drawing.Point(12, 217);
            this.generatexBtn.Name = "generatexBtn";
            this.generatexBtn.Size = new System.Drawing.Size(89, 23);
            this.generatexBtn.TabIndex = 8;
            this.generatexBtn.Text = "Генерировать";
            this.generatexBtn.UseVisualStyleBackColor = true;
            this.generatexBtn.Click += new System.EventHandler(this.generatexBtn_Click);
            // 
            // xtextBox
            // 
            this.xtextBox.Location = new System.Drawing.Point(110, 220);
            this.xtextBox.Name = "xtextBox";
            this.xtextBox.Size = new System.Drawing.Size(407, 20);
            this.xtextBox.TabIndex = 9;
            this.xtextBox.TextChanged += new System.EventHandler(this.xtextBox_TextChanged);
            // 
            // ytextBox
            // 
            this.ytextBox.Location = new System.Drawing.Point(110, 292);
            this.ytextBox.Name = "ytextBox";
            this.ytextBox.ReadOnly = true;
            this.ytextBox.Size = new System.Drawing.Size(407, 20);
            this.ytextBox.TabIndex = 10;
            this.ytextBox.TextChanged += new System.EventHandler(this.ytextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "4. Вычисляется y = g^x mod p.";
            // 
            // generateyBtn
            // 
            this.generateyBtn.Location = new System.Drawing.Point(12, 289);
            this.generateyBtn.Name = "generateyBtn";
            this.generateyBtn.Size = new System.Drawing.Size(89, 23);
            this.generateyBtn.TabIndex = 12;
            this.generateyBtn.Text = "Вычислить";
            this.generateyBtn.UseVisualStyleBackColor = true;
            this.generateyBtn.Click += new System.EventHandler(this.generateyBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(399, 388);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(118, 45);
            this.nextBtn.TabIndex = 13;
            this.nextBtn.Text = "Далее";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ключи в схеме Эль-Гамаля генерируются следующим образом:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(526, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Тройка чисел (p, g, y) является открытым ключом схемы Эль-Гамаля, а число х - сек" +
    "ретным ключом. \r\n";
            // 
            // wrongpLabel
            // 
            this.wrongpLabel.AutoSize = true;
            this.wrongpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wrongpLabel.ForeColor = System.Drawing.Color.Red;
            this.wrongpLabel.Location = new System.Drawing.Point(248, 48);
            this.wrongpLabel.Name = "wrongpLabel";
            this.wrongpLabel.Size = new System.Drawing.Size(269, 20);
            this.wrongpLabel.TabIndex = 17;
            this.wrongpLabel.Text = "Число p должно быть простым";
            this.wrongpLabel.Visible = false;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(12, 388);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(95, 45);
            this.ReturnBtn.TabIndex = 22;
            this.ReturnBtn.Text = "Назад";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // TutorForm5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 445);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.wrongpLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.generateyBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ytextBox);
            this.Controls.Add(this.xtextBox);
            this.Controls.Add(this.generatexBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gtextBox);
            this.Controls.Add(this.generategBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generatepBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TutorForm5";
            this.Text = "Генерация ключей";
            this.Load += new System.EventHandler(this.TutorForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ptextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generatepBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generategBtn;
        private System.Windows.Forms.TextBox gtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button generatexBtn;
        private System.Windows.Forms.TextBox xtextBox;
        private System.Windows.Forms.TextBox ytextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button generateyBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label wrongpLabel;
        private System.Windows.Forms.Button ReturnBtn;
    }
}