namespace ElgamalTutor
{
    partial class TutorForm7
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
            this.MNumBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gLabel = new System.Windows.Forms.Label();
            this.pLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.endBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MNumBox
            // 
            this.MNumBox.Location = new System.Drawing.Point(94, 142);
            this.MNumBox.Name = "MNumBox";
            this.MNumBox.ReadOnly = true;
            this.MNumBox.Size = new System.Drawing.Size(254, 20);
            this.MNumBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Итак, мы получили шифротекст:";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(12, 22);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(25, 13);
            this.aLabel.TabIndex = 2;
            this.aLabel.Text = "a = ";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(12, 35);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(25, 13);
            this.bLabel.TabIndex = 3;
            this.bLabel.Text = "b = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Также у нас есть открытый ключ:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.Location = new System.Drawing.Point(12, 61);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(25, 13);
            this.gLabel.TabIndex = 5;
            this.gLabel.Text = "g = ";
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Location = new System.Drawing.Point(12, 74);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(25, 13);
            this.pLabel.TabIndex = 6;
            this.pLabel.Text = "p = ";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(12, 87);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(24, 13);
            this.yLabel.TabIndex = 7;
            this.yLabel.Text = "y = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "и секретный ключ";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(12, 113);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(24, 13);
            this.xLabel.TabIndex = 9;
            this.xLabel.Text = "x = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Сообщение М можно получить по формуле: М = b*(a^x)^-1 mod p";
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.Location = new System.Drawing.Point(12, 140);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(75, 23);
            this.DecryptBtn.TabIndex = 11;
            this.DecryptBtn.Text = "Вычислить";
            this.DecryptBtn.UseVisualStyleBackColor = true;
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Или, если перевести в текст: ";
            // 
            // MtextBox
            // 
            this.MtextBox.Location = new System.Drawing.Point(174, 163);
            this.MtextBox.Name = "MtextBox";
            this.MtextBox.ReadOnly = true;
            this.MtextBox.Size = new System.Drawing.Size(173, 20);
            this.MtextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Таким образом, мы провели все этапы шифрования";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "по схеме Эль-Гамаля.";
            // 
            // endBtn
            // 
            this.endBtn.Location = new System.Drawing.Point(227, 255);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(120, 46);
            this.endBtn.TabIndex = 16;
            this.endBtn.Text = "Далее";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(12, 255);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(96, 46);
            this.ReturnBtn.TabIndex = 17;
            this.ReturnBtn.Text = "Назад";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // TutorForm7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 313);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DecryptBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.pLabel);
            this.Controls.Add(this.gLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MNumBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TutorForm7";
            this.Text = "Расшифрование";
            this.Load += new System.EventHandler(this.TutorForm7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MNumBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button endBtn;
        private System.Windows.Forms.Button ReturnBtn;
    }
}