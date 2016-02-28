namespace ElgamalTutor
{
    partial class MainMenuForm
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
            this.startTutorBtn = new System.Windows.Forms.Button();
            this.fiBtn = new System.Windows.Forms.Button();
            this.primitBtn = new System.Windows.Forms.Button();
            this.genKeysBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.primeTestBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.modPowBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startTutorBtn
            // 
            this.startTutorBtn.Location = new System.Drawing.Point(12, 12);
            this.startTutorBtn.Name = "startTutorBtn";
            this.startTutorBtn.Size = new System.Drawing.Size(260, 45);
            this.startTutorBtn.TabIndex = 0;
            this.startTutorBtn.Text = "Начать обучение";
            this.startTutorBtn.UseVisualStyleBackColor = true;
            this.startTutorBtn.Click += new System.EventHandler(this.startTutorBtn_Click);
            // 
            // fiBtn
            // 
            this.fiBtn.Location = new System.Drawing.Point(12, 292);
            this.fiBtn.Name = "fiBtn";
            this.fiBtn.Size = new System.Drawing.Size(260, 45);
            this.fiBtn.TabIndex = 1;
            this.fiBtn.Text = "Вычислить функцию Эйлера от заданного числа";
            this.fiBtn.UseVisualStyleBackColor = true;
            this.fiBtn.Click += new System.EventHandler(this.fiBtn_Click);
            // 
            // primitBtn
            // 
            this.primitBtn.Location = new System.Drawing.Point(12, 236);
            this.primitBtn.Name = "primitBtn";
            this.primitBtn.Size = new System.Drawing.Size(260, 45);
            this.primitBtn.TabIndex = 2;
            this.primitBtn.Text = "Найти первообразный корень числа";
            this.primitBtn.UseVisualStyleBackColor = true;
            this.primitBtn.Click += new System.EventHandler(this.primitBtn_Click);
            // 
            // genKeysBtn
            // 
            this.genKeysBtn.Location = new System.Drawing.Point(12, 68);
            this.genKeysBtn.Name = "genKeysBtn";
            this.genKeysBtn.Size = new System.Drawing.Size(260, 45);
            this.genKeysBtn.TabIndex = 3;
            this.genKeysBtn.Text = "Сгенерировать ключи/расшифровать\r\n";
            this.genKeysBtn.UseVisualStyleBackColor = true;
            this.genKeysBtn.Click += new System.EventHandler(this.genKeysBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(12, 124);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(260, 45);
            this.decryptBtn.TabIndex = 5;
            this.decryptBtn.Text = "Зашифровать";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // primeTestBtn
            // 
            this.primeTestBtn.Location = new System.Drawing.Point(12, 180);
            this.primeTestBtn.Name = "primeTestBtn";
            this.primeTestBtn.Size = new System.Drawing.Size(260, 45);
            this.primeTestBtn.TabIndex = 6;
            this.primeTestBtn.Text = "Протестировать число на простоту";
            this.primeTestBtn.UseVisualStyleBackColor = true;
            this.primeTestBtn.Click += new System.EventHandler(this.primeTestBtn_Click);
            // 
            // AboutBtn
            // 
            this.AboutBtn.Location = new System.Drawing.Point(12, 407);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(260, 45);
            this.AboutBtn.TabIndex = 7;
            this.AboutBtn.Text = "О программе";
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // modPowBtn
            // 
            this.modPowBtn.Location = new System.Drawing.Point(12, 343);
            this.modPowBtn.Name = "modPowBtn";
            this.modPowBtn.Size = new System.Drawing.Size(260, 45);
            this.modPowBtn.TabIndex = 8;
            this.modPowBtn.Text = "Возведение в степень по модулю";
            this.modPowBtn.UseVisualStyleBackColor = true;
            this.modPowBtn.Click += new System.EventHandler(this.modPowBtn_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 469);
            this.Controls.Add(this.modPowBtn);
            this.Controls.Add(this.AboutBtn);
            this.Controls.Add(this.primeTestBtn);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.genKeysBtn);
            this.Controls.Add(this.primitBtn);
            this.Controls.Add(this.fiBtn);
            this.Controls.Add(this.startTutorBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.Text = "Схема Эль-Гамаля";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startTutorBtn;
        private System.Windows.Forms.Button fiBtn;
        private System.Windows.Forms.Button primitBtn;
        private System.Windows.Forms.Button genKeysBtn;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Button primeTestBtn;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button modPowBtn;
    }
}

