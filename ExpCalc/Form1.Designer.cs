namespace ExpCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtCurrLvl = new System.Windows.Forms.TextBox();
            this.txtExpSample = new System.Windows.Forms.TextBox();
            this.txtTotalExp = new System.Windows.Forms.TextBox();
            this.txtTargetLvl = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(223, 111);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(150, 79);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate!";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCurrLvl
            // 
            this.txtCurrLvl.Location = new System.Drawing.Point(92, 12);
            this.txtCurrLvl.Name = "txtCurrLvl";
            this.txtCurrLvl.Size = new System.Drawing.Size(79, 20);
            this.txtCurrLvl.TabIndex = 1;
            // 
            // txtExpSample
            // 
            this.txtExpSample.Location = new System.Drawing.Point(15, 170);
            this.txtExpSample.Name = "txtExpSample";
            this.txtExpSample.Size = new System.Drawing.Size(129, 20);
            this.txtExpSample.TabIndex = 2;
            // 
            // txtTotalExp
            // 
            this.txtTotalExp.Location = new System.Drawing.Point(15, 111);
            this.txtTotalExp.Name = "txtTotalExp";
            this.txtTotalExp.Size = new System.Drawing.Size(156, 20);
            this.txtTotalExp.TabIndex = 3;
            // 
            // txtTargetLvl
            // 
            this.txtTargetLvl.Location = new System.Drawing.Point(92, 51);
            this.txtTargetLvl.Name = "txtTargetLvl";
            this.txtTargetLvl.Size = new System.Drawing.Size(79, 20);
            this.txtTargetLvl.TabIndex = 4;
            // 
            // txtOutput
            // 
            this.txtOutput.Enabled = false;
            this.txtOutput.Location = new System.Drawing.Point(223, 12);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(361, 81);
            this.txtOutput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Target level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Current level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total current experiance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Current @epm (exp per minute):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::ExpCalc.Properties.Resources.ez;
            this.ClientSize = new System.Drawing.Size(603, 225);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtTargetLvl);
            this.Controls.Add(this.txtTotalExp);
            this.Controls.Add(this.txtExpSample);
            this.Controls.Add(this.txtCurrLvl);
            this.Controls.Add(this.btnCalc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MapleStory v62 Calculator - Zeretius";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtCurrLvl;
        private System.Windows.Forms.TextBox txtExpSample;
        private System.Windows.Forms.TextBox txtTotalExp;
        private System.Windows.Forms.TextBox txtTargetLvl;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

