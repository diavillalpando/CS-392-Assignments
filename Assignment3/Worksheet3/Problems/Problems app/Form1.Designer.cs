namespace Problems_app
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblExpression = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.RadioButton();
            this.grpAddOrSub = new System.Windows.Forms.GroupBox();
            this.btnSubtract = new System.Windows.Forms.RadioButton();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblProblem = new System.Windows.Forms.Label();
            this.lblAttempt = new System.Windows.Forms.Label();
            this.lblProblemNum = new System.Windows.Forms.Label();
            this.lblAttempNum = new System.Windows.Forms.Label();
            this.grpAddOrSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(234, 88);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(35, 38);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "2";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(234, 159);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(35, 38);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "2";
            // 
            // lblExpression
            // 
            this.lblExpression.AutoSize = true;
            this.lblExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpression.Location = new System.Drawing.Point(167, 159);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(36, 38);
            this.lblExpression.TabIndex = 2;
            this.lblExpression.Text = "+";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Checked = true;
            this.btnAdd.Location = new System.Drawing.Point(0, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 20);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.TabStop = true;
            this.btnAdd.Text = "Addition";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpAddOrSub
            // 
            this.grpAddOrSub.Controls.Add(this.btnSubtract);
            this.grpAddOrSub.Controls.Add(this.btnAdd);
            this.grpAddOrSub.Location = new System.Drawing.Point(137, 228);
            this.grpAddOrSub.Name = "grpAddOrSub";
            this.grpAddOrSub.Size = new System.Drawing.Size(297, 108);
            this.grpAddOrSub.TabIndex = 4;
            this.grpAddOrSub.TabStop = false;
            this.grpAddOrSub.Text = "Addition or Subtraction";
            this.grpAddOrSub.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSubtract
            // 
            this.btnSubtract.AutoSize = true;
            this.btnSubtract.Location = new System.Drawing.Point(166, 42);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(95, 20);
            this.btnSubtract.TabIndex = 5;
            this.btnSubtract.TabStop = true;
            this.btnSubtract.Text = "Subtraction";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.CheckedChanged += new System.EventHandler(this.btnSubtract_CheckedChanged);
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // txtAns
            // 
            this.txtAns.Location = new System.Drawing.Point(156, 355);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(100, 22);
            this.txtAns.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(275, 354);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblProblem
            // 
            this.lblProblem.AutoSize = true;
            this.lblProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblem.Location = new System.Drawing.Point(26, 24);
            this.lblProblem.Name = "lblProblem";
            this.lblProblem.Size = new System.Drawing.Size(95, 25);
            this.lblProblem.TabIndex = 7;
            this.lblProblem.Text = "Problem :";
            this.lblProblem.Click += new System.EventHandler(this.lblProblem_Click);
            // 
            // lblAttempt
            // 
            this.lblAttempt.AutoSize = true;
            this.lblAttempt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttempt.Location = new System.Drawing.Point(264, 24);
            this.lblAttempt.Name = "lblAttempt";
            this.lblAttempt.Size = new System.Drawing.Size(90, 25);
            this.lblAttempt.TabIndex = 8;
            this.lblAttempt.Text = "Attempt :";
            // 
            // lblProblemNum
            // 
            this.lblProblemNum.AutoSize = true;
            this.lblProblemNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemNum.Location = new System.Drawing.Point(127, 24);
            this.lblProblemNum.Name = "lblProblemNum";
            this.lblProblemNum.Size = new System.Drawing.Size(23, 25);
            this.lblProblemNum.TabIndex = 9;
            this.lblProblemNum.Text = "1";
            // 
            // lblAttempNum
            // 
            this.lblAttempNum.AutoSize = true;
            this.lblAttempNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttempNum.Location = new System.Drawing.Point(375, 24);
            this.lblAttempNum.Name = "lblAttempNum";
            this.lblAttempNum.Size = new System.Drawing.Size(23, 25);
            this.lblAttempNum.TabIndex = 10;
            this.lblAttempNum.Text = "1";
            this.lblAttempNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAttempNum);
            this.Controls.Add(this.lblProblemNum);
            this.Controls.Add(this.lblAttempt);
            this.Controls.Add(this.lblProblem);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.grpAddOrSub);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAddOrSub.ResumeLayout(false);
            this.grpAddOrSub.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.RadioButton btnAdd;
        private System.Windows.Forms.GroupBox grpAddOrSub;
        private System.Windows.Forms.RadioButton btnSubtract;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblProblem;
        private System.Windows.Forms.Label lblAttempt;
        private System.Windows.Forms.Label lblProblemNum;
        private System.Windows.Forms.Label lblAttempNum;
    }
}

