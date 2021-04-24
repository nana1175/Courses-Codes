
namespace Library_Management_System
{
    partial class Admin
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
            this.searchBookBtn = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchBookBtn
            // 
            this.searchBookBtn.BackColor = System.Drawing.Color.Blue;
            this.searchBookBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBookBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.searchBookBtn.Location = new System.Drawing.Point(36, 158);
            this.searchBookBtn.Name = "searchBookBtn";
            this.searchBookBtn.Size = new System.Drawing.Size(146, 37);
            this.searchBookBtn.TabIndex = 0;
            this.searchBookBtn.Text = "Search Book";
            this.searchBookBtn.UseVisualStyleBackColor = false;
            this.searchBookBtn.Click += new System.EventHandler(this.SearchBookBtn_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userLabel.Location = new System.Drawing.Point(406, 24);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(325, 54);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "User Dashboard";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1139, 791);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.searchBookBtn);
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button searchBookBtn;
    }
}