namespace Book4._5
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.fromGroupBox = new System.Windows.Forms.GroupBox();
            this.toGroupBox = new System.Windows.Forms.GroupBox();
            this.InputListBox = new System.Windows.Forms.ListBox();
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.outputLbl = new System.Windows.Forms.Label();
            this.convertBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.fromGroupBox.SuspendLayout();
            this.toGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a distance to convert:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(397, 54);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(162, 31);
            this.inputTextBox.TabIndex = 1;
            // 
            // fromGroupBox
            // 
            this.fromGroupBox.Controls.Add(this.InputListBox);
            this.fromGroupBox.Location = new System.Drawing.Point(89, 124);
            this.fromGroupBox.Name = "fromGroupBox";
            this.fromGroupBox.Size = new System.Drawing.Size(238, 186);
            this.fromGroupBox.TabIndex = 2;
            this.fromGroupBox.TabStop = false;
            this.fromGroupBox.Text = "From";
            // 
            // toGroupBox
            // 
            this.toGroupBox.Controls.Add(this.OutputListBox);
            this.toGroupBox.Location = new System.Drawing.Point(421, 128);
            this.toGroupBox.Name = "toGroupBox";
            this.toGroupBox.Size = new System.Drawing.Size(238, 181);
            this.toGroupBox.TabIndex = 3;
            this.toGroupBox.TabStop = false;
            this.toGroupBox.Text = "To";
            // 
            // InputListBox
            // 
            this.InputListBox.FormattingEnabled = true;
            this.InputListBox.ItemHeight = 25;
            this.InputListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.InputListBox.Location = new System.Drawing.Point(34, 42);
            this.InputListBox.Name = "InputListBox";
            this.InputListBox.Size = new System.Drawing.Size(160, 104);
            this.InputListBox.TabIndex = 4;
            // 
            // OutputListBox
            // 
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.ItemHeight = 25;
            this.OutputListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.OutputListBox.Location = new System.Drawing.Point(37, 38);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(160, 104);
            this.OutputListBox.TabIndex = 5;
            // 
            // outputLbl
            // 
            this.outputLbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.outputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLbl.Location = new System.Drawing.Point(247, 330);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(266, 36);
            this.outputLbl.TabIndex = 4;
            this.outputLbl.Text = "0.0";
            this.outputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(247, 390);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(118, 48);
            this.convertBtn.TabIndex = 5;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(395, 390);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(118, 48);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.toGroupBox);
            this.Controls.Add(this.fromGroupBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Book4.5";
            this.TopMost = true;
            this.fromGroupBox.ResumeLayout(false);
            this.toGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.GroupBox fromGroupBox;
        private System.Windows.Forms.GroupBox toGroupBox;
        private System.Windows.Forms.ListBox InputListBox;
        private System.Windows.Forms.ListBox OutputListBox;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Button resetBtn;
    }
}

