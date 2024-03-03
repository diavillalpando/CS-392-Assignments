namespace Prob7._10
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
            this.money_inp = new System.Windows.Forms.TextBox();
            this.Amt_label = new System.Windows.Forms.Label();
            this.spin_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.won_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            this.SuspendLayout();
            // 
            // money_inp
            // 
            this.money_inp.Location = new System.Drawing.Point(367, 222);
            this.money_inp.Name = "money_inp";
            this.money_inp.Size = new System.Drawing.Size(100, 20);
            this.money_inp.TabIndex = 0;
            // 
            // Amt_label
            // 
            this.Amt_label.AutoSize = true;
            this.Amt_label.Location = new System.Drawing.Point(262, 225);
            this.Amt_label.Name = "Amt_label";
            this.Amt_label.Size = new System.Drawing.Size(99, 13);
            this.Amt_label.TabIndex = 1;
            this.Amt_label.Text = "Amount Inserted($):";
            this.Amt_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // spin_btn
            // 
            this.spin_btn.Location = new System.Drawing.Point(305, 289);
            this.spin_btn.Name = "spin_btn";
            this.spin_btn.Size = new System.Drawing.Size(75, 23);
            this.spin_btn.TabIndex = 2;
            this.spin_btn.Text = "Spin";
            this.spin_btn.UseVisualStyleBackColor = true;
            this.spin_btn.Click += new System.EventHandler(this.spin_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(392, 289);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(329, 138);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(100, 50);
            this.pic2.TabIndex = 4;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(202, 138);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(100, 50);
            this.pic1.TabIndex = 5;
            this.pic1.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(456, 138);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(100, 50);
            this.pic3.TabIndex = 6;
            this.pic3.TabStop = false;
            // 
            // won_label
            // 
            this.won_label.AutoSize = true;
            this.won_label.Location = new System.Drawing.Point(325, 257);
            this.won_label.Name = "won_label";
            this.won_label.Size = new System.Drawing.Size(0, 13);
            this.won_label.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.won_label);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.spin_btn);
            this.Controls.Add(this.Amt_label);
            this.Controls.Add(this.money_inp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox money_inp;
        private System.Windows.Forms.Label Amt_label;
        private System.Windows.Forms.Button spin_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.Label won_label;
    }
}

