namespace WinFormsPractice1
{
    partial class frmChkRadioGroup
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
            this.chkConfirmationRules = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rdMedium = new System.Windows.Forms.RadioButton();
            this.rdThick = new System.Windows.Forms.RadioButton();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.rdLarge = new System.Windows.Forms.RadioButton();
            this.rdThin = new System.Windows.Forms.RadioButton();
            this.btnShowChoice = new System.Windows.Forms.Button();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.btnHideGrBox = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkConfirmationRules
            // 
            this.chkConfirmationRules.AutoSize = true;
            this.chkConfirmationRules.Location = new System.Drawing.Point(56, 68);
            this.chkConfirmationRules.Name = "chkConfirmationRules";
            this.chkConfirmationRules.Size = new System.Drawing.Size(146, 17);
            this.chkConfirmationRules.TabIndex = 0;
            this.chkConfirmationRules.Text = "Do you Agree about rules";
            this.chkConfirmationRules.UseVisualStyleBackColor = true;
            this.chkConfirmationRules.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(78, 97);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 40);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rdMedium
            // 
            this.rdMedium.AutoSize = true;
            this.rdMedium.Location = new System.Drawing.Point(20, 55);
            this.rdMedium.Name = "rdMedium";
            this.rdMedium.Size = new System.Drawing.Size(62, 17);
            this.rdMedium.TabIndex = 3;
            this.rdMedium.TabStop = true;
            this.rdMedium.Text = "Medium";
            this.rdMedium.UseVisualStyleBackColor = true;
            this.rdMedium.CheckedChanged += new System.EventHandler(this.rdMedium_CheckedChanged);
            // 
            // rdThick
            // 
            this.rdThick.AutoSize = true;
            this.rdThick.Location = new System.Drawing.Point(21, 71);
            this.rdThick.Name = "rdThick";
            this.rdThick.Size = new System.Drawing.Size(52, 17);
            this.rdThick.TabIndex = 6;
            this.rdThick.TabStop = true;
            this.rdThick.Text = "Thick";
            this.rdThick.UseVisualStyleBackColor = true;
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Location = new System.Drawing.Point(20, 22);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(50, 17);
            this.rdSmall.TabIndex = 2;
            this.rdSmall.TabStop = true;
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            this.rdSmall.CheckedChanged += new System.EventHandler(this.rdSmall_CheckedChanged);
            // 
            // rdLarge
            // 
            this.rdLarge.AutoSize = true;
            this.rdLarge.Location = new System.Drawing.Point(20, 86);
            this.rdLarge.Name = "rdLarge";
            this.rdLarge.Size = new System.Drawing.Size(52, 17);
            this.rdLarge.TabIndex = 4;
            this.rdLarge.TabStop = true;
            this.rdLarge.Text = "Large";
            this.rdLarge.UseVisualStyleBackColor = true;
            this.rdLarge.CheckedChanged += new System.EventHandler(this.rdLarge_CheckedChanged);
            // 
            // rdThin
            // 
            this.rdThin.AutoSize = true;
            this.rdThin.Location = new System.Drawing.Point(21, 35);
            this.rdThin.Name = "rdThin";
            this.rdThin.Size = new System.Drawing.Size(46, 17);
            this.rdThin.TabIndex = 5;
            this.rdThin.TabStop = true;
            this.rdThin.Text = "Thin";
            this.rdThin.UseVisualStyleBackColor = true;
            // 
            // btnShowChoice
            // 
            this.btnShowChoice.Enabled = false;
            this.btnShowChoice.Location = new System.Drawing.Point(276, 143);
            this.btnShowChoice.Name = "btnShowChoice";
            this.btnShowChoice.Size = new System.Drawing.Size(94, 40);
            this.btnShowChoice.TabIndex = 7;
            this.btnShowChoice.Text = "Your Choice";
            this.btnShowChoice.UseVisualStyleBackColor = true;
            this.btnShowChoice.Click += new System.EventHandler(this.btnShowChoice_Click);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rdSmall);
            this.gbSize.Controls.Add(this.rdLarge);
            this.gbSize.Controls.Add(this.rdMedium);
            this.gbSize.Location = new System.Drawing.Point(256, 12);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(200, 125);
            this.gbSize.TabIndex = 8;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Pizza Size";
            // 
            // gbCrust
            // 
            this.gbCrust.Controls.Add(this.rdThin);
            this.gbCrust.Controls.Add(this.rdThick);
            this.gbCrust.Location = new System.Drawing.Point(489, 12);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(200, 114);
            this.gbCrust.TabIndex = 9;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust";
            // 
            // btnHideGrBox
            // 
            this.btnHideGrBox.Location = new System.Drawing.Point(549, 143);
            this.btnHideGrBox.Name = "btnHideGrBox";
            this.btnHideGrBox.Size = new System.Drawing.Size(94, 40);
            this.btnHideGrBox.TabIndex = 10;
            this.btnHideGrBox.Text = "Hide Crust";
            this.btnHideGrBox.UseVisualStyleBackColor = true;
            this.btnHideGrBox.Click += new System.EventHandler(this.btnHideGrBox_Click);
            // 
            // frmChkRadioGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 240);
            this.Controls.Add(this.btnHideGrBox);
            this.Controls.Add(this.btnShowChoice);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkConfirmationRules);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbSize);
            this.Name = "frmChkRadioGroup";
            this.Text = "frmChkRadioGroup";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkConfirmationRules;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rdMedium;
        private System.Windows.Forms.RadioButton rdThick;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.RadioButton rdLarge;
        private System.Windows.Forms.RadioButton rdThin;
        private System.Windows.Forms.Button btnShowChoice;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.Button btnHideGrBox;
    }
}