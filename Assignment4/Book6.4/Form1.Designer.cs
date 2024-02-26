namespace Book6._4
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
            this.oilGroup = new System.Windows.Forms.GroupBox();
            this.oilChangeCheck = new System.Windows.Forms.CheckBox();
            this.lubeJobCheck = new System.Windows.Forms.CheckBox();
            this.flushesGroup = new System.Windows.Forms.GroupBox();
            this.transFlushCheck = new System.Windows.Forms.CheckBox();
            this.radFlushCheck = new System.Windows.Forms.CheckBox();
            this.miscGroup = new System.Windows.Forms.GroupBox();
            this.replaceMufflerCheck = new System.Windows.Forms.CheckBox();
            this.inspectionCheck = new System.Windows.Forms.CheckBox();
            this.tireRotateCheck = new System.Windows.Forms.CheckBox();
            this.partsLaborGroup = new System.Windows.Forms.GroupBox();
            this.partsTxtBox = new System.Windows.Forms.TextBox();
            this.laborTxtBox = new System.Windows.Forms.TextBox();
            this.partsLbl = new System.Windows.Forms.Label();
            this.laborLbl = new System.Windows.Forms.Label();
            this.summaryGroup = new System.Windows.Forms.GroupBox();
            this.serviceOutput = new System.Windows.Forms.Label();
            this.serviceDesc = new System.Windows.Forms.Label();
            this.partsDesc = new System.Windows.Forms.Label();
            this.partsOutput = new System.Windows.Forms.Label();
            this.taxDesc = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalDesc = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.oilGroup.SuspendLayout();
            this.flushesGroup.SuspendLayout();
            this.miscGroup.SuspendLayout();
            this.partsLaborGroup.SuspendLayout();
            this.summaryGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilGroup
            // 
            this.oilGroup.Controls.Add(this.lubeJobCheck);
            this.oilGroup.Controls.Add(this.oilChangeCheck);
            this.oilGroup.Location = new System.Drawing.Point(77, 50);
            this.oilGroup.Name = "oilGroup";
            this.oilGroup.Size = new System.Drawing.Size(260, 170);
            this.oilGroup.TabIndex = 0;
            this.oilGroup.TabStop = false;
            this.oilGroup.Text = "Oil and Lube";
            // 
            // oilChangeCheck
            // 
            this.oilChangeCheck.AutoSize = true;
            this.oilChangeCheck.Location = new System.Drawing.Point(24, 50);
            this.oilChangeCheck.Name = "oilChangeCheck";
            this.oilChangeCheck.Size = new System.Drawing.Size(207, 29);
            this.oilChangeCheck.TabIndex = 0;
            this.oilChangeCheck.Text = "Oil Change ($50)";
            this.oilChangeCheck.UseVisualStyleBackColor = true;
            // 
            // lubeJobCheck
            // 
            this.lubeJobCheck.AutoSize = true;
            this.lubeJobCheck.Location = new System.Drawing.Point(24, 99);
            this.lubeJobCheck.Name = "lubeJobCheck";
            this.lubeJobCheck.Size = new System.Drawing.Size(189, 29);
            this.lubeJobCheck.TabIndex = 1;
            this.lubeJobCheck.Text = "Lube Job ($40)";
            this.lubeJobCheck.UseVisualStyleBackColor = true;
            // 
            // flushesGroup
            // 
            this.flushesGroup.Controls.Add(this.transFlushCheck);
            this.flushesGroup.Controls.Add(this.radFlushCheck);
            this.flushesGroup.Location = new System.Drawing.Point(361, 50);
            this.flushesGroup.Name = "flushesGroup";
            this.flushesGroup.Size = new System.Drawing.Size(338, 170);
            this.flushesGroup.TabIndex = 2;
            this.flushesGroup.TabStop = false;
            this.flushesGroup.Text = "Flushes";
            // 
            // transFlushCheck
            // 
            this.transFlushCheck.AutoSize = true;
            this.transFlushCheck.Location = new System.Drawing.Point(24, 99);
            this.transFlushCheck.Name = "transFlushCheck";
            this.transFlushCheck.Size = new System.Drawing.Size(299, 29);
            this.transFlushCheck.TabIndex = 1;
            this.transFlushCheck.Text = "Transmission Flush ($120)";
            this.transFlushCheck.UseVisualStyleBackColor = true;
            // 
            // radFlushCheck
            // 
            this.radFlushCheck.AutoSize = true;
            this.radFlushCheck.Location = new System.Drawing.Point(24, 50);
            this.radFlushCheck.Name = "radFlushCheck";
            this.radFlushCheck.Size = new System.Drawing.Size(252, 29);
            this.radFlushCheck.TabIndex = 0;
            this.radFlushCheck.Text = "Radiator Flush ($100)";
            this.radFlushCheck.UseVisualStyleBackColor = true;
            // 
            // miscGroup
            // 
            this.miscGroup.Controls.Add(this.tireRotateCheck);
            this.miscGroup.Controls.Add(this.replaceMufflerCheck);
            this.miscGroup.Controls.Add(this.inspectionCheck);
            this.miscGroup.Location = new System.Drawing.Point(77, 244);
            this.miscGroup.Name = "miscGroup";
            this.miscGroup.Size = new System.Drawing.Size(296, 210);
            this.miscGroup.TabIndex = 3;
            this.miscGroup.TabStop = false;
            this.miscGroup.Text = "Misc.";
            // 
            // replaceMufflerCheck
            // 
            this.replaceMufflerCheck.AutoSize = true;
            this.replaceMufflerCheck.Location = new System.Drawing.Point(24, 100);
            this.replaceMufflerCheck.Name = "replaceMufflerCheck";
            this.replaceMufflerCheck.Size = new System.Drawing.Size(263, 29);
            this.replaceMufflerCheck.TabIndex = 1;
            this.replaceMufflerCheck.Text = "Replace Muffler ($150)";
            this.replaceMufflerCheck.UseVisualStyleBackColor = true;
            // 
            // inspectionCheck
            // 
            this.inspectionCheck.AutoSize = true;
            this.inspectionCheck.Location = new System.Drawing.Point(24, 50);
            this.inspectionCheck.Name = "inspectionCheck";
            this.inspectionCheck.Size = new System.Drawing.Size(198, 29);
            this.inspectionCheck.TabIndex = 0;
            this.inspectionCheck.Text = "Inspection ($35)";
            this.inspectionCheck.UseVisualStyleBackColor = true;
            // 
            // tireRotateCheck
            // 
            this.tireRotateCheck.AutoSize = true;
            this.tireRotateCheck.Location = new System.Drawing.Point(24, 150);
            this.tireRotateCheck.Name = "tireRotateCheck";
            this.tireRotateCheck.Size = new System.Drawing.Size(223, 29);
            this.tireRotateCheck.TabIndex = 2;
            this.tireRotateCheck.Text = "Tire Rotation ($25)";
            this.tireRotateCheck.UseVisualStyleBackColor = true;
            // 
            // partsLaborGroup
            // 
            this.partsLaborGroup.Controls.Add(this.laborLbl);
            this.partsLaborGroup.Controls.Add(this.partsLbl);
            this.partsLaborGroup.Controls.Add(this.laborTxtBox);
            this.partsLaborGroup.Controls.Add(this.partsTxtBox);
            this.partsLaborGroup.Location = new System.Drawing.Point(397, 244);
            this.partsLaborGroup.Name = "partsLaborGroup";
            this.partsLaborGroup.Size = new System.Drawing.Size(302, 210);
            this.partsLaborGroup.TabIndex = 4;
            this.partsLaborGroup.TabStop = false;
            this.partsLaborGroup.Text = "Parts and Labor";
            // 
            // partsTxtBox
            // 
            this.partsTxtBox.Location = new System.Drawing.Point(170, 80);
            this.partsTxtBox.Name = "partsTxtBox";
            this.partsTxtBox.Size = new System.Drawing.Size(102, 31);
            this.partsTxtBox.TabIndex = 0;
            // 
            // laborTxtBox
            // 
            this.laborTxtBox.Location = new System.Drawing.Point(170, 128);
            this.laborTxtBox.Name = "laborTxtBox";
            this.laborTxtBox.Size = new System.Drawing.Size(102, 31);
            this.laborTxtBox.TabIndex = 1;
            // 
            // partsLbl
            // 
            this.partsLbl.AutoSize = true;
            this.partsLbl.Location = new System.Drawing.Point(94, 83);
            this.partsLbl.Name = "partsLbl";
            this.partsLbl.Size = new System.Drawing.Size(68, 25);
            this.partsLbl.TabIndex = 2;
            this.partsLbl.Text = "Parts:";
            this.partsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // laborLbl
            // 
            this.laborLbl.AutoSize = true;
            this.laborLbl.Location = new System.Drawing.Point(36, 128);
            this.laborLbl.Name = "laborLbl";
            this.laborLbl.Size = new System.Drawing.Size(126, 25);
            this.laborLbl.TabIndex = 3;
            this.laborLbl.Text = "Labor (Hrs):";
            this.laborLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // summaryGroup
            // 
            this.summaryGroup.Controls.Add(this.clearBtn);
            this.summaryGroup.Controls.Add(this.calculateBtn);
            this.summaryGroup.Controls.Add(this.totalDesc);
            this.summaryGroup.Controls.Add(this.totalOutput);
            this.summaryGroup.Controls.Add(this.taxDesc);
            this.summaryGroup.Controls.Add(this.taxOutput);
            this.summaryGroup.Controls.Add(this.partsDesc);
            this.summaryGroup.Controls.Add(this.partsOutput);
            this.summaryGroup.Controls.Add(this.serviceDesc);
            this.summaryGroup.Controls.Add(this.serviceOutput);
            this.summaryGroup.Location = new System.Drawing.Point(79, 484);
            this.summaryGroup.Name = "summaryGroup";
            this.summaryGroup.Size = new System.Drawing.Size(619, 260);
            this.summaryGroup.TabIndex = 5;
            this.summaryGroup.TabStop = false;
            this.summaryGroup.Text = "Summary";
            // 
            // serviceOutput
            // 
            this.serviceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serviceOutput.Location = new System.Drawing.Point(294, 38);
            this.serviceOutput.Name = "serviceOutput";
            this.serviceOutput.Size = new System.Drawing.Size(186, 38);
            this.serviceOutput.TabIndex = 0;
            this.serviceOutput.Text = "$0.0";
            this.serviceOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serviceDesc
            // 
            this.serviceDesc.AutoSize = true;
            this.serviceDesc.Location = new System.Drawing.Point(101, 45);
            this.serviceDesc.Name = "serviceDesc";
            this.serviceDesc.Size = new System.Drawing.Size(193, 25);
            this.serviceDesc.TabIndex = 1;
            this.serviceDesc.Text = "Service and Labor:";
            // 
            // partsDesc
            // 
            this.partsDesc.AutoSize = true;
            this.partsDesc.Location = new System.Drawing.Point(226, 102);
            this.partsDesc.Name = "partsDesc";
            this.partsDesc.Size = new System.Drawing.Size(68, 25);
            this.partsDesc.TabIndex = 3;
            this.partsDesc.Text = "Parts:";
            // 
            // partsOutput
            // 
            this.partsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partsOutput.Location = new System.Drawing.Point(294, 95);
            this.partsOutput.Name = "partsOutput";
            this.partsOutput.Size = new System.Drawing.Size(186, 38);
            this.partsOutput.TabIndex = 2;
            this.partsOutput.Text = "$0.0";
            this.partsOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxDesc
            // 
            this.taxDesc.AutoSize = true;
            this.taxDesc.Location = new System.Drawing.Point(136, 158);
            this.taxDesc.Name = "taxDesc";
            this.taxDesc.Size = new System.Drawing.Size(158, 25);
            this.taxDesc.TabIndex = 5;
            this.taxDesc.Text = "Tax (On Parts):";
            // 
            // taxOutput
            // 
            this.taxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxOutput.Location = new System.Drawing.Point(294, 151);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(186, 38);
            this.taxOutput.TabIndex = 4;
            this.taxOutput.Text = "$0.0";
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalDesc
            // 
            this.totalDesc.AutoSize = true;
            this.totalDesc.Location = new System.Drawing.Point(174, 212);
            this.totalDesc.Name = "totalDesc";
            this.totalDesc.Size = new System.Drawing.Size(120, 25);
            this.totalDesc.TabIndex = 7;
            this.totalDesc.Text = "Total Fees:";
            // 
            // totalOutput
            // 
            this.totalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutput.Location = new System.Drawing.Point(294, 205);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(186, 38);
            this.totalOutput.TabIndex = 6;
            this.totalOutput.Text = "$0.0";
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(22, 114);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(118, 51);
            this.calculateBtn.TabIndex = 8;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(22, 171);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(118, 51);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 764);
            this.Controls.Add(this.summaryGroup);
            this.Controls.Add(this.partsLaborGroup);
            this.Controls.Add(this.miscGroup);
            this.Controls.Add(this.flushesGroup);
            this.Controls.Add(this.oilGroup);
            this.Name = "Form1";
            this.Text = "Joe\'s Automotive";
            this.oilGroup.ResumeLayout(false);
            this.oilGroup.PerformLayout();
            this.flushesGroup.ResumeLayout(false);
            this.flushesGroup.PerformLayout();
            this.miscGroup.ResumeLayout(false);
            this.miscGroup.PerformLayout();
            this.partsLaborGroup.ResumeLayout(false);
            this.partsLaborGroup.PerformLayout();
            this.summaryGroup.ResumeLayout(false);
            this.summaryGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox oilGroup;
        private System.Windows.Forms.CheckBox lubeJobCheck;
        private System.Windows.Forms.CheckBox oilChangeCheck;
        private System.Windows.Forms.GroupBox flushesGroup;
        private System.Windows.Forms.CheckBox transFlushCheck;
        private System.Windows.Forms.CheckBox radFlushCheck;
        private System.Windows.Forms.GroupBox miscGroup;
        private System.Windows.Forms.CheckBox tireRotateCheck;
        private System.Windows.Forms.CheckBox replaceMufflerCheck;
        private System.Windows.Forms.CheckBox inspectionCheck;
        private System.Windows.Forms.GroupBox partsLaborGroup;
        private System.Windows.Forms.Label laborLbl;
        private System.Windows.Forms.Label partsLbl;
        private System.Windows.Forms.TextBox laborTxtBox;
        private System.Windows.Forms.TextBox partsTxtBox;
        private System.Windows.Forms.GroupBox summaryGroup;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label totalDesc;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label taxDesc;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label partsDesc;
        private System.Windows.Forms.Label partsOutput;
        private System.Windows.Forms.Label serviceDesc;
        private System.Windows.Forms.Label serviceOutput;
    }
}

