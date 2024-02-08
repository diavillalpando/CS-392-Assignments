namespace Book3._14
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
            this.inputBox = new System.Windows.Forms.GroupBox();
            this.outputBox = new System.Windows.Forms.GroupBox();
            this.instructionsLbl = new System.Windows.Forms.Label();
            this.inputALbl = new System.Windows.Forms.Label();
            this.inputATxtBox = new System.Windows.Forms.TextBox();
            this.inputBTxtBox = new System.Windows.Forms.TextBox();
            this.inputBLbl = new System.Windows.Forms.Label();
            this.inputCTxtBox = new System.Windows.Forms.TextBox();
            this.inputCLbl = new System.Windows.Forms.Label();
            this.outputCLbl = new System.Windows.Forms.Label();
            this.outputBLbl = new System.Windows.Forms.Label();
            this.outputALbl = new System.Windows.Forms.Label();
            this.outputA = new System.Windows.Forms.Label();
            this.outputB = new System.Windows.Forms.Label();
            this.outputC = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.totalOutput = new System.Windows.Forms.Label();
            this.totalOutputLbl = new System.Windows.Forms.Label();
            this.inputBox.SuspendLayout();
            this.outputBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Controls.Add(this.inputCTxtBox);
            this.inputBox.Controls.Add(this.inputCLbl);
            this.inputBox.Controls.Add(this.inputBTxtBox);
            this.inputBox.Controls.Add(this.inputBLbl);
            this.inputBox.Controls.Add(this.inputATxtBox);
            this.inputBox.Controls.Add(this.inputALbl);
            this.inputBox.Controls.Add(this.instructionsLbl);
            this.inputBox.Location = new System.Drawing.Point(53, 60);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(296, 260);
            this.inputBox.TabIndex = 0;
            this.inputBox.TabStop = false;
            this.inputBox.Text = "Tickets Sold";
            // 
            // outputBox
            // 
            this.outputBox.Controls.Add(this.totalOutput);
            this.outputBox.Controls.Add(this.totalOutputLbl);
            this.outputBox.Controls.Add(this.outputC);
            this.outputBox.Controls.Add(this.outputB);
            this.outputBox.Controls.Add(this.outputA);
            this.outputBox.Controls.Add(this.outputCLbl);
            this.outputBox.Controls.Add(this.outputALbl);
            this.outputBox.Controls.Add(this.outputBLbl);
            this.outputBox.Location = new System.Drawing.Point(409, 60);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(296, 260);
            this.outputBox.TabIndex = 1;
            this.outputBox.TabStop = false;
            this.outputBox.Text = "Revenue Generated";
            // 
            // instructionsLbl
            // 
            this.instructionsLbl.Location = new System.Drawing.Point(26, 40);
            this.instructionsLbl.Name = "instructionsLbl";
            this.instructionsLbl.Size = new System.Drawing.Size(264, 54);
            this.instructionsLbl.TabIndex = 0;
            this.instructionsLbl.Text = "Enter the number of tickets for each class of seats.";
            // 
            // inputALbl
            // 
            this.inputALbl.AutoSize = true;
            this.inputALbl.Location = new System.Drawing.Point(44, 117);
            this.inputALbl.Name = "inputALbl";
            this.inputALbl.Size = new System.Drawing.Size(86, 25);
            this.inputALbl.TabIndex = 1;
            this.inputALbl.Text = "Class A";
            // 
            // inputATxtBox
            // 
            this.inputATxtBox.Location = new System.Drawing.Point(150, 114);
            this.inputATxtBox.Name = "inputATxtBox";
            this.inputATxtBox.Size = new System.Drawing.Size(108, 31);
            this.inputATxtBox.TabIndex = 2;
            // 
            // inputBTxtBox
            // 
            this.inputBTxtBox.Location = new System.Drawing.Point(150, 151);
            this.inputBTxtBox.Name = "inputBTxtBox";
            this.inputBTxtBox.Size = new System.Drawing.Size(108, 31);
            this.inputBTxtBox.TabIndex = 4;
            // 
            // inputBLbl
            // 
            this.inputBLbl.AutoSize = true;
            this.inputBLbl.Location = new System.Drawing.Point(44, 154);
            this.inputBLbl.Name = "inputBLbl";
            this.inputBLbl.Size = new System.Drawing.Size(86, 25);
            this.inputBLbl.TabIndex = 3;
            this.inputBLbl.Text = "Class B";
            // 
            // inputCTxtBox
            // 
            this.inputCTxtBox.Location = new System.Drawing.Point(150, 188);
            this.inputCTxtBox.Name = "inputCTxtBox";
            this.inputCTxtBox.Size = new System.Drawing.Size(108, 31);
            this.inputCTxtBox.TabIndex = 6;
            // 
            // inputCLbl
            // 
            this.inputCLbl.AutoSize = true;
            this.inputCLbl.Location = new System.Drawing.Point(44, 191);
            this.inputCLbl.Name = "inputCLbl";
            this.inputCLbl.Size = new System.Drawing.Size(87, 25);
            this.inputCLbl.TabIndex = 5;
            this.inputCLbl.Text = "Class C";
            // 
            // outputCLbl
            // 
            this.outputCLbl.AutoSize = true;
            this.outputCLbl.Location = new System.Drawing.Point(41, 140);
            this.outputCLbl.Name = "outputCLbl";
            this.outputCLbl.Size = new System.Drawing.Size(87, 25);
            this.outputCLbl.TabIndex = 9;
            this.outputCLbl.Text = "Class C";
            // 
            // outputBLbl
            // 
            this.outputBLbl.AutoSize = true;
            this.outputBLbl.Location = new System.Drawing.Point(41, 103);
            this.outputBLbl.Name = "outputBLbl";
            this.outputBLbl.Size = new System.Drawing.Size(86, 25);
            this.outputBLbl.TabIndex = 8;
            this.outputBLbl.Text = "Class B";
            // 
            // outputALbl
            // 
            this.outputALbl.AutoSize = true;
            this.outputALbl.Location = new System.Drawing.Point(41, 66);
            this.outputALbl.Name = "outputALbl";
            this.outputALbl.Size = new System.Drawing.Size(86, 25);
            this.outputALbl.TabIndex = 7;
            this.outputALbl.Text = "Class A";
            // 
            // outputA
            // 
            this.outputA.BackColor = System.Drawing.SystemColors.Window;
            this.outputA.Location = new System.Drawing.Point(142, 66);
            this.outputA.Name = "outputA";
            this.outputA.Size = new System.Drawing.Size(103, 28);
            this.outputA.TabIndex = 7;
            this.outputA.Text = "$0.0";
            this.outputA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputB
            // 
            this.outputB.BackColor = System.Drawing.SystemColors.Window;
            this.outputB.Location = new System.Drawing.Point(142, 106);
            this.outputB.Name = "outputB";
            this.outputB.Size = new System.Drawing.Size(103, 28);
            this.outputB.TabIndex = 10;
            this.outputB.Text = "$0.0";
            this.outputB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputC
            // 
            this.outputC.BackColor = System.Drawing.SystemColors.Window;
            this.outputC.Location = new System.Drawing.Point(142, 143);
            this.outputC.Name = "outputC";
            this.outputC.Size = new System.Drawing.Size(103, 28);
            this.outputC.TabIndex = 11;
            this.outputC.Text = "$0.0";
            this.outputC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(301, 338);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(157, 48);
            this.calculateBtn.TabIndex = 2;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(301, 392);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(157, 48);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.SystemColors.Window;
            this.totalOutput.Location = new System.Drawing.Point(142, 181);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(103, 28);
            this.totalOutput.TabIndex = 13;
            this.totalOutput.Text = "$0.0";
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalOutputLbl
            // 
            this.totalOutputLbl.AutoSize = true;
            this.totalOutputLbl.Location = new System.Drawing.Point(41, 178);
            this.totalOutputLbl.Name = "totalOutputLbl";
            this.totalOutputLbl.Size = new System.Drawing.Size(60, 25);
            this.totalOutputLbl.TabIndex = 12;
            this.totalOutputLbl.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.inputBox.ResumeLayout(false);
            this.inputBox.PerformLayout();
            this.outputBox.ResumeLayout(false);
            this.outputBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputBox;
        private System.Windows.Forms.TextBox inputATxtBox;
        private System.Windows.Forms.Label inputALbl;
        private System.Windows.Forms.Label instructionsLbl;
        private System.Windows.Forms.GroupBox outputBox;
        private System.Windows.Forms.TextBox inputCTxtBox;
        private System.Windows.Forms.Label inputCLbl;
        private System.Windows.Forms.TextBox inputBTxtBox;
        private System.Windows.Forms.Label inputBLbl;
        private System.Windows.Forms.Label outputA;
        private System.Windows.Forms.Label outputCLbl;
        private System.Windows.Forms.Label outputALbl;
        private System.Windows.Forms.Label outputBLbl;
        private System.Windows.Forms.Label outputC;
        private System.Windows.Forms.Label outputB;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label totalOutputLbl;
    }
}

