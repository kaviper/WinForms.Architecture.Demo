namespace WinForms.Architecture.Demo.Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnResult = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.rbPlus = new System.Windows.Forms.RadioButton();
            this.rbMinus = new System.Windows.Forms.RadioButton();
            this.rbMulti = new System.Windows.Forms.RadioButton();
            this.rbDivide = new System.Windows.Forms.RadioButton();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(12, 95);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(149, 44);
            this.btnResult.TabIndex = 0;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(12, 12);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(149, 23);
            this.txtNum1.TabIndex = 1;
            // 
            // rbPlus
            // 
            this.rbPlus.AutoSize = true;
            this.rbPlus.Location = new System.Drawing.Point(12, 41);
            this.rbPlus.Name = "rbPlus";
            this.rbPlus.Size = new System.Drawing.Size(33, 19);
            this.rbPlus.TabIndex = 2;
            this.rbPlus.TabStop = true;
            this.rbPlus.Text = "+";
            this.rbPlus.UseVisualStyleBackColor = true;
            // 
            // rbMinus
            // 
            this.rbMinus.AutoSize = true;
            this.rbMinus.Location = new System.Drawing.Point(51, 41);
            this.rbMinus.Name = "rbMinus";
            this.rbMinus.Size = new System.Drawing.Size(30, 19);
            this.rbMinus.TabIndex = 3;
            this.rbMinus.TabStop = true;
            this.rbMinus.Text = "-";
            this.rbMinus.UseVisualStyleBackColor = true;
            // 
            // rbMulti
            // 
            this.rbMulti.AutoSize = true;
            this.rbMulti.Location = new System.Drawing.Point(87, 41);
            this.rbMulti.Name = "rbMulti";
            this.rbMulti.Size = new System.Drawing.Size(32, 19);
            this.rbMulti.TabIndex = 4;
            this.rbMulti.TabStop = true;
            this.rbMulti.Text = "X";
            this.rbMulti.UseVisualStyleBackColor = true;
            // 
            // rbDivide
            // 
            this.rbDivide.AutoSize = true;
            this.rbDivide.Location = new System.Drawing.Point(125, 41);
            this.rbDivide.Name = "rbDivide";
            this.rbDivide.Size = new System.Drawing.Size(30, 19);
            this.rbDivide.TabIndex = 5;
            this.rbDivide.TabStop = true;
            this.rbDivide.Text = "/";
            this.rbDivide.UseVisualStyleBackColor = true;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(12, 66);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(149, 23);
            this.txtNum2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 158);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.rbDivide);
            this.Controls.Add(this.rbMulti);
            this.Controls.Add(this.rbMinus);
            this.Controls.Add(this.rbPlus);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.RadioButton rbPlus;
        private System.Windows.Forms.RadioButton rbMinus;
        private System.Windows.Forms.RadioButton rbMulti;
        private System.Windows.Forms.RadioButton rbDivide;
        private System.Windows.Forms.TextBox txtNum2;
    }
}
