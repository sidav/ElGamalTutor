namespace ElgamalTutor
{
    partial class TutorForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorForm2));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.QuestionLabel1 = new System.Windows.Forms.Label();
            this.QuestionLabel2 = new System.Windows.Forms.Label();
            this.QuestionLabel3 = new System.Windows.Forms.Label();
            this.answerBox1 = new System.Windows.Forms.TextBox();
            this.answerBox2 = new System.Windows.Forms.TextBox();
            this.answerBox3 = new System.Windows.Forms.TextBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(302, 194);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // QuestionLabel1
            // 
            this.QuestionLabel1.AutoSize = true;
            this.QuestionLabel1.Location = new System.Drawing.Point(12, 300);
            this.QuestionLabel1.Name = "QuestionLabel1";
            this.QuestionLabel1.Size = new System.Drawing.Size(35, 13);
            this.QuestionLabel1.TabIndex = 1;
            this.QuestionLabel1.Text = "fi(x) = ";
            // 
            // QuestionLabel2
            // 
            this.QuestionLabel2.AutoSize = true;
            this.QuestionLabel2.Location = new System.Drawing.Point(12, 337);
            this.QuestionLabel2.Name = "QuestionLabel2";
            this.QuestionLabel2.Size = new System.Drawing.Size(35, 13);
            this.QuestionLabel2.TabIndex = 2;
            this.QuestionLabel2.Text = "fi(x) = ";
            // 
            // QuestionLabel3
            // 
            this.QuestionLabel3.AutoSize = true;
            this.QuestionLabel3.Location = new System.Drawing.Point(12, 371);
            this.QuestionLabel3.Name = "QuestionLabel3";
            this.QuestionLabel3.Size = new System.Drawing.Size(35, 13);
            this.QuestionLabel3.TabIndex = 3;
            this.QuestionLabel3.Text = "fi(x) = ";
            // 
            // answerBox1
            // 
            this.answerBox1.Location = new System.Drawing.Point(53, 297);
            this.answerBox1.Name = "answerBox1";
            this.answerBox1.Size = new System.Drawing.Size(100, 20);
            this.answerBox1.TabIndex = 4;
            // 
            // answerBox2
            // 
            this.answerBox2.Location = new System.Drawing.Point(53, 334);
            this.answerBox2.Name = "answerBox2";
            this.answerBox2.Size = new System.Drawing.Size(100, 20);
            this.answerBox2.TabIndex = 5;
            // 
            // answerBox3
            // 
            this.answerBox3.Location = new System.Drawing.Point(53, 368);
            this.answerBox3.Name = "answerBox3";
            this.answerBox3.Size = new System.Drawing.Size(100, 20);
            this.answerBox3.TabIndex = 6;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(190, 406);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(116, 43);
            this.nextBtn.TabIndex = 7;
            this.nextBtn.Text = "Далее";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 73);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // TutorForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.answerBox3);
            this.Controls.Add(this.answerBox2);
            this.Controls.Add(this.answerBox1);
            this.Controls.Add(this.QuestionLabel3);
            this.Controls.Add(this.QuestionLabel2);
            this.Controls.Add(this.QuestionLabel1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TutorForm2";
            this.Text = "Функция Эйлера";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label QuestionLabel1;
        private System.Windows.Forms.Label QuestionLabel2;
        private System.Windows.Forms.Label QuestionLabel3;
        private System.Windows.Forms.TextBox answerBox1;
        private System.Windows.Forms.TextBox answerBox2;
        private System.Windows.Forms.TextBox answerBox3;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}