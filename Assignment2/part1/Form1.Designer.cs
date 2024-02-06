namespace part1
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
            this.header = new System.Windows.Forms.Label();
            this.engHeightLabel = new System.Windows.Forms.Label();
            this.engWeightLabel = new System.Windows.Forms.Label();
            this.heightUnitsLabel1 = new System.Windows.Forms.Label();
            this.heightUnitsLabel2 = new System.Windows.Forms.Label();
            this.heightInput1 = new System.Windows.Forms.TextBox();
            this.heightInput2 = new System.Windows.Forms.TextBox();
            this.weightInput = new System.Windows.Forms.TextBox();
            this.weightUnitLabel = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.metricToggle = new System.Windows.Forms.LinkLabel();
            this.englishToggle = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.HotTrack;
            this.header.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.header.Location = new System.Drawing.Point(1, 2);
            this.header.Name = "header";
            this.header.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.header.Size = new System.Drawing.Size(798, 54);
            this.header.TabIndex = 0;
            this.header.Text = "Adult BMI Calculator";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // engHeightLabel
            // 
            this.engHeightLabel.AutoSize = true;
            this.engHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engHeightLabel.Location = new System.Drawing.Point(49, 112);
            this.engHeightLabel.Name = "engHeightLabel";
            this.engHeightLabel.Size = new System.Drawing.Size(114, 25);
            this.engHeightLabel.TabIndex = 1;
            this.engHeightLabel.Text = "1. Height:";
            // 
            // engWeightLabel
            // 
            this.engWeightLabel.AutoSize = true;
            this.engWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engWeightLabel.Location = new System.Drawing.Point(49, 203);
            this.engWeightLabel.Name = "engWeightLabel";
            this.engWeightLabel.Size = new System.Drawing.Size(119, 25);
            this.engWeightLabel.TabIndex = 2;
            this.engWeightLabel.Text = "2. Weight:";
            // 
            // heightUnitsLabel1
            // 
            this.heightUnitsLabel1.AutoSize = true;
            this.heightUnitsLabel1.Location = new System.Drawing.Point(135, 137);
            this.heightUnitsLabel1.Name = "heightUnitsLabel1";
            this.heightUnitsLabel1.Size = new System.Drawing.Size(55, 25);
            this.heightUnitsLabel1.TabIndex = 3;
            this.heightUnitsLabel1.Text = "Feet";
            // 
            // heightUnitsLabel2
            // 
            this.heightUnitsLabel2.AutoSize = true;
            this.heightUnitsLabel2.Location = new System.Drawing.Point(212, 137);
            this.heightUnitsLabel2.Name = "heightUnitsLabel2";
            this.heightUnitsLabel2.Size = new System.Drawing.Size(75, 25);
            this.heightUnitsLabel2.TabIndex = 4;
            this.heightUnitsLabel2.Text = "Inches";
            // 
            // heightInput1
            // 
            this.heightInput1.Location = new System.Drawing.Point(124, 165);
            this.heightInput1.Name = "heightInput1";
            this.heightInput1.Size = new System.Drawing.Size(76, 31);
            this.heightInput1.TabIndex = 5;
            // 
            // heightInput2
            // 
            this.heightInput2.Location = new System.Drawing.Point(211, 165);
            this.heightInput2.Name = "heightInput2";
            this.heightInput2.Size = new System.Drawing.Size(76, 31);
            this.heightInput2.TabIndex = 6;
            // 
            // weightInput
            // 
            this.weightInput.Location = new System.Drawing.Point(124, 272);
            this.weightInput.Name = "weightInput";
            this.weightInput.Size = new System.Drawing.Size(76, 31);
            this.weightInput.TabIndex = 8;
            // 
            // weightUnitLabel
            // 
            this.weightUnitLabel.AutoSize = true;
            this.weightUnitLabel.Location = new System.Drawing.Point(135, 244);
            this.weightUnitLabel.Name = "weightUnitLabel";
            this.weightUnitLabel.Size = new System.Drawing.Size(85, 25);
            this.weightUnitLabel.TabIndex = 7;
            this.weightUnitLabel.Text = "Pounds";
            // 
            // calculateBtn
            // 
            this.calculateBtn.AutoSize = true;
            this.calculateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calculateBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculateBtn.Location = new System.Drawing.Point(111, 334);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Padding = new System.Windows.Forms.Padding(2);
            this.calculateBtn.Size = new System.Drawing.Size(142, 45);
            this.calculateBtn.TabIndex = 9;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = false;
            this.calculateBtn.Click += new System.EventHandler(this.calculate);
            // 
            // metricToggle
            // 
            this.metricToggle.AutoSize = true;
            this.metricToggle.Location = new System.Drawing.Point(667, 70);
            this.metricToggle.Name = "metricToggle";
            this.metricToggle.Size = new System.Drawing.Size(71, 25);
            this.metricToggle.TabIndex = 10;
            this.metricToggle.TabStop = true;
            this.metricToggle.Text = "Metric";
            this.metricToggle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.englishToggle_LinkClicked);
            // 
            // englishToggle
            // 
            this.englishToggle.AutoSize = true;
            this.englishToggle.Enabled = false;
            this.englishToggle.Location = new System.Drawing.Point(579, 70);
            this.englishToggle.Name = "englishToggle";
            this.englishToggle.Size = new System.Drawing.Size(83, 25);
            this.englishToggle.TabIndex = 11;
            this.englishToggle.TabStop = true;
            this.englishToggle.Text = "English";
            this.englishToggle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.englishToggle_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.englishToggle);
            this.Controls.Add(this.metricToggle);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.weightInput);
            this.Controls.Add(this.weightUnitLabel);
            this.Controls.Add(this.heightInput2);
            this.Controls.Add(this.heightInput1);
            this.Controls.Add(this.heightUnitsLabel2);
            this.Controls.Add(this.heightUnitsLabel1);
            this.Controls.Add(this.engWeightLabel);
            this.Controls.Add(this.engHeightLabel);
            this.Controls.Add(this.header);
            this.Name = "Form1";
            this.Text = "Adult BMI Calculator";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label engHeightLabel;
        private System.Windows.Forms.Label engWeightLabel;
        private System.Windows.Forms.Label heightUnitsLabel1;
        private System.Windows.Forms.Label heightUnitsLabel2;
        private System.Windows.Forms.TextBox heightInput1;
        private System.Windows.Forms.TextBox heightInput2;
        private System.Windows.Forms.TextBox weightInput;
        private System.Windows.Forms.Label weightUnitLabel;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.LinkLabel metricToggle;
        private System.Windows.Forms.LinkLabel englishToggle;
    }
}

