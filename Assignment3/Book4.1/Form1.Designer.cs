namespace Book4._1
{
    partial class FormBook4_1
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
            this.convertBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(51, 180);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(108, 54);
            this.convertBtn.TabIndex = 2;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(219, 180);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(108, 54);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.inputTextBox);
            this.groupBoxInput.Location = new System.Drawing.Point(31, 22);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(140, 132);
            this.groupBoxInput.TabIndex = 4;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Integer";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.outputLabel);
            this.groupBoxOutput.Location = new System.Drawing.Point(207, 22);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(140, 132);
            this.groupBoxOutput.TabIndex = 5;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Roman Numeral";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(20, 70);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 31);
            this.inputTextBox.TabIndex = 6;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(20, 70);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(100, 31);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.Text = "...";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormBook4_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(372, 302);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.convertBtn);
            this.Name = "FormBook4_1";
            this.Text = "Book 4.1";
            this.TopMost = true;
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label outputLabel;
    }
}

