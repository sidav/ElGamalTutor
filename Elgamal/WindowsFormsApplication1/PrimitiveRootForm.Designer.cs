namespace ElgamalTutor
{
    partial class PrimitiveRootForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.generateModuloBtn = new System.Windows.Forms.Button();
            this.trueBox = new System.Windows.Forms.TextBox();
            this.fakeBox = new System.Windows.Forms.TextBox();
            this.trueGenBtn1 = new System.Windows.Forms.Button();
            this.fakeGenBtn = new System.Windows.Forms.Button();
            this.digitsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(12, 42);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(317, 20);
            this.pBox.TabIndex = 0;
            this.pBox.TextChanged += new System.EventHandler(this.pBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите или сгенерируйте модуль ";
            // 
            // generateModuloBtn
            // 
            this.generateModuloBtn.Location = new System.Drawing.Point(327, 68);
            this.generateModuloBtn.Name = "generateModuloBtn";
            this.generateModuloBtn.Size = new System.Drawing.Size(98, 23);
            this.generateModuloBtn.TabIndex = 2;
            this.generateModuloBtn.Text = "Сгенерировать";
            this.generateModuloBtn.UseVisualStyleBackColor = true;
            this.generateModuloBtn.Click += new System.EventHandler(this.generatepBtn_Click);
            // 
            // trueBox
            // 
            this.trueBox.Location = new System.Drawing.Point(154, 125);
            this.trueBox.Name = "trueBox";
            this.trueBox.Size = new System.Drawing.Size(269, 20);
            this.trueBox.TabIndex = 3;
            // 
            // fakeBox
            // 
            this.fakeBox.Location = new System.Drawing.Point(154, 164);
            this.fakeBox.Name = "fakeBox";
            this.fakeBox.Size = new System.Drawing.Size(269, 20);
            this.fakeBox.TabIndex = 4;
            // 
            // trueGenBtn1
            // 
            this.trueGenBtn1.Location = new System.Drawing.Point(12, 122);
            this.trueGenBtn1.Name = "trueGenBtn1";
            this.trueGenBtn1.Size = new System.Drawing.Size(119, 23);
            this.trueGenBtn1.TabIndex = 5;
            this.trueGenBtn1.Text = "Полный метод";
            this.trueGenBtn1.UseVisualStyleBackColor = true;
            this.trueGenBtn1.Click += new System.EventHandler(this.trueGenBtn1_Click);
            // 
            // fakeGenBtn
            // 
            this.fakeGenBtn.Location = new System.Drawing.Point(12, 161);
            this.fakeGenBtn.Name = "fakeGenBtn";
            this.fakeGenBtn.Size = new System.Drawing.Size(119, 23);
            this.fakeGenBtn.TabIndex = 6;
            this.fakeGenBtn.Text = "Упрощённый метод";
            this.fakeGenBtn.UseVisualStyleBackColor = true;
            this.fakeGenBtn.Click += new System.EventHandler(this.fakeGenBtn_Click);
            // 
            // digitsBox
            // 
            this.digitsBox.Location = new System.Drawing.Point(337, 42);
            this.digitsBox.Name = "digitsBox";
            this.digitsBox.Size = new System.Drawing.Size(88, 20);
            this.digitsBox.TabIndex = 7;
            this.digitsBox.TextChanged += new System.EventHandler(this.digitsBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "кол-во разрядов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Вычислить:";
            // 
            // PrimitiveRootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 210);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.digitsBox);
            this.Controls.Add(this.fakeGenBtn);
            this.Controls.Add(this.trueGenBtn1);
            this.Controls.Add(this.fakeBox);
            this.Controls.Add(this.trueBox);
            this.Controls.Add(this.generateModuloBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PrimitiveRootForm";
            this.Text = "Вычисление первообразного корня";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateModuloBtn;
        private System.Windows.Forms.TextBox trueBox;
        private System.Windows.Forms.TextBox fakeBox;
        private System.Windows.Forms.Button trueGenBtn1;
        private System.Windows.Forms.Button fakeGenBtn;
        private System.Windows.Forms.TextBox digitsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}