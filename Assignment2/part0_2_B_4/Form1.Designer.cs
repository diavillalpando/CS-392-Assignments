namespace part0_2_B_4
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
            this.saySetupBtn = new System.Windows.Forms.Button();
            this.sayPunchBtn = new System.Windows.Forms.Button();
            this.jokeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saySetupBtn
            // 
            this.saySetupBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saySetupBtn.AutoSize = true;
            this.saySetupBtn.Location = new System.Drawing.Point(175, 54);
            this.saySetupBtn.Name = "saySetupBtn";
            this.saySetupBtn.Size = new System.Drawing.Size(130, 35);
            this.saySetupBtn.TabIndex = 0;
            this.saySetupBtn.Text = "Setup";
            this.saySetupBtn.UseVisualStyleBackColor = true;
            this.saySetupBtn.Click += new System.EventHandler(this.SaySetupBtn_Click);
            // 
            // sayPunchBtn
            // 
            this.sayPunchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sayPunchBtn.AutoSize = true;
            this.sayPunchBtn.Location = new System.Drawing.Point(311, 54);
            this.sayPunchBtn.Name = "sayPunchBtn";
            this.sayPunchBtn.Size = new System.Drawing.Size(130, 35);
            this.sayPunchBtn.TabIndex = 1;
            this.sayPunchBtn.Text = "Punch Line";
            this.sayPunchBtn.UseVisualStyleBackColor = true;
            this.sayPunchBtn.Click += new System.EventHandler(this.sayPunchBtn_Click);
            // 
            // jokeLabel
            // 
            this.jokeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jokeLabel.Location = new System.Drawing.Point(62, 150);
            this.jokeLabel.Name = "jokeLabel";
            this.jokeLabel.Size = new System.Drawing.Size(492, 124);
            this.jokeLabel.TabIndex = 2;
            this.jokeLabel.Text = "...";
            this.jokeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 324);
            this.Controls.Add(this.jokeLabel);
            this.Controls.Add(this.sayPunchBtn);
            this.Controls.Add(this.saySetupBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saySetupBtn;
        private System.Windows.Forms.Button sayPunchBtn;
        private System.Windows.Forms.Label jokeLabel;
    }
}

