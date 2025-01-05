namespace MyFirstUserCOntrolProject
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
            this.btnCalculateSum2 = new System.Windows.Forms.Button();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.btnShowForm2 = new System.Windows.Forms.Button();
            this.crtlSimpleCalc1 = new MyFirstUserCOntrolProject.crtlSimpleCalc();
            this.SuspendLayout();
            // 
            // btnCalculateSum2
            // 
            this.btnCalculateSum2.Location = new System.Drawing.Point(514, 83);
            this.btnCalculateSum2.Name = "btnCalculateSum2";
            this.btnCalculateSum2.Size = new System.Drawing.Size(98, 32);
            this.btnCalculateSum2.TabIndex = 1;
            this.btnCalculateSum2.Text = "Calculate Sum 2";
            this.btnCalculateSum2.UseVisualStyleBackColor = true;
            this.btnCalculateSum2.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBox3
            // 
            this.txtBox3.Location = new System.Drawing.Point(469, 45);
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(100, 20);
            this.txtBox3.TabIndex = 2;
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult2.Location = new System.Drawing.Point(614, 43);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(45, 20);
            this.lblResult2.TabIndex = 3;
            this.lblResult2.Text = "????";
            // 
            // btnShowForm2
            // 
            this.btnShowForm2.Location = new System.Drawing.Point(310, 151);
            this.btnShowForm2.Name = "btnShowForm2";
            this.btnShowForm2.Size = new System.Drawing.Size(98, 32);
            this.btnShowForm2.TabIndex = 4;
            this.btnShowForm2.Text = "Show Form 2";
            this.btnShowForm2.UseVisualStyleBackColor = true;
            this.btnShowForm2.Click += new System.EventHandler(this.btnShowForm2_Click);
            // 
            // crtlSimpleCalc1
            // 
            this.crtlSimpleCalc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crtlSimpleCalc1.Location = new System.Drawing.Point(13, 25);
            this.crtlSimpleCalc1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.crtlSimpleCalc1.Name = "crtlSimpleCalc1";
            this.crtlSimpleCalc1.Size = new System.Drawing.Size(368, 118);
            this.crtlSimpleCalc1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 208);
            this.Controls.Add(this.btnShowForm2);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.btnCalculateSum2);
            this.Controls.Add(this.crtlSimpleCalc1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private crtlSimpleCalc crtlSimpleCalc1;
        private System.Windows.Forms.Button btnCalculateSum2;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Button btnShowForm2;
    }
}

