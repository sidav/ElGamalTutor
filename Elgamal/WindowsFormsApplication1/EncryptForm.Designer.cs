namespace ElgamalTutor
{
    partial class EncryptForm
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
            this.pBox = new System.Windows.Forms.TextBox();
            this.gBox = new System.Windows.Forms.TextBox();
            this.kBox = new System.Windows.Forms.TextBox();
            this.MBox = new System.Windows.Forms.TextBox();
            this.aBox = new System.Windows.Forms.TextBox();
            this.bBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.genkBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.yBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ERRORLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(102, 37);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(273, 20);
            this.pBox.TabIndex = 0;
            this.pBox.TextChanged += new System.EventHandler(this.pBox_TextChanged);
            // 
            // gBox
            // 
            this.gBox.Location = new System.Drawing.Point(102, 63);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(273, 20);
            this.gBox.TabIndex = 1;
            this.gBox.TextChanged += new System.EventHandler(this.gBox_TextChanged);
            // 
            // kBox
            // 
            this.kBox.Location = new System.Drawing.Point(102, 114);
            this.kBox.Name = "kBox";
            this.kBox.Size = new System.Drawing.Size(159, 20);
            this.kBox.TabIndex = 2;
            this.kBox.TextChanged += new System.EventHandler(this.kBox_TextChanged);
            // 
            // MBox
            // 
            this.MBox.Location = new System.Drawing.Point(146, 141);
            this.MBox.Multiline = true;
            this.MBox.Name = "MBox";
            this.MBox.Size = new System.Drawing.Size(136, 58);
            this.MBox.TabIndex = 3;
            this.MBox.TextChanged += new System.EventHandler(this.MBox_TextChanged);
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(102, 251);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(273, 20);
            this.aBox.TabIndex = 4;
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(102, 277);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(273, 20);
            this.bBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Зашифрование:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "p = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "g = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "k = ";
            // 
            // genkBtn
            // 
            this.genkBtn.Location = new System.Drawing.Point(267, 112);
            this.genkBtn.Name = "genkBtn";
            this.genkBtn.Size = new System.Drawing.Size(108, 23);
            this.genkBtn.TabIndex = 10;
            this.genkBtn.Text = "Сгенерировать";
            this.genkBtn.UseVisualStyleBackColor = true;
            this.genkBtn.Click += new System.EventHandler(this.genkBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Текст для зашифровки:";
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Location = new System.Drawing.Point(288, 141);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(87, 58);
            this.EncryptBtn.TabIndex = 12;
            this.EncryptBtn.Text = "Шифровать!";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Шифротекст:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "a = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "b = ";
            // 
            // yBox
            // 
            this.yBox.Location = new System.Drawing.Point(102, 88);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(273, 20);
            this.yBox.TabIndex = 16;
            this.yBox.TextChanged += new System.EventHandler(this.yBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "y = ";
            // 
            // ERRORLabel
            // 
            this.ERRORLabel.AutoSize = true;
            this.ERRORLabel.ForeColor = System.Drawing.Color.Red;
            this.ERRORLabel.Location = new System.Drawing.Point(23, 202);
            this.ERRORLabel.Name = "ERRORLabel";
            this.ERRORLabel.Size = new System.Drawing.Size(353, 13);
            this.ERRORLabel.TabIndex = 18;
            this.ERRORLabel.Text = "Размер сообщения превысил размер ключа.  Введите другой текст";
            this.ERRORLabel.Visible = false;
            // 
            // EncryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 307);
            this.Controls.Add(this.ERRORLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EncryptBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.genkBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.aBox);
            this.Controls.Add(this.MBox);
            this.Controls.Add(this.kBox);
            this.Controls.Add(this.gBox);
            this.Controls.Add(this.pBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EncryptForm";
            this.Text = "Шифрование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pBox;
        private System.Windows.Forms.TextBox gBox;
        private System.Windows.Forms.TextBox kBox;
        private System.Windows.Forms.TextBox MBox;
        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.TextBox bBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button genkBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ERRORLabel;
    }
}