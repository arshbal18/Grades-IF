namespace Grades_IF
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lbxGrade = new System.Windows.Forms.ListBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(210, 68);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(106, 42);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate This!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(347, 55);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(154, 20);
            this.txtGrade.TabIndex = 1;
            // 
            // lbxGrade
            // 
            this.lbxGrade.BackColor = System.Drawing.Color.Wheat;
            this.lbxGrade.FormattingEnabled = true;
            this.lbxGrade.Location = new System.Drawing.Point(211, 163);
            this.lbxGrade.Name = "lbxGrade";
            this.lbxGrade.Size = new System.Drawing.Size(105, 69);
            this.lbxGrade.TabIndex = 2;
            this.lbxGrade.SelectedIndexChanged += new System.EventHandler(this.lbxGrade_SelectedIndexChanged);
            // 
            // lblGrade
            // 
            this.lblGrade.BackColor = System.Drawing.Color.Wheat;
            this.lblGrade.Location = new System.Drawing.Point(341, 163);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(160, 69);
            this.lblGrade.TabIndex = 3;
            this.lblGrade.Text = "nothing";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(347, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lbxGrade);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.ListBox lbxGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox textBox1;
    }
}

