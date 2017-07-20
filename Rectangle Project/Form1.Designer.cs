namespace Rectangle_Project
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
            this.txtBxWidth = new System.Windows.Forms.TextBox();
            this.txtBxLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxAreaInches = new System.Windows.Forms.TextBox();
            this.txtBxAreaFeet = new System.Windows.Forms.TextBox();
            this.txtBxAreaMeters = new System.Windows.Forms.TextBox();
            this.txtBxAreaCentimeters = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.butFindArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxWidth
            // 
            this.txtBxWidth.Location = new System.Drawing.Point(7, 85);
            this.txtBxWidth.Name = "txtBxWidth";
            this.txtBxWidth.Size = new System.Drawing.Size(114, 20);
            this.txtBxWidth.TabIndex = 0;
            this.txtBxWidth.TextChanged += new System.EventHandler(this.txtBxWidth_TextChanged);
            this.txtBxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxWidth_KeyPress);
            // 
            // txtBxLength
            // 
            this.txtBxLength.Location = new System.Drawing.Point(193, 28);
            this.txtBxLength.Name = "txtBxLength";
            this.txtBxLength.Size = new System.Drawing.Size(100, 20);
            this.txtBxLength.TabIndex = 1;
            this.txtBxLength.TextChanged += new System.EventHandler(this.txtBxLength_TextChanged);
            this.txtBxLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxLength_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(3, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width in Inches";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(177, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Length in Inches";
            // 
            // txtBxAreaInches
            // 
            this.txtBxAreaInches.Location = new System.Drawing.Point(76, 235);
            this.txtBxAreaInches.Name = "txtBxAreaInches";
            this.txtBxAreaInches.Size = new System.Drawing.Size(100, 20);
            this.txtBxAreaInches.TabIndex = 4;
            // 
            // txtBxAreaFeet
            // 
            this.txtBxAreaFeet.Location = new System.Drawing.Point(355, 235);
            this.txtBxAreaFeet.Name = "txtBxAreaFeet";
            this.txtBxAreaFeet.Size = new System.Drawing.Size(100, 20);
            this.txtBxAreaFeet.TabIndex = 5;
            // 
            // txtBxAreaMeters
            // 
            this.txtBxAreaMeters.Location = new System.Drawing.Point(76, 339);
            this.txtBxAreaMeters.Name = "txtBxAreaMeters";
            this.txtBxAreaMeters.Size = new System.Drawing.Size(100, 20);
            this.txtBxAreaMeters.TabIndex = 6;
            // 
            // txtBxAreaCentimeters
            // 
            this.txtBxAreaCentimeters.Location = new System.Drawing.Point(355, 339);
            this.txtBxAreaCentimeters.Name = "txtBxAreaCentimeters";
            this.txtBxAreaCentimeters.Size = new System.Drawing.Size(100, 20);
            this.txtBxAreaCentimeters.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(72, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Area in Inches";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(355, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Area in Feet ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(72, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Area in Meters ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(335, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Area in Cenimeters ";
            // 
            // butFindArea
            // 
            this.butFindArea.BackColor = System.Drawing.Color.Red;
            this.butFindArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFindArea.ForeColor = System.Drawing.Color.Green;
            this.butFindArea.Location = new System.Drawing.Point(400, 67);
            this.butFindArea.Name = "butFindArea";
            this.butFindArea.Size = new System.Drawing.Size(99, 52);
            this.butFindArea.TabIndex = 12;
            this.butFindArea.Text = "Find Area ";
            this.butFindArea.UseVisualStyleBackColor = false;
            this.butFindArea.Click += new System.EventHandler(this.butFindArea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(540, 392);
            this.Controls.Add(this.butFindArea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxAreaCentimeters);
            this.Controls.Add(this.txtBxAreaMeters);
            this.Controls.Add(this.txtBxAreaFeet);
            this.Controls.Add(this.txtBxAreaInches);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxLength);
            this.Controls.Add(this.txtBxWidth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxWidth;
        private System.Windows.Forms.TextBox txtBxLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxAreaInches;
        private System.Windows.Forms.TextBox txtBxAreaFeet;
        private System.Windows.Forms.TextBox txtBxAreaMeters;
        private System.Windows.Forms.TextBox txtBxAreaCentimeters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butFindArea;
    }
}

