namespace KalkulatorGitHub
{
    partial class Form1
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
            this.Add = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.InputA = new System.Windows.Forms.TextBox();
            this.InputB = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(23, 66);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "Dodaj";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Subtract
            // 
            this.Subtract.Location = new System.Drawing.Point(124, 66);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(75, 23);
            this.Subtract.TabIndex = 1;
            this.Subtract.Text = "Odejmij";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(23, 104);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(75, 23);
            this.Multiply.TabIndex = 2;
            this.Multiply.Text = "Pomnóż";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(124, 104);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(75, 23);
            this.Divide.TabIndex = 3;
            this.Divide.Text = "Podziel";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // InputA
            // 
            this.InputA.Location = new System.Drawing.Point(23, 13);
            this.InputA.Name = "InputA";
            this.InputA.Size = new System.Drawing.Size(100, 20);
            this.InputA.TabIndex = 5;
            // 
            // InputB
            // 
            this.InputB.Location = new System.Drawing.Point(157, 13);
            this.InputB.Name = "InputB";
            this.InputB.Size = new System.Drawing.Size(100, 20);
            this.InputB.TabIndex = 6;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(284, 13);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 20);
            this.Result.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 215);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.InputB);
            this.Controls.Add(this.InputA);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Add);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.TextBox InputA;
        private System.Windows.Forms.TextBox InputB;
        private System.Windows.Forms.TextBox Result;
    }
}

