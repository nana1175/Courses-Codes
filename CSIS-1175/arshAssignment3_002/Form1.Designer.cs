
namespace arshAssignment3_002
{
    partial class mainForm
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
            this.appTitle = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.amountTxtBx = new System.Windows.Forms.TextBox();
            this.depostBtn = new System.Windows.Forms.Button();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.crtAcctBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.balanceLblTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // appTitle
            // 
            this.appTitle.AutoSize = true;
            this.appTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.appTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appTitle.Location = new System.Drawing.Point(271, 23);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(210, 32);
            this.appTitle.TabIndex = 0;
            this.appTitle.Text = "Bank Account App";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(164, 97);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 25);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountLabel.Location = new System.Drawing.Point(147, 152);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(79, 25);
            this.amountLabel.TabIndex = 7;
            this.amountLabel.Text = "Amount";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balanceLabel.Location = new System.Drawing.Point(149, 217);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(78, 25);
            this.balanceLabel.TabIndex = 8;
            this.balanceLabel.Text = "Balance";
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Location = new System.Drawing.Point(271, 98);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(242, 27);
            this.nameTxtBx.TabIndex = 0;
            // 
            // amountTxtBx
            // 
            this.amountTxtBx.Location = new System.Drawing.Point(271, 150);
            this.amountTxtBx.Name = "amountTxtBx";
            this.amountTxtBx.Size = new System.Drawing.Size(242, 27);
            this.amountTxtBx.TabIndex = 1;
            // 
            // depostBtn
            // 
            this.depostBtn.Location = new System.Drawing.Point(123, 301);
            this.depostBtn.Name = "depostBtn";
            this.depostBtn.Size = new System.Drawing.Size(102, 34);
            this.depostBtn.TabIndex = 2;
            this.depostBtn.Text = "Deposit";
            this.depostBtn.UseVisualStyleBackColor = true;
            this.depostBtn.Click += new System.EventHandler(this.depostBtn_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.Location = new System.Drawing.Point(253, 301);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(129, 34);
            this.withdrawBtn.TabIndex = 3;
            this.withdrawBtn.Text = "Withdraw";
            this.withdrawBtn.UseVisualStyleBackColor = true;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // crtAcctBtn
            // 
            this.crtAcctBtn.Location = new System.Drawing.Point(414, 300);
            this.crtAcctBtn.Name = "crtAcctBtn";
            this.crtAcctBtn.Size = new System.Drawing.Size(121, 35);
            this.crtAcctBtn.TabIndex = 4;
            this.crtAcctBtn.Text = "Create Account";
            this.crtAcctBtn.UseVisualStyleBackColor = true;
            this.crtAcctBtn.Click += new System.EventHandler(this.crtAcctBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(566, 301);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(97, 33);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // balanceLblTxt
            // 
            this.balanceLblTxt.AutoSize = true;
            this.balanceLblTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balanceLblTxt.Location = new System.Drawing.Point(271, 220);
            this.balanceLblTxt.Name = "balanceLblTxt";
            this.balanceLblTxt.Size = new System.Drawing.Size(0, 23);
            this.balanceLblTxt.TabIndex = 10;
            // 
            // mainForm
            // 
            this.AcceptButton = this.crtAcctBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.balanceLblTxt);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.crtAcctBtn);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.depostBtn);
            this.Controls.Add(this.amountTxtBx);
            this.Controls.Add(this.nameTxtBx);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.appTitle);
            this.Name = "mainForm";
            this.Text = " Bank Account Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.TextBox amountTxtBx;
        private System.Windows.Forms.Button depostBtn;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.Button crtAcctBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label balanceLblTxt;
    }
}

