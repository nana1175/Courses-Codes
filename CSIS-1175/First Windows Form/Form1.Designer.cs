
namespace Class_P
{
    partial class FirstAppForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelName1 = new System.Windows.Forms.Label();
            this.name1TextBox = new System.Windows.Forms.TextBox();
            this.btn1Display = new System.Windows.Forms.Button();
            this.btn1Close = new System.Windows.Forms.Button();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.dependentLabel = new System.Windows.Forms.Label();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.dependentTextBox = new System.Windows.Forms.TextBox();
            this.grossLabel = new System.Windows.Forms.Label();
            this.deductionLabel = new System.Windows.Forms.Label();
            this.netPayLabel = new System.Windows.Forms.Label();
            this.grossTextBox = new System.Windows.Forms.TextBox();
            this.deductTextBx = new System.Windows.Forms.TextBox();
            this.netPayTextBox = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(326, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Our Application\r\n";
            // 
            // labelName1
            // 
            this.labelName1.AutoSize = true;
            this.labelName1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName1.Location = new System.Drawing.Point(231, 125);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(61, 23);
            this.labelName1.TabIndex = 1;
            this.labelName1.Text = "Name";
            // 
            // name1TextBox
            // 
            this.name1TextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name1TextBox.Location = new System.Drawing.Point(353, 114);
            this.name1TextBox.Name = "name1TextBox";
            this.name1TextBox.Size = new System.Drawing.Size(240, 34);
            this.name1TextBox.TabIndex = 2;
            // 
            // btn1Display
            // 
            this.btn1Display.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn1Display.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1Display.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1Display.Location = new System.Drawing.Point(231, 279);
            this.btn1Display.Name = "btn1Display";
            this.btn1Display.Size = new System.Drawing.Size(94, 53);
            this.btn1Display.TabIndex = 3;
            this.btn1Display.Text = "Display";
            this.btn1Display.UseVisualStyleBackColor = false;
            this.btn1Display.Click += new System.EventHandler(this.btn1Display_Click);
            // 
            // btn1Close
            // 
            this.btn1Close.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn1Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1Close.Location = new System.Drawing.Point(500, 281);
            this.btn1Close.Name = "btn1Close";
            this.btn1Close.Size = new System.Drawing.Size(94, 48);
            this.btn1Close.TabIndex = 4;
            this.btn1Close.Text = "Close";
            this.btn1Close.UseVisualStyleBackColor = false;
            this.btn1Close.Click += new System.EventHandler(this.btn1Close_Click);
            // 
            // labelDisplay
            // 
            this.labelDisplay.AutoSize = true;
            this.labelDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.labelDisplay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDisplay.Location = new System.Drawing.Point(641, 433);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(178, 32);
            this.labelDisplay.TabIndex = 5;
            this.labelDisplay.Text = "Display\'s Name";
            this.labelDisplay.Visible = false;
            this.labelDisplay.Click += new System.EventHandler(this.labelDisplay_Click);
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hoursLabel.Location = new System.Drawing.Point(173, 175);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(119, 23);
            this.hoursLabel.TabIndex = 6;
            this.hoursLabel.Text = "No Of Hours";
            // 
            // dependentLabel
            // 
            this.dependentLabel.AutoSize = true;
            this.dependentLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dependentLabel.Location = new System.Drawing.Point(124, 230);
            this.dependentLabel.Name = "dependentLabel";
            this.dependentLabel.Size = new System.Drawing.Size(168, 23);
            this.dependentLabel.TabIndex = 7;
            this.dependentLabel.Text = "No of Dependents";
            this.dependentLabel.Click += new System.EventHandler(this.dependentLabel_Click);
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(353, 171);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(239, 27);
            this.hoursTextBox.TabIndex = 8;
            // 
            // dependentTextBox
            // 
            this.dependentTextBox.Location = new System.Drawing.Point(353, 226);
            this.dependentTextBox.Name = "dependentTextBox";
            this.dependentTextBox.Size = new System.Drawing.Size(239, 27);
            this.dependentTextBox.TabIndex = 9;
            // 
            // grossLabel
            // 
            this.grossLabel.AutoSize = true;
            this.grossLabel.Location = new System.Drawing.Point(49, 360);
            this.grossLabel.Name = "grossLabel";
            this.grossLabel.Size = new System.Drawing.Size(73, 20);
            this.grossLabel.TabIndex = 10;
            this.grossLabel.Text = "Gross pay";
            this.grossLabel.Visible = false;
            // 
            // deductionLabel
            // 
            this.deductionLabel.AutoSize = true;
            this.deductionLabel.Location = new System.Drawing.Point(45, 410);
            this.deductionLabel.Name = "deductionLabel";
            this.deductionLabel.Size = new System.Drawing.Size(106, 20);
            this.deductionLabel.TabIndex = 11;
            this.deductionLabel.Text = "Fed Deduction";
            this.deductionLabel.Visible = false;
            // 
            // netPayLabel
            // 
            this.netPayLabel.AutoSize = true;
            this.netPayLabel.Location = new System.Drawing.Point(49, 458);
            this.netPayLabel.Name = "netPayLabel";
            this.netPayLabel.Size = new System.Drawing.Size(59, 20);
            this.netPayLabel.TabIndex = 12;
            this.netPayLabel.Text = "Net Pay";
            this.netPayLabel.Visible = false;
            // 
            // grossTextBox
            // 
            this.grossTextBox.Location = new System.Drawing.Point(163, 362);
            this.grossTextBox.Name = "grossTextBox";
            this.grossTextBox.Size = new System.Drawing.Size(110, 27);
            this.grossTextBox.TabIndex = 13;
            this.grossTextBox.Visible = false;
            // 
            // deductTextBx
            // 
            this.deductTextBx.Location = new System.Drawing.Point(161, 414);
            this.deductTextBx.Name = "deductTextBx";
            this.deductTextBx.Size = new System.Drawing.Size(111, 27);
            this.deductTextBx.TabIndex = 14;
            this.deductTextBx.Visible = false;
            // 
            // netPayTextBox
            // 
            this.netPayTextBox.Location = new System.Drawing.Point(162, 460);
            this.netPayTextBox.Name = "netPayTextBox";
            this.netPayTextBox.Size = new System.Drawing.Size(110, 27);
            this.netPayTextBox.TabIndex = 15;
            this.netPayTextBox.Visible = false;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonReset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReset.Location = new System.Drawing.Point(369, 284);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(101, 44);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // FirstAppForm
            // 
            this.AcceptButton = this.btn1Display;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(867, 498);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.netPayTextBox);
            this.Controls.Add(this.deductTextBx);
            this.Controls.Add(this.grossTextBox);
            this.Controls.Add(this.netPayLabel);
            this.Controls.Add(this.deductionLabel);
            this.Controls.Add(this.grossLabel);
            this.Controls.Add(this.dependentTextBox);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.dependentLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.labelDisplay);
            this.Controls.Add(this.btn1Close);
            this.Controls.Add(this.btn1Display);
            this.Controls.Add(this.name1TextBox);
            this.Controls.Add(this.labelName1);
            this.Controls.Add(this.label1);
            this.Name = "FirstAppForm";
            this.Text = "First Windows App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirstAppForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName1;
        private System.Windows.Forms.TextBox name1TextBox;
        private System.Windows.Forms.Button btDisplay;
        private System.Windows.Forms.Button bt1Close;
        private System.Windows.Forms.Button bt1Display;
        private System.Windows.Forms.Button btn1Display;
        private System.Windows.Forms.Button btn1Close;
        private System.Windows.Forms.Label labelDisplay;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label dependentLabel;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.TextBox dependentTextBox;
        private System.Windows.Forms.Label grossLabel;
        private System.Windows.Forms.Label deductionLabel;
        private System.Windows.Forms.Label netPayLabel;
        private System.Windows.Forms.TextBox grossTextBox;
        private System.Windows.Forms.TextBox deductTextBx;
        private System.Windows.Forms.TextBox netPayTextBox;
        private System.Windows.Forms.Button buttonReset;
    }
}

