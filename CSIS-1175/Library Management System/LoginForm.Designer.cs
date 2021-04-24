
namespace Library_Management_System
{
    partial class LoginForm
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
            this.dreamclgLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.logintbtn = new System.Windows.Forms.Button();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.showpassCheckBx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dreamclgLabel
            // 
            this.dreamclgLabel.AutoSize = true;
            this.dreamclgLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dreamclgLabel.Location = new System.Drawing.Point(369, 19);
            this.dreamclgLabel.Name = "dreamclgLabel";
            this.dreamclgLabel.Size = new System.Drawing.Size(376, 46);
            this.dreamclgLabel.TabIndex = 0;
            this.dreamclgLabel.Text = "Dream College Library";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLabel.Location = new System.Drawing.Point(357, 262);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(103, 28);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Username:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passLabel.Location = new System.Drawing.Point(363, 332);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(97, 28);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Password:";
            // 
            // logintbtn
            // 
            this.logintbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.logintbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logintbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.logintbtn.Location = new System.Drawing.Point(465, 450);
            this.logintbtn.Name = "logintbtn";
            this.logintbtn.Size = new System.Drawing.Size(175, 37);
            this.logintbtn.TabIndex = 5;
            this.logintbtn.Text = "Login";
            this.logintbtn.UseVisualStyleBackColor = false;
            this.logintbtn.Click += new System.EventHandler(this.Logintbtn_Click);
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(486, 266);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(235, 27);
            this.userTextBox.TabIndex = 6;
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(484, 333);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(237, 27);
            this.passTextBox.TabIndex = 7;
            // 
            // showpassCheckBx
            // 
            this.showpassCheckBx.AutoSize = true;
            this.showpassCheckBx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showpassCheckBx.Location = new System.Drawing.Point(484, 390);
            this.showpassCheckBx.Name = "showpassCheckBx";
            this.showpassCheckBx.Size = new System.Drawing.Size(132, 24);
            this.showpassCheckBx.TabIndex = 8;
            this.showpassCheckBx.Text = "Show Password";
            this.showpassCheckBx.UseVisualStyleBackColor = true;
            this.showpassCheckBx.CheckedChanged += new System.EventHandler(this.showpassCheckBx_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.logintbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1139, 789);
            this.Controls.Add(this.showpassCheckBx);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.logintbtn);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.dreamclgLabel);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dreamclgLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.RichTextBox userTxtBx;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.RichTextBox passTxtBx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button logintbn;
        private System.Windows.Forms.Button logintbtn;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.CheckBox showpassCheckBx;
    }
}

