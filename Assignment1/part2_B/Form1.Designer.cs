namespace Assignment1P2B
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
            this.btnHW = new System.Windows.Forms.Button();
            this.txtHW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHW
            // 
            this.btnHW.Location = new System.Drawing.Point(304, 60);
            this.btnHW.Name = "btnHW";
            this.btnHW.Size = new System.Drawing.Size(181, 65);
            this.btnHW.TabIndex = 0;
            this.btnHW.Text = "Say Hello World";
            this.btnHW.UseVisualStyleBackColor = true;
            this.btnHW.Click += new System.EventHandler(this.btnHW_Click);
            // 
            // txtHW
            // 
            this.txtHW.Location = new System.Drawing.Point(342, 146);
            this.txtHW.Name = "txtHW";
            this.txtHW.Size = new System.Drawing.Size(210, 31);
            this.txtHW.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHW);
            this.Controls.Add(this.btnHW);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHW;
        private System.Windows.Forms.TextBox txtHW;
    }
}

