namespace ElgamalTutor
{
    partial class TutorForm3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorForm3));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.answerBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.answerBox2 = new System.Windows.Forms.TextBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(328, 112);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "x = 4^(-1) mod 9 = ";
            // 
            // answerBox1
            // 
            this.answerBox1.Location = new System.Drawing.Point(113, 124);
            this.answerBox1.Name = "answerBox1";
            this.answerBox1.Size = new System.Drawing.Size(100, 20);
            this.answerBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 166);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(328, 37);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "2. Если известна функция Эйлера fi(m), то\r\n (a^-1)mod m = a^(fi(m)-1)mod m.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "x = 18^(-1) mod 29 =";
            // 
            // answerBox2
            // 
            this.answerBox2.Location = new System.Drawing.Point(113, 219);
            this.answerBox2.Name = "answerBox2";
            this.answerBox2.Size = new System.Drawing.Size(100, 20);
            this.answerBox2.TabIndex = 5;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(222, 274);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(118, 47);
            this.nextBtn.TabIndex = 6;
            this.nextBtn.Text = "Далее";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(12, 274);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(95, 47);
            this.ReturnBtn.TabIndex = 10;
            this.ReturnBtn.Text = "Назад";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // TutorForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 333);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.answerBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.answerBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TutorForm3";
            this.Text = "Нахождение обратного по модулю";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox answerBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox answerBox2;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button ReturnBtn;
    }
}