namespace part0_2_B_1
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
            this.btnAutem = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnDescendit = new System.Windows.Forms.Button();
            this.labelTranslation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAutem
            // 
            this.btnAutem.AutoSize = true;
            this.btnAutem.Location = new System.Drawing.Point(187, 178);
            this.btnAutem.Name = "btnAutem";
            this.btnAutem.Size = new System.Drawing.Size(94, 35);
            this.btnAutem.TabIndex = 0;
            this.btnAutem.Text = "autem";
            this.btnAutem.UseVisualStyleBackColor = true;
            this.btnAutem.Click += new System.EventHandler(this.btnAutem_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.AutoSize = true;
            this.btnMedium.Location = new System.Drawing.Point(475, 178);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(97, 35);
            this.btnMedium.TabIndex = 1;
            this.btnMedium.Text = "medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnDescendit
            // 
            this.btnDescendit.AutoSize = true;
            this.btnDescendit.Location = new System.Drawing.Point(319, 178);
            this.btnDescendit.Name = "btnDescendit";
            this.btnDescendit.Size = new System.Drawing.Size(118, 35);
            this.btnDescendit.TabIndex = 2;
            this.btnDescendit.Text = "descendit";
            this.btnDescendit.UseVisualStyleBackColor = true;
            this.btnDescendit.Click += new System.EventHandler(this.btnDescendit_Click);
            // 
            // labelTranslation
            // 
            this.labelTranslation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTranslation.Location = new System.Drawing.Point(191, 244);
            this.labelTranslation.Name = "labelTranslation";
            this.labelTranslation.Size = new System.Drawing.Size(378, 30);
            this.labelTranslation.TabIndex = 3;
            this.labelTranslation.Text = "Translation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTranslation);
            this.Controls.Add(this.btnDescendit);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnAutem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAutem;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnDescendit;
        private System.Windows.Forms.Label labelTranslation;
    }
}

