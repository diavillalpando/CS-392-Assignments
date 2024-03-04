namespace Book6._4
{
    partial class Form1
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
            this.itemTxtBox = new System.Windows.Forms.TextBox();
            this.outputLbl = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.markupTxtBox = new System.Windows.Forms.TextBox();
            this.itemLbl = new System.Windows.Forms.Label();
            this.markupLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemTxtBox
            // 
            this.itemTxtBox.Location = new System.Drawing.Point(204, 150);
            this.itemTxtBox.Name = "itemTxtBox";
            this.itemTxtBox.Size = new System.Drawing.Size(140, 31);
            this.itemTxtBox.TabIndex = 0;
            // 
            // outputLbl
            // 
            this.outputLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLbl.Location = new System.Drawing.Point(267, 206);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(222, 60);
            this.outputLbl.TabIndex = 1;
            this.outputLbl.Text = "$0.0";
            this.outputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(311, 290);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(132, 44);
            this.calculateBtn.TabIndex = 2;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // markupTxtBox
            // 
            this.markupTxtBox.Location = new System.Drawing.Point(411, 150);
            this.markupTxtBox.Name = "markupTxtBox";
            this.markupTxtBox.Size = new System.Drawing.Size(140, 31);
            this.markupTxtBox.TabIndex = 3;
            // 
            // itemLbl
            // 
            this.itemLbl.AutoSize = true;
            this.itemLbl.Location = new System.Drawing.Point(199, 112);
            this.itemLbl.Name = "itemLbl";
            this.itemLbl.Size = new System.Drawing.Size(163, 25);
            this.itemLbl.TabIndex = 4;
            this.itemLbl.Text = "Wholesale Cost";
            // 
            // markupLbl
            // 
            this.markupLbl.AutoSize = true;
            this.markupLbl.Location = new System.Drawing.Point(406, 112);
            this.markupLbl.Name = "markupLbl";
            this.markupLbl.Size = new System.Drawing.Size(194, 25);
            this.markupLbl.TabIndex = 5;
            this.markupLbl.Text = "MarkupPercentage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.markupLbl);
            this.Controls.Add(this.itemLbl);
            this.Controls.Add(this.markupTxtBox);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.itemTxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemTxtBox;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox markupTxtBox;
        private System.Windows.Forms.Label itemLbl;
        private System.Windows.Forms.Label markupLbl;
    }
}

