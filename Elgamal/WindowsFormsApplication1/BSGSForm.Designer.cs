namespace ElgamalTutor
{
    partial class BSGSForm
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
            this.DoMagicBtn = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ABox = new System.Windows.Forms.TextBox();
            this.BBox = new System.Windows.Forms.TextBox();
            this.MBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DoMagicBtn
            // 
            this.DoMagicBtn.Location = new System.Drawing.Point(136, 143);
            this.DoMagicBtn.Name = "DoMagicBtn";
            this.DoMagicBtn.Size = new System.Drawing.Size(136, 37);
            this.DoMagicBtn.TabIndex = 0;
            this.DoMagicBtn.Text = "Вычислить";
            this.DoMagicBtn.UseVisualStyleBackColor = true;
            this.DoMagicBtn.Click += new System.EventHandler(this.DoMagicBtn_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.Location = new System.Drawing.Point(8, 208);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(135, 20);
            this.ResultLabel.TabIndex = 1;
            this.ResultLabel.Text = "Ответ будет тут";
            this.ResultLabel.Visible = false;
            // 
            // ABox
            // 
            this.ABox.Location = new System.Drawing.Point(31, 65);
            this.ABox.Name = "ABox";
            this.ABox.Size = new System.Drawing.Size(241, 20);
            this.ABox.TabIndex = 2;
            // 
            // BBox
            // 
            this.BBox.Location = new System.Drawing.Point(31, 91);
            this.BBox.Name = "BBox";
            this.BBox.Size = new System.Drawing.Size(241, 20);
            this.BBox.TabIndex = 3;
            // 
            // MBox
            // 
            this.MBox.Location = new System.Drawing.Point(31, 117);
            this.MBox.Name = "MBox";
            this.MBox.Size = new System.Drawing.Size(241, 20);
            this.MBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "M";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "A^x = B mod M ";
            // 
            // BSGSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MBox);
            this.Controls.Add(this.BBox);
            this.Controls.Add(this.ABox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.DoMagicBtn);
            this.MaximizeBox = false;
            this.Name = "BSGSForm";
            this.Text = "Дискретный логарифм";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoMagicBtn;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox ABox;
        private System.Windows.Forms.TextBox BBox;
        private System.Windows.Forms.TextBox MBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}