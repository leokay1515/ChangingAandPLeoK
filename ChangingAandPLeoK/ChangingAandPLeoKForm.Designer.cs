namespace ChangingAandPLeoK
{
    partial class ChangingAandPLeoKForm
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAreaIs = new System.Windows.Forms.Label();
            this.lblPerimeterIs = new System.Windows.Forms.Label();
            this.lblAreaAnswer = new System.Windows.Forms.Label();
            this.lblPerimeterAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(49, 34);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(74, 24);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(49, 92);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(63, 24);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(170, 38);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 2;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(170, 96);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(307, 62);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(108, 35);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAreaIs
            // 
            this.lblAreaIs.AutoSize = true;
            this.lblAreaIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaIs.Location = new System.Drawing.Point(49, 156);
            this.lblAreaIs.Name = "lblAreaIs";
            this.lblAreaIs.Size = new System.Drawing.Size(124, 24);
            this.lblAreaIs.TabIndex = 5;
            this.lblAreaIs.Text = "The Area Is:";
            // 
            // lblPerimeterIs
            // 
            this.lblPerimeterIs.AutoSize = true;
            this.lblPerimeterIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeterIs.Location = new System.Drawing.Point(49, 213);
            this.lblPerimeterIs.Name = "lblPerimeterIs";
            this.lblPerimeterIs.Size = new System.Drawing.Size(170, 24);
            this.lblPerimeterIs.TabIndex = 6;
            this.lblPerimeterIs.Text = "The Perimeter Is:";
            // 
            // lblAreaAnswer
            // 
            this.lblAreaAnswer.AutoSize = true;
            this.lblAreaAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaAnswer.Location = new System.Drawing.Point(206, 156);
            this.lblAreaAnswer.Name = "lblAreaAnswer";
            this.lblAreaAnswer.Size = new System.Drawing.Size(0, 24);
            this.lblAreaAnswer.TabIndex = 7;
            // 
            // lblPerimeterAnswer
            // 
            this.lblPerimeterAnswer.AutoSize = true;
            this.lblPerimeterAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeterAnswer.Location = new System.Drawing.Point(246, 213);
            this.lblPerimeterAnswer.Name = "lblPerimeterAnswer";
            this.lblPerimeterAnswer.Size = new System.Drawing.Size(0, 24);
            this.lblPerimeterAnswer.TabIndex = 8;
            // 
            // ChangingAandPLeoKForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 261);
            this.Controls.Add(this.lblPerimeterAnswer);
            this.Controls.Add(this.lblAreaAnswer);
            this.Controls.Add(this.lblPerimeterIs);
            this.Controls.Add(this.lblAreaIs);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Name = "ChangingAandPLeoKForm";
            this.Text = "Changing Area and Perimeter by Leo Kay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAreaIs;
        private System.Windows.Forms.Label lblPerimeterIs;
        private System.Windows.Forms.Label lblAreaAnswer;
        private System.Windows.Forms.Label lblPerimeterAnswer;
    }
}

