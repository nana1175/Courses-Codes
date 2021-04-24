
namespace ArshFinal3131_002
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
            this.TitleLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.StuIdLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.NameTxtBx = new System.Windows.Forms.TextBox();
            this.StuIdTxtBx = new System.Windows.Forms.TextBox();
            this.EmailTxtBx = new System.Windows.Forms.TextBox();
            this.DormLst = new System.Windows.Forms.ListBox();
            this.MealLst = new System.Windows.Forms.ListBox();
            this.BreakfastChkBx = new System.Windows.Forms.CheckBox();
            this.StatusGrpBx = new System.Windows.Forms.GroupBox();
            this.UndergradRdBtn = new System.Windows.Forms.RadioButton();
            this.GradeRdBtn = new System.Windows.Forms.RadioButton();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.FinalTxtBx = new System.Windows.Forms.TextBox();
            this.StatusGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleLbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLbl.Location = new System.Drawing.Point(249, 23);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(518, 46);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Dorm and Meal Plan Calculator";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLbl.Location = new System.Drawing.Point(50, 99);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(104, 23);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "Enter Name";
            // 
            // StuIdLbl
            // 
            this.StuIdLbl.AutoSize = true;
            this.StuIdLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StuIdLbl.Location = new System.Drawing.Point(12, 154);
            this.StuIdLbl.Name = "StuIdLbl";
            this.StuIdLbl.Size = new System.Drawing.Size(142, 23);
            this.StuIdLbl.TabIndex = 2;
            this.StuIdLbl.Text = "Enter Student Id";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmailLbl.Location = new System.Drawing.Point(53, 202);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(101, 23);
            this.EmailLbl.TabIndex = 3;
            this.EmailLbl.Text = "Enter Email";
            // 
            // NameTxtBx
            // 
            this.NameTxtBx.Location = new System.Drawing.Point(181, 98);
            this.NameTxtBx.Name = "NameTxtBx";
            this.NameTxtBx.Size = new System.Drawing.Size(205, 27);
            this.NameTxtBx.TabIndex = 4;
            // 
            // StuIdTxtBx
            // 
            this.StuIdTxtBx.Location = new System.Drawing.Point(181, 153);
            this.StuIdTxtBx.Name = "StuIdTxtBx";
            this.StuIdTxtBx.Size = new System.Drawing.Size(205, 27);
            this.StuIdTxtBx.TabIndex = 5;
            // 
            // EmailTxtBx
            // 
            this.EmailTxtBx.Location = new System.Drawing.Point(181, 202);
            this.EmailTxtBx.Name = "EmailTxtBx";
            this.EmailTxtBx.Size = new System.Drawing.Size(205, 27);
            this.EmailTxtBx.TabIndex = 6;
            // 
            // DormLst
            // 
            this.DormLst.FormattingEnabled = true;
            this.DormLst.ItemHeight = 20;
            this.DormLst.Location = new System.Drawing.Point(454, 98);
            this.DormLst.Name = "DormLst";
            this.DormLst.Size = new System.Drawing.Size(164, 124);
            this.DormLst.TabIndex = 7;
            // 
            // MealLst
            // 
            this.MealLst.FormattingEnabled = true;
            this.MealLst.ItemHeight = 20;
            this.MealLst.Location = new System.Drawing.Point(695, 96);
            this.MealLst.Name = "MealLst";
            this.MealLst.Size = new System.Drawing.Size(154, 124);
            this.MealLst.TabIndex = 8;
            // 
            // BreakfastChkBx
            // 
            this.BreakfastChkBx.AutoSize = true;
            this.BreakfastChkBx.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BreakfastChkBx.Location = new System.Drawing.Point(271, 313);
            this.BreakfastChkBx.Name = "BreakfastChkBx";
            this.BreakfastChkBx.Size = new System.Drawing.Size(92, 24);
            this.BreakfastChkBx.TabIndex = 9;
            this.BreakfastChkBx.Text = "Breakfast";
            this.BreakfastChkBx.UseVisualStyleBackColor = false;
            // 
            // StatusGrpBx
            // 
            this.StatusGrpBx.BackColor = System.Drawing.Color.SlateBlue;
            this.StatusGrpBx.Controls.Add(this.UndergradRdBtn);
            this.StatusGrpBx.Controls.Add(this.GradeRdBtn);
            this.StatusGrpBx.Location = new System.Drawing.Point(457, 295);
            this.StatusGrpBx.Name = "StatusGrpBx";
            this.StatusGrpBx.Size = new System.Drawing.Size(147, 107);
            this.StatusGrpBx.TabIndex = 10;
            this.StatusGrpBx.TabStop = false;
            this.StatusGrpBx.Text = "Status";
            // 
            // UndergradRdBtn
            // 
            this.UndergradRdBtn.AutoSize = true;
            this.UndergradRdBtn.Location = new System.Drawing.Point(18, 68);
            this.UndergradRdBtn.Name = "UndergradRdBtn";
            this.UndergradRdBtn.Size = new System.Drawing.Size(101, 24);
            this.UndergradRdBtn.TabIndex = 1;
            this.UndergradRdBtn.TabStop = true;
            this.UndergradRdBtn.Text = "Undergrad";
            this.UndergradRdBtn.UseVisualStyleBackColor = true;
            // 
            // GradeRdBtn
            // 
            this.GradeRdBtn.AutoSize = true;
            this.GradeRdBtn.Location = new System.Drawing.Point(18, 26);
            this.GradeRdBtn.Name = "GradeRdBtn";
            this.GradeRdBtn.Size = new System.Drawing.Size(70, 24);
            this.GradeRdBtn.TabIndex = 0;
            this.GradeRdBtn.TabStop = true;
            this.GradeRdBtn.Text = "Grade";
            this.GradeRdBtn.UseVisualStyleBackColor = true;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateBtn.Location = new System.Drawing.Point(169, 491);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(138, 93);
            this.CreateBtn.TabIndex = 11;
            this.CreateBtn.Text = "Create Student Account";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetBtn.Location = new System.Drawing.Point(361, 491);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(119, 91);
            this.ResetBtn.TabIndex = 12;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseBtn.Location = new System.Drawing.Point(526, 490);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(125, 95);
            this.CloseBtn.TabIndex = 13;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // FinalTxtBx
            // 
            this.FinalTxtBx.Location = new System.Drawing.Point(695, 313);
            this.FinalTxtBx.Multiline = true;
            this.FinalTxtBx.Name = "FinalTxtBx";
            this.FinalTxtBx.Size = new System.Drawing.Size(218, 271);
            this.FinalTxtBx.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(957, 677);
            this.Controls.Add(this.FinalTxtBx);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.StatusGrpBx);
            this.Controls.Add(this.BreakfastChkBx);
            this.Controls.Add(this.MealLst);
            this.Controls.Add(this.DormLst);
            this.Controls.Add(this.EmailTxtBx);
            this.Controls.Add(this.StuIdTxtBx);
            this.Controls.Add(this.NameTxtBx);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.StuIdLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.TitleLbl);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Exam";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StatusGrpBx.ResumeLayout(false);
            this.StatusGrpBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label StuIdLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.TextBox NameTxtBx;
        private System.Windows.Forms.TextBox StuIdTxtBx;
        private System.Windows.Forms.TextBox EmailTxtBx;
        private System.Windows.Forms.ListBox DormLst;
        private System.Windows.Forms.ListBox MealLst;
        private System.Windows.Forms.CheckBox BreakfastChkBx;
        private System.Windows.Forms.GroupBox StatusGrpBx;
        private System.Windows.Forms.RadioButton GradeRdBtn;
        private System.Windows.Forms.RadioButton UndergradRdBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.TextBox FinalTxtBx;
    }
}

