
namespace Q2
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
            this.LengthTxtBx = new System.Windows.Forms.TextBox();
            this.LengthLbl = new System.Windows.Forms.Label();
            this.WidthTxtBx = new System.Windows.Forms.TextBox();
            this.WidthLbl = new System.Windows.Forms.Label();
            this.FloorSelectionGPBox = new System.Windows.Forms.GroupBox();
            this.LaminateRdBtn = new System.Windows.Forms.RadioButton();
            this.CarpetRdBtn = new System.Windows.Forms.RadioButton();
            this.HardwoodRdBtn = new System.Windows.Forms.RadioButton();
            this.HardwoodLst = new System.Windows.Forms.ListBox();
            this.PriceCalcBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FinalTxtBx = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.HardwoodChooseBtn = new System.Windows.Forms.Button();
            this.FloorSelectionGPBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LengthTxtBx
            // 
            this.LengthTxtBx.Location = new System.Drawing.Point(157, 70);
            this.LengthTxtBx.Name = "LengthTxtBx";
            this.LengthTxtBx.Size = new System.Drawing.Size(178, 27);
            this.LengthTxtBx.TabIndex = 0;
            this.LengthTxtBx.TextChanged += new System.EventHandler(this.LengthTxtBx_TextChanged);
            // 
            // LengthLbl
            // 
            this.LengthLbl.AutoSize = true;
            this.LengthLbl.Location = new System.Drawing.Point(34, 70);
            this.LengthLbl.Name = "LengthLbl";
            this.LengthLbl.Size = new System.Drawing.Size(54, 20);
            this.LengthLbl.TabIndex = 1;
            this.LengthLbl.Text = "Length";
            // 
            // WidthTxtBx
            // 
            this.WidthTxtBx.Location = new System.Drawing.Point(158, 136);
            this.WidthTxtBx.Name = "WidthTxtBx";
            this.WidthTxtBx.Size = new System.Drawing.Size(176, 27);
            this.WidthTxtBx.TabIndex = 2;
            this.WidthTxtBx.TextChanged += new System.EventHandler(this.WidthTxtBx_TextChanged);
            // 
            // WidthLbl
            // 
            this.WidthLbl.AutoSize = true;
            this.WidthLbl.Location = new System.Drawing.Point(28, 138);
            this.WidthLbl.Name = "WidthLbl";
            this.WidthLbl.Size = new System.Drawing.Size(49, 20);
            this.WidthLbl.TabIndex = 3;
            this.WidthLbl.Text = "Width";
            // 
            // FloorSelectionGPBox
            // 
            this.FloorSelectionGPBox.Controls.Add(this.LaminateRdBtn);
            this.FloorSelectionGPBox.Controls.Add(this.CarpetRdBtn);
            this.FloorSelectionGPBox.Controls.Add(this.HardwoodRdBtn);
            this.FloorSelectionGPBox.Location = new System.Drawing.Point(492, 58);
            this.FloorSelectionGPBox.Name = "FloorSelectionGPBox";
            this.FloorSelectionGPBox.Size = new System.Drawing.Size(179, 148);
            this.FloorSelectionGPBox.TabIndex = 4;
            this.FloorSelectionGPBox.TabStop = false;
            this.FloorSelectionGPBox.Text = "Floor Selection";
            // 
            // LaminateRdBtn
            // 
            this.LaminateRdBtn.AutoSize = true;
            this.LaminateRdBtn.Location = new System.Drawing.Point(18, 105);
            this.LaminateRdBtn.Name = "LaminateRdBtn";
            this.LaminateRdBtn.Size = new System.Drawing.Size(91, 24);
            this.LaminateRdBtn.TabIndex = 2;
            this.LaminateRdBtn.TabStop = true;
            this.LaminateRdBtn.Text = "Laminate";
            this.LaminateRdBtn.UseVisualStyleBackColor = true;
            // 
            // CarpetRdBtn
            // 
            this.CarpetRdBtn.AutoSize = true;
            this.CarpetRdBtn.Location = new System.Drawing.Point(18, 66);
            this.CarpetRdBtn.Name = "CarpetRdBtn";
            this.CarpetRdBtn.Size = new System.Drawing.Size(74, 24);
            this.CarpetRdBtn.TabIndex = 1;
            this.CarpetRdBtn.TabStop = true;
            this.CarpetRdBtn.Text = "Carpet";
            this.CarpetRdBtn.UseVisualStyleBackColor = true;
            // 
            // HardwoodRdBtn
            // 
            this.HardwoodRdBtn.AutoSize = true;
            this.HardwoodRdBtn.Location = new System.Drawing.Point(18, 26);
            this.HardwoodRdBtn.Name = "HardwoodRdBtn";
            this.HardwoodRdBtn.Size = new System.Drawing.Size(101, 24);
            this.HardwoodRdBtn.TabIndex = 0;
            this.HardwoodRdBtn.TabStop = true;
            this.HardwoodRdBtn.Text = "Hardwood";
            this.HardwoodRdBtn.UseVisualStyleBackColor = true;
            // 
            // HardwoodLst
            // 
            this.HardwoodLst.FormattingEnabled = true;
            this.HardwoodLst.ItemHeight = 20;
            this.HardwoodLst.Items.AddRange(new object[] {
            "Oak $34.95",
            "Cherry $41.95",
            "Maple $35.23",
            "Walnut $54.21"});
            this.HardwoodLst.Location = new System.Drawing.Point(724, 84);
            this.HardwoodLst.Name = "HardwoodLst";
            this.HardwoodLst.Size = new System.Drawing.Size(132, 64);
            this.HardwoodLst.TabIndex = 5;
            // 
            // PriceCalcBtn
            // 
            this.PriceCalcBtn.Location = new System.Drawing.Point(63, 299);
            this.PriceCalcBtn.Name = "PriceCalcBtn";
            this.PriceCalcBtn.Size = new System.Drawing.Size(163, 31);
            this.PriceCalcBtn.TabIndex = 6;
            this.PriceCalcBtn.Text = "Price Calculator";
            this.PriceCalcBtn.UseVisualStyleBackColor = true;
            this.PriceCalcBtn.Click += new System.EventHandler(this.PriceCalcBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(274, 299);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(156, 29);
            this.ClearBtn.TabIndex = 7;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Final Cost";
            // 
            // FinalTxtBx
            // 
            this.FinalTxtBx.Location = new System.Drawing.Point(265, 421);
            this.FinalTxtBx.Name = "FinalTxtBx";
            this.FinalTxtBx.Size = new System.Drawing.Size(591, 27);
            this.FinalTxtBx.TabIndex = 9;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(528, 223);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(82, 29);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // HardwoodChooseBtn
            // 
            this.HardwoodChooseBtn.Location = new System.Drawing.Point(740, 185);
            this.HardwoodChooseBtn.Name = "HardwoodChooseBtn";
            this.HardwoodChooseBtn.Size = new System.Drawing.Size(95, 29);
            this.HardwoodChooseBtn.TabIndex = 11;
            this.HardwoodChooseBtn.Text = "Choose";
            this.HardwoodChooseBtn.UseVisualStyleBackColor = true;
            this.HardwoodChooseBtn.Click += new System.EventHandler(this.HardwoodChooseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 707);
            this.Controls.Add(this.HardwoodChooseBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.FinalTxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.PriceCalcBtn);
            this.Controls.Add(this.HardwoodLst);
            this.Controls.Add(this.FloorSelectionGPBox);
            this.Controls.Add(this.WidthLbl);
            this.Controls.Add(this.WidthTxtBx);
            this.Controls.Add(this.LengthLbl);
            this.Controls.Add(this.LengthTxtBx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FloorSelectionGPBox.ResumeLayout(false);
            this.FloorSelectionGPBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox HardwoodLst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FinalTxtBx;
        private System.Windows.Forms.Label Length;
        private System.Windows.Forms.Label WidthLbl;
        private System.Windows.Forms.Label LengthLbl;
        private System.Windows.Forms.TextBox LengthTxtBx;
        private System.Windows.Forms.TextBox WidthTxtBx;
        private System.Windows.Forms.GroupBox FloorSelectionGPBox;
        private System.Windows.Forms.RadioButton HardwoodRdBtn;
        private System.Windows.Forms.RadioButton CarpetRdBtn;
        private System.Windows.Forms.RadioButton LaminateRdBtn;
        private System.Windows.Forms.Button PriceCalcBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button HardwoodChooseBtn;
    }
}

