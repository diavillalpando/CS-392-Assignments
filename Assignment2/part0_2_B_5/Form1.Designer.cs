namespace part0_2_B_5
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
            this.tailsPicture = new System.Windows.Forms.PictureBox();
            this.headsPicture = new System.Windows.Forms.PictureBox();
            this.showHeadsBtn = new System.Windows.Forms.Button();
            this.showTailsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tailsPicture
            // 
            this.tailsPicture.BackgroundImage = global::part0_2_B_5.Properties.Resources.Tails1;
            this.tailsPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tailsPicture.Location = new System.Drawing.Point(87, 52);
            this.tailsPicture.Name = "tailsPicture";
            this.tailsPicture.Size = new System.Drawing.Size(342, 356);
            this.tailsPicture.TabIndex = 0;
            this.tailsPicture.TabStop = false;
            this.tailsPicture.Visible = false;
            // 
            // headsPicture
            // 
            this.headsPicture.BackgroundImage = global::part0_2_B_5.Properties.Resources.Heads1;
            this.headsPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.headsPicture.Location = new System.Drawing.Point(611, 52);
            this.headsPicture.Name = "headsPicture";
            this.headsPicture.Size = new System.Drawing.Size(342, 356);
            this.headsPicture.TabIndex = 1;
            this.headsPicture.TabStop = false;
            this.headsPicture.Visible = false;
            // 
            // showHeadsBtn
            // 
            this.showHeadsBtn.Location = new System.Drawing.Point(651, 490);
            this.showHeadsBtn.Name = "showHeadsBtn";
            this.showHeadsBtn.Size = new System.Drawing.Size(250, 104);
            this.showHeadsBtn.TabIndex = 2;
            this.showHeadsBtn.Text = "Show Heads";
            this.showHeadsBtn.UseVisualStyleBackColor = true;
            this.showHeadsBtn.Click += new System.EventHandler(this.headsPicture_Click);
            // 
            // showTailsBtn
            // 
            this.showTailsBtn.Location = new System.Drawing.Point(143, 490);
            this.showTailsBtn.Name = "showTailsBtn";
            this.showTailsBtn.Size = new System.Drawing.Size(250, 104);
            this.showTailsBtn.TabIndex = 3;
            this.showTailsBtn.Text = "Show Tails";
            this.showTailsBtn.UseVisualStyleBackColor = true;
            this.showTailsBtn.Click += new System.EventHandler(this.showTailsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 718);
            this.Controls.Add(this.showTailsBtn);
            this.Controls.Add(this.showHeadsBtn);
            this.Controls.Add(this.headsPicture);
            this.Controls.Add(this.tailsPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tailsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox tailsPicture;
        private System.Windows.Forms.PictureBox headsPicture;
        private System.Windows.Forms.Button showHeadsBtn;
        private System.Windows.Forms.Button showTailsBtn;
    }
}

