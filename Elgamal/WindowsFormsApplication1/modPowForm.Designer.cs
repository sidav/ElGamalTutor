namespace ElgamalTutor
{
    partial class modPowForm
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
            this.XBox = new System.Windows.Forms.TextBox();
            this.YBox = new System.Windows.Forms.TextBox();
            this.MBox = new System.Windows.Forms.TextBox();
            this.modPowBtn = new System.Windows.Forms.Button();
            this.modPowBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // XBox
            // 
            this.XBox.Location = new System.Drawing.Point(34, 12);
            this.XBox.Name = "XBox";
            this.XBox.Size = new System.Drawing.Size(364, 20);
            this.XBox.TabIndex = 0;
            // 
            // YBox
            // 
            this.YBox.Location = new System.Drawing.Point(34, 55);
            this.YBox.Name = "YBox";
            this.YBox.Size = new System.Drawing.Size(364, 20);
            this.YBox.TabIndex = 1;
            // 
            // MBox
            // 
            this.MBox.Location = new System.Drawing.Point(34, 95);
            this.MBox.Name = "MBox";
            this.MBox.Size = new System.Drawing.Size(364, 20);
            this.MBox.TabIndex = 2;
            // 
            // modPowBtn
            // 
            this.modPowBtn.Location = new System.Drawing.Point(150, 121);
            this.modPowBtn.Name = "modPowBtn";
            this.modPowBtn.Size = new System.Drawing.Size(97, 38);
            this.modPowBtn.TabIndex = 3;
            this.modPowBtn.Text = "Вычислить";
            this.modPowBtn.UseVisualStyleBackColor = true;
            this.modPowBtn.Click += new System.EventHandler(this.modPowBtn_Click);
            // 
            // modPowBox
            // 
            this.modPowBox.Location = new System.Drawing.Point(8, 231);
            this.modPowBox.Name = "modPowBox";
            this.modPowBox.Size = new System.Drawing.Size(390, 20);
            this.modPowBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "M =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "X^Y MOD M =";
            // 
            // modPowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 311);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modPowBox);
            this.Controls.Add(this.modPowBtn);
            this.Controls.Add(this.MBox);
            this.Controls.Add(this.YBox);
            this.Controls.Add(this.XBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "modPowForm";
            this.Text = "       X^Y MOD M";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox XBox;
        private System.Windows.Forms.TextBox YBox;
        private System.Windows.Forms.TextBox MBox;
        private System.Windows.Forms.Button modPowBtn;
        private System.Windows.Forms.TextBox modPowBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}