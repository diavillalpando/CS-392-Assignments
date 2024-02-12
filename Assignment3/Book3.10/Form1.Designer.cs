namespace Book3._10
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
            this.applePicture = new System.Windows.Forms.PictureBox();
            this.bananaPicture = new System.Windows.Forms.PictureBox();
            this.pearPicture = new System.Windows.Forms.PictureBox();
            this.orangePicture = new System.Windows.Forms.PictureBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.outputLbl = new System.Windows.Forms.Label();
            this.totalTitleLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.applePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bananaPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pearPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // applePicture
            // 
            this.applePicture.Image = global::Book3._10.Properties.Resources.ApplePrice;
            this.applePicture.Location = new System.Drawing.Point(22, 54);
            this.applePicture.Name = "applePicture";
            this.applePicture.Size = new System.Drawing.Size(241, 294);
            this.applePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.applePicture.TabIndex = 0;
            this.applePicture.TabStop = false;
            this.applePicture.Click += new System.EventHandler(this.applePicture_Click);
            // 
            // bananaPicture
            // 
            this.bananaPicture.Image = global::Book3._10.Properties.Resources.BananaPrice;
            this.bananaPicture.Location = new System.Drawing.Point(305, 54);
            this.bananaPicture.Name = "bananaPicture";
            this.bananaPicture.Size = new System.Drawing.Size(241, 294);
            this.bananaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bananaPicture.TabIndex = 1;
            this.bananaPicture.TabStop = false;
            this.bananaPicture.Click += new System.EventHandler(this.bananaPicture_Click);
            // 
            // pearPicture
            // 
            this.pearPicture.Image = global::Book3._10.Properties.Resources.PearPrice;
            this.pearPicture.Location = new System.Drawing.Point(305, 369);
            this.pearPicture.Name = "pearPicture";
            this.pearPicture.Size = new System.Drawing.Size(241, 294);
            this.pearPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pearPicture.TabIndex = 2;
            this.pearPicture.TabStop = false;
            this.pearPicture.Click += new System.EventHandler(this.pearPicture_Click);
            // 
            // orangePicture
            // 
            this.orangePicture.Image = global::Book3._10.Properties.Resources.OrangePrice;
            this.orangePicture.Location = new System.Drawing.Point(22, 369);
            this.orangePicture.Name = "orangePicture";
            this.orangePicture.Size = new System.Drawing.Size(241, 294);
            this.orangePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.orangePicture.TabIndex = 2;
            this.orangePicture.TabStop = false;
            this.orangePicture.Click += new System.EventHandler(this.orangePicture_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(609, 586);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(148, 64);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // outputLbl
            // 
            this.outputLbl.BackColor = System.Drawing.SystemColors.Info;
            this.outputLbl.Location = new System.Drawing.Point(629, 88);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(148, 40);
            this.outputLbl.TabIndex = 4;
            this.outputLbl.Text = "$0.0";
            this.outputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalTitleLbl
            // 
            this.totalTitleLbl.AutoSize = true;
            this.totalTitleLbl.Location = new System.Drawing.Point(707, 54);
            this.totalTitleLbl.Name = "totalTitleLbl";
            this.totalTitleLbl.Size = new System.Drawing.Size(66, 25);
            this.totalTitleLbl.TabIndex = 5;
            this.totalTitleLbl.Text = "Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 756);
            this.Controls.Add(this.totalTitleLbl);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.orangePicture);
            this.Controls.Add(this.pearPicture);
            this.Controls.Add(this.bananaPicture);
            this.Controls.Add(this.applePicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.applePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bananaPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pearPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox applePicture;
        private System.Windows.Forms.PictureBox bananaPicture;
        private System.Windows.Forms.PictureBox pearPicture;
        private System.Windows.Forms.PictureBox orangePicture;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.Label totalTitleLbl;
    }
}

