
namespace Q1
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
            this.BagsLst = new System.Windows.Forms.ListBox();
            this.QuantityTxtBx = new System.Windows.Forms.TextBox();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BagsLst
            // 
            this.BagsLst.FormattingEnabled = true;
            this.BagsLst.ItemHeight = 20;
            this.BagsLst.Items.AddRange(new object[] {
            "beaded",
            "fringed",
            "full decorative",
            "leather",
            "pirate design",
            "plain"});
            this.BagsLst.Location = new System.Drawing.Point(112, 78);
            this.BagsLst.Name = "BagsLst";
            this.BagsLst.Size = new System.Drawing.Size(133, 104);
            this.BagsLst.Sorted = true;
            this.BagsLst.TabIndex = 0;
            this.BagsLst.SelectedIndexChanged += new System.EventHandler(this.BagsLst_SelectedIndexChanged);
            // 
            // QuantityTxtBx
            // 
            this.QuantityTxtBx.Location = new System.Drawing.Point(531, 110);
            this.QuantityTxtBx.Name = "QuantityTxtBx";
            this.QuantityTxtBx.Size = new System.Drawing.Size(196, 27);
            this.QuantityTxtBx.TabIndex = 1;
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.Location = new System.Drawing.Point(438, 117);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(65, 20);
            this.QuantityLbl.TabIndex = 2;
            this.QuantityLbl.Text = "Quantity";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(114, 245);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(131, 28);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 735);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.QuantityLbl);
            this.Controls.Add(this.QuantityTxtBx);
            this.Controls.Add(this.BagsLst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BagsLst;
        private System.Windows.Forms.TextBox QuantityTxtBx;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.Button ClearBtn;
    }
}

