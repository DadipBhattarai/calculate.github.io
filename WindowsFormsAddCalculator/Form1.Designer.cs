namespace WindowsFormsAddCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Number1 = new System.Windows.Forms.TextBox();
            this.Number2 = new System.Windows.Forms.TextBox();
            this.SumNum = new System.Windows.Forms.Label();
            this.DiffNum = new System.Windows.Forms.Label();
            this.DivNum = new System.Windows.Forms.Label();
            this.MulNum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num1:-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Num2:-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Division:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Multiplication:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Difference:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Summation:";
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(206, 26);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(204, 20);
            this.Number1.TabIndex = 6;
            // 
            // Number2
            // 
            this.Number2.Location = new System.Drawing.Point(206, 58);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(204, 20);
            this.Number2.TabIndex = 7;
            // 
            // SumNum
            // 
            this.SumNum.AutoSize = true;
            this.SumNum.Location = new System.Drawing.Point(216, 133);
            this.SumNum.Name = "SumNum";
            this.SumNum.Size = new System.Drawing.Size(13, 13);
            this.SumNum.TabIndex = 8;
            this.SumNum.Text = "--";
            // 
            // DiffNum
            // 
            this.DiffNum.AutoSize = true;
            this.DiffNum.Location = new System.Drawing.Point(216, 168);
            this.DiffNum.Name = "DiffNum";
            this.DiffNum.Size = new System.Drawing.Size(13, 13);
            this.DiffNum.TabIndex = 9;
            this.DiffNum.Text = "--";
            // 
            // DivNum
            // 
            this.DivNum.AutoSize = true;
            this.DivNum.Location = new System.Drawing.Point(216, 234);
            this.DivNum.Name = "DivNum";
            this.DivNum.Size = new System.Drawing.Size(13, 13);
            this.DivNum.TabIndex = 10;
            this.DivNum.Text = "--";
            // 
            // MulNum
            // 
            this.MulNum.AutoSize = true;
            this.MulNum.Location = new System.Drawing.Point(216, 201);
            this.MulNum.Name = "MulNum";
            this.MulNum.Size = new System.Drawing.Size(13, 13);
            this.MulNum.TabIndex = 11;
            this.MulNum.Text = "--";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calculation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MulNum);
            this.Controls.Add(this.DivNum);
            this.Controls.Add(this.DiffNum);
            this.Controls.Add(this.SumNum);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AddCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Number1;
        private System.Windows.Forms.TextBox Number2;
        private System.Windows.Forms.Label SumNum;
        private System.Windows.Forms.Label DiffNum;
        private System.Windows.Forms.Label DivNum;
        private System.Windows.Forms.Label MulNum;
        private System.Windows.Forms.Button button1;
    }
}

