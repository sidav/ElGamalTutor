namespace ElgamalTutor
{
    partial class DiscreteLogAlgorithmsInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscreteLogAlgorithmsInfoForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AnswerBox2 = new System.Windows.Forms.TextBox();
            this.Task2Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AnswerBox1 = new System.Windows.Forms.TextBox();
            this.Task1Label = new System.Windows.Forms.Label();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(376, 128);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ответ:";
            // 
            // AnswerBox2
            // 
            this.AnswerBox2.Location = new System.Drawing.Point(58, 211);
            this.AnswerBox2.Name = "AnswerBox2";
            this.AnswerBox2.Size = new System.Drawing.Size(100, 20);
            this.AnswerBox2.TabIndex = 22;
            // 
            // Task2Label
            // 
            this.Task2Label.AutoSize = true;
            this.Task2Label.Location = new System.Drawing.Point(12, 195);
            this.Task2Label.Name = "Task2Label";
            this.Task2Label.Size = new System.Drawing.Size(351, 13);
            this.Task2Label.TabIndex = 21;
            this.Task2Label.Text = "Попробуйте найти логарифм по основанию х и модулю у от числа z:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ответ:";
            // 
            // AnswerBox1
            // 
            this.AnswerBox1.Location = new System.Drawing.Point(58, 159);
            this.AnswerBox1.Name = "AnswerBox1";
            this.AnswerBox1.Size = new System.Drawing.Size(100, 20);
            this.AnswerBox1.TabIndex = 19;
            // 
            // Task1Label
            // 
            this.Task1Label.AutoSize = true;
            this.Task1Label.Location = new System.Drawing.Point(12, 143);
            this.Task1Label.Name = "Task1Label";
            this.Task1Label.Size = new System.Drawing.Size(351, 13);
            this.Task1Label.TabIndex = 18;
            this.Task1Label.Text = "Попробуйте найти логарифм по основанию х и модулю у от числа z:";
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(12, 303);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(95, 43);
            this.ReturnBtn.TabIndex = 25;
            this.ReturnBtn.Text = "Назад";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(276, 303);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(116, 43);
            this.nextBtn.TabIndex = 24;
            this.nextBtn.Text = "Далее";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // DiscreteLogAlgorithmsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 358);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnswerBox2);
            this.Controls.Add(this.Task2Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnswerBox1);
            this.Controls.Add(this.Task1Label);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DiscreteLogAlgorithmsInfoForm";
            this.Text = "Алгоритмы решения задачи дискретного логарифмирования";
            this.Load += new System.EventHandler(this.DiscreteLogAlgorithmsInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AnswerBox2;
        private System.Windows.Forms.Label Task2Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AnswerBox1;
        private System.Windows.Forms.Label Task1Label;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button nextBtn;
    }
}