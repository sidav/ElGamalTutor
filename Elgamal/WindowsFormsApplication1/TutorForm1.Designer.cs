namespace ElgamalTutor
{
    partial class TutorForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorForm1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.QuestionLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.answerBox1 = new System.Windows.Forms.TextBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.answerBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QuestionLabel2 = new System.Windows.Forms.Label();
            this.answerBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QuestionLabel3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(326, 122);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // QuestionLabel1
            // 
            this.QuestionLabel1.AutoSize = true;
            this.QuestionLabel1.Location = new System.Drawing.Point(9, 163);
            this.QuestionLabel1.Name = "QuestionLabel1";
            this.QuestionLabel1.Size = new System.Drawing.Size(258, 13);
            this.QuestionLabel1.TabIndex = 1;
            this.QuestionLabel1.Text = "Попробуйте возвести g в степень x по модулю m.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ответ:";
            // 
            // answerBox1
            // 
            this.answerBox1.Location = new System.Drawing.Point(52, 179);
            this.answerBox1.Name = "answerBox1";
            this.answerBox1.Size = new System.Drawing.Size(100, 20);
            this.answerBox1.TabIndex = 3;
            this.answerBox1.TextChanged += new System.EventHandler(this.answerBox_TextChanged);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(233, 318);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(113, 41);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "Далее";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // answerBox2
            // 
            this.answerBox2.Location = new System.Drawing.Point(52, 225);
            this.answerBox2.Name = "answerBox2";
            this.answerBox2.Size = new System.Drawing.Size(100, 20);
            this.answerBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ответ:";
            // 
            // QuestionLabel2
            // 
            this.QuestionLabel2.AutoSize = true;
            this.QuestionLabel2.Location = new System.Drawing.Point(9, 209);
            this.QuestionLabel2.Name = "QuestionLabel2";
            this.QuestionLabel2.Size = new System.Drawing.Size(67, 13);
            this.QuestionLabel2.TabIndex = 5;
            this.QuestionLabel2.Text = "g^x mod m =";
            // 
            // answerBox3
            // 
            this.answerBox3.Location = new System.Drawing.Point(52, 270);
            this.answerBox3.Name = "answerBox3";
            this.answerBox3.Size = new System.Drawing.Size(100, 20);
            this.answerBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ответ:";
            // 
            // QuestionLabel3
            // 
            this.QuestionLabel3.AutoSize = true;
            this.QuestionLabel3.Location = new System.Drawing.Point(9, 254);
            this.QuestionLabel3.Name = "QuestionLabel3";
            this.QuestionLabel3.Size = new System.Drawing.Size(67, 13);
            this.QuestionLabel3.TabIndex = 8;
            this.QuestionLabel3.Text = "g^x mod m =";
            // 
            // TutorForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 371);
            this.Controls.Add(this.answerBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QuestionLabel3);
            this.Controls.Add(this.answerBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuestionLabel2);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.answerBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuestionLabel1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TutorForm1";
            this.Text = "Возведение в степень по модулю";
            this.Load += new System.EventHandler(this.TutorForm11_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label QuestionLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox answerBox1;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.TextBox answerBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label QuestionLabel2;
        private System.Windows.Forms.TextBox answerBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label QuestionLabel3;
    }
}