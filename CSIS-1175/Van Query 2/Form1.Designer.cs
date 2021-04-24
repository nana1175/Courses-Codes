
namespace Van_Query_2
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
            this.InputTxtBx = new System.Windows.Forms.TextBox();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.ResultTxtBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputTxtBx
            // 
            this.InputTxtBx.Location = new System.Drawing.Point(189, 22);
            this.InputTxtBx.Multiline = true;
            this.InputTxtBx.Name = "InputTxtBx";
            this.InputTxtBx.Size = new System.Drawing.Size(523, 170);
            this.InputTxtBx.TabIndex = 0;
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Location = new System.Drawing.Point(329, 276);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(229, 42);
            this.ConvertBtn.TabIndex = 1;
            this.ConvertBtn.Text = "Convert";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // ResultTxtBx
            // 
            this.ResultTxtBx.Location = new System.Drawing.Point(189, 394);
            this.ResultTxtBx.Multiline = true;
            this.ResultTxtBx.Name = "ResultTxtBx";
            this.ResultTxtBx.Size = new System.Drawing.Size(523, 175);
            this.ResultTxtBx.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 646);
            this.Controls.Add(this.ResultTxtBx);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.InputTxtBx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.TextBox InputTxtBx;
        private System.Windows.Forms.TextBox ResultTxtBx;
    }
}

