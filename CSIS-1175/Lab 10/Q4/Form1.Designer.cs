
namespace Q4
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.MNoLbl = new System.Windows.Forms.Label();
            this.NameTxtBx = new System.Windows.Forms.TextBox();
            this.AddressTxtBx = new System.Windows.Forms.TextBox();
            this.MNoTxtBx = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.FinalRecordsTxtBx = new System.Windows.Forms.TextBox();
            this.FinalRecordsLbl = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(59, 61);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(76, 20);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Full Name";
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Location = new System.Drawing.Point(55, 133);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(62, 20);
            this.AddressLbl.TabIndex = 1;
            this.AddressLbl.Text = "Address";
            // 
            // MNoLbl
            // 
            this.MNoLbl.AutoSize = true;
            this.MNoLbl.Location = new System.Drawing.Point(55, 204);
            this.MNoLbl.Name = "MNoLbl";
            this.MNoLbl.Size = new System.Drawing.Size(46, 20);
            this.MNoLbl.TabIndex = 2;
            this.MNoLbl.Text = "M No";
            // 
            // NameTxtBx
            // 
            this.NameTxtBx.Location = new System.Drawing.Point(149, 54);
            this.NameTxtBx.Name = "NameTxtBx";
            this.NameTxtBx.Size = new System.Drawing.Size(388, 27);
            this.NameTxtBx.TabIndex = 3;
            // 
            // AddressTxtBx
            // 
            this.AddressTxtBx.Location = new System.Drawing.Point(149, 121);
            this.AddressTxtBx.Multiline = true;
            this.AddressTxtBx.Name = "AddressTxtBx";
            this.AddressTxtBx.Size = new System.Drawing.Size(389, 45);
            this.AddressTxtBx.TabIndex = 4;
            this.AddressTxtBx.TextChanged += new System.EventHandler(this.AddressTxtBx_TextChanged);
            // 
            // MNoTxtBx
            // 
            this.MNoTxtBx.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.MNoTxtBx.Location = new System.Drawing.Point(149, 197);
            this.MNoTxtBx.Name = "MNoTxtBx";
            this.MNoTxtBx.Size = new System.Drawing.Size(388, 27);
            this.MNoTxtBx.TabIndex = 5;
            this.MNoTxtBx.Text = "Please write in xxx-xxx-xxxx format\r\n";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(713, 61);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(114, 35);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Add Record";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ShowBtn
            // 
            this.ShowBtn.Location = new System.Drawing.Point(711, 146);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(116, 34);
            this.ShowBtn.TabIndex = 7;
            this.ShowBtn.Text = "Show Records";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // FinalRecordsTxtBx
            // 
            this.FinalRecordsTxtBx.Location = new System.Drawing.Point(120, 357);
            this.FinalRecordsTxtBx.Multiline = true;
            this.FinalRecordsTxtBx.Name = "FinalRecordsTxtBx";
            this.FinalRecordsTxtBx.Size = new System.Drawing.Size(726, 293);
            this.FinalRecordsTxtBx.TabIndex = 8;
            // 
            // FinalRecordsLbl
            // 
            this.FinalRecordsLbl.AutoSize = true;
            this.FinalRecordsLbl.Location = new System.Drawing.Point(405, 309);
            this.FinalRecordsLbl.Name = "FinalRecordsLbl";
            this.FinalRecordsLbl.Size = new System.Drawing.Size(84, 20);
            this.FinalRecordsLbl.TabIndex = 9;
            this.FinalRecordsLbl.Text = "All Records";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(721, 236);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(105, 31);
            this.ClearBtn.TabIndex = 10;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 675);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.FinalRecordsLbl);
            this.Controls.Add(this.FinalRecordsTxtBx);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.MNoTxtBx);
            this.Controls.Add(this.AddressTxtBx);
            this.Controls.Add(this.NameTxtBx);
            this.Controls.Add(this.MNoLbl);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.NameLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label FinalRecordsLbl;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.Label MNoLbl;
        private System.Windows.Forms.TextBox NameTxtBx;
        private System.Windows.Forms.TextBox AddressTxtBx;
        private System.Windows.Forms.TextBox MNoTxtBx;
        private System.Windows.Forms.TextBox FinalRecordsTxtBx;
        private System.Windows.Forms.Button ClearBtn;
    }
}

