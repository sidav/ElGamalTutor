namespace ElgamalTutor
{
    partial class DecryptForm
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
            this.digitsBox = new System.Windows.Forms.TextBox();
            this.pBox = new System.Windows.Forms.TextBox();
            this.genpgBtn = new System.Windows.Forms.Button();
            this.gBox = new System.Windows.Forms.TextBox();
            this.xBox = new System.Windows.Forms.TextBox();
            this.genxBtn = new System.Windows.Forms.Button();
            this.yBox = new System.Windows.Forms.TextBox();
            this.genyBtn = new System.Windows.Forms.Button();
            this.aBox = new System.Windows.Forms.TextBox();
            this.bBox = new System.Windows.Forms.TextBox();
            this.MBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // digitsBox
            // 
            this.digitsBox.Location = new System.Drawing.Point(257, 42);
            this.digitsBox.Name = "digitsBox";
            this.digitsBox.Size = new System.Drawing.Size(85, 20);
            this.digitsBox.TabIndex = 0;
            this.digitsBox.TextChanged += new System.EventHandler(this.digitsBox_TextChanged);
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(47, 70);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(195, 20);
            this.pBox.TabIndex = 1;
            this.pBox.TextChanged += new System.EventHandler(this.pBox_TextChanged);
            // 
            // genpgBtn
            // 
            this.genpgBtn.Location = new System.Drawing.Point(248, 68);
            this.genpgBtn.Name = "genpgBtn";
            this.genpgBtn.Size = new System.Drawing.Size(97, 48);
            this.genpgBtn.TabIndex = 2;
            this.genpgBtn.Text = "Сгенерировать";
            this.genpgBtn.UseVisualStyleBackColor = true;
            this.genpgBtn.Click += new System.EventHandler(this.genpgBtn_Click);
            // 
            // gBox
            // 
            this.gBox.Location = new System.Drawing.Point(47, 96);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(195, 20);
            this.gBox.TabIndex = 3;
            this.gBox.TextChanged += new System.EventHandler(this.gBox_TextChanged);
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(47, 122);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(195, 20);
            this.xBox.TabIndex = 5;
            this.xBox.TextChanged += new System.EventHandler(this.xBox_TextChanged);
            // 
            // genxBtn
            // 
            this.genxBtn.Location = new System.Drawing.Point(248, 120);
            this.genxBtn.Name = "genxBtn";
            this.genxBtn.Size = new System.Drawing.Size(97, 23);
            this.genxBtn.TabIndex = 6;
            this.genxBtn.Text = "Сгенерировать";
            this.genxBtn.UseVisualStyleBackColor = true;
            this.genxBtn.Click += new System.EventHandler(this.genxBtn_Click);
            // 
            // yBox
            // 
            this.yBox.Location = new System.Drawing.Point(47, 148);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(195, 20);
            this.yBox.TabIndex = 7;
            this.yBox.TextChanged += new System.EventHandler(this.yBox_TextChanged);
            // 
            // genyBtn
            // 
            this.genyBtn.Location = new System.Drawing.Point(248, 146);
            this.genyBtn.Name = "genyBtn";
            this.genyBtn.Size = new System.Drawing.Size(97, 23);
            this.genyBtn.TabIndex = 8;
            this.genyBtn.Text = "Вычислить";
            this.genyBtn.UseVisualStyleBackColor = true;
            this.genyBtn.Click += new System.EventHandler(this.genyBtn_Click);
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(47, 223);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(286, 20);
            this.aBox.TabIndex = 9;
            this.aBox.TextChanged += new System.EventHandler(this.aBox_TextChanged);
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(47, 249);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(286, 20);
            this.bBox.TabIndex = 10;
            this.bBox.TextChanged += new System.EventHandler(this.bBox_TextChanged);
            // 
            // MBox
            // 
            this.MBox.Location = new System.Drawing.Point(182, 337);
            this.MBox.Multiline = true;
            this.MBox.Name = "MBox";
            this.MBox.Size = new System.Drawing.Size(151, 35);
            this.MBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Генерация/ввод ключей:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Кол-во разрядов p (только для генерации):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "p = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "g = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "x = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "y = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Расшифрование: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "a = ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "b = ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Расшифрованное сообщение:";
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(124, 275);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(96, 40);
            this.decryptBtn.TabIndex = 22;
            this.decryptBtn.Text = "Расшифровать";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // DecryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 384);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MBox);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.aBox);
            this.Controls.Add(this.genyBtn);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.genxBtn);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.gBox);
            this.Controls.Add(this.genpgBtn);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.digitsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DecryptForm";
            this.Text = "Генерация ключей и расшифрование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox digitsBox;
        private System.Windows.Forms.TextBox pBox;
        private System.Windows.Forms.Button genpgBtn;
        private System.Windows.Forms.TextBox gBox;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.Button genxBtn;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.Button genyBtn;
        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.TextBox bBox;
        private System.Windows.Forms.TextBox MBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button decryptBtn;
    }
}