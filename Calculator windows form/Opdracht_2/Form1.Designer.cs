namespace Opdracht_2
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
            this.btnClean = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(468, 344);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(138, 34);
            this.btnClean.TabIndex = 19;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(274, 344);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(138, 34);
            this.btnRun.TabIndex = 18;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(261, 276);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(392, 34);
            this.lblOutput.TabIndex = 17;
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(268, 234);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(386, 22);
            this.txtNum2.TabIndex = 16;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // txtOperator
            // 
            this.txtOperator.Location = new System.Drawing.Point(268, 199);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(386, 22);
            this.txtOperator.TabIndex = 15;
            this.txtOperator.TextChanged += new System.EventHandler(this.txtLastname_TextChanged);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(267, 163);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(386, 22);
            this.txtNum1.TabIndex = 14;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtFirstname_TextChanged);
            // 
            // lblNum2
            // 
            this.lblNum2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(73, 231);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(184, 25);
            this.lblNum2.TabIndex = 13;
            this.lblNum2.Text = "Enter a number";
            this.lblNum2.Click += new System.EventHandler(this.lblAge_Click);
            // 
            // lblOperator
            // 
            this.lblOperator.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.Location = new System.Drawing.Point(76, 196);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(181, 25);
            this.lblOperator.TabIndex = 12;
            this.lblOperator.Text = "Operator (+, -, *, /)";
            this.lblOperator.Click += new System.EventHandler(this.lblFam_Click);
            // 
            // lblNum1
            // 
            this.lblNum1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(77, 162);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(180, 25);
            this.lblNum1.TabIndex = 11;
            this.lblNum1.Text = "Enter a number";
            this.lblNum1.Click += new System.EventHandler(this.lblNick_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(269, 73);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(385, 61);
            this.lblWelcome.TabIndex = 10;
            this.lblWelcome.Text = "Calculator";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtOperator);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblWelcome;
    }
}

