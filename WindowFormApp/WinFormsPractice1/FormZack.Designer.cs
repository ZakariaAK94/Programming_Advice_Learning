namespace WinFormsPractice1
{
    partial class FormZack
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
            this.btnShowPart1 = new System.Windows.Forms.Button();
            this.btnShowForm1Dialog = new System.Windows.Forms.Button();
            this.btnShowMessageBox = new System.Windows.Forms.Button();
            this.btnCheckBoxRadioGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowPart1
            // 
            this.btnShowPart1.Location = new System.Drawing.Point(41, 59);
            this.btnShowPart1.Name = "btnShowPart1";
            this.btnShowPart1.Size = new System.Drawing.Size(123, 41);
            this.btnShowPart1.TabIndex = 0;
            this.btnShowPart1.Text = "Show Form";
            this.btnShowPart1.UseVisualStyleBackColor = true;
            this.btnShowPart1.Click += new System.EventHandler(this.btnShowPart1_Click);
            // 
            // btnShowForm1Dialog
            // 
            this.btnShowForm1Dialog.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnShowForm1Dialog.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnShowForm1Dialog.Location = new System.Drawing.Point(184, 59);
            this.btnShowForm1Dialog.Name = "btnShowForm1Dialog";
            this.btnShowForm1Dialog.Size = new System.Drawing.Size(123, 41);
            this.btnShowForm1Dialog.TabIndex = 1;
            this.btnShowForm1Dialog.Text = "Show Form as a Dialog";
            this.btnShowForm1Dialog.UseVisualStyleBackColor = true;
            this.btnShowForm1Dialog.Click += new System.EventHandler(this.btnShowForm1Dialog_Click);
            // 
            // btnShowMessageBox
            // 
            this.btnShowMessageBox.Location = new System.Drawing.Point(327, 61);
            this.btnShowMessageBox.Name = "btnShowMessageBox";
            this.btnShowMessageBox.Size = new System.Drawing.Size(123, 41);
            this.btnShowMessageBox.TabIndex = 2;
            this.btnShowMessageBox.Text = "Show Message Box Form";
            this.btnShowMessageBox.UseVisualStyleBackColor = true;
            this.btnShowMessageBox.Click += new System.EventHandler(this.btnShowMessageBox_Click);
            // 
            // btnCheckBoxRadioGroup
            // 
            this.btnCheckBoxRadioGroup.Location = new System.Drawing.Point(479, 61);
            this.btnCheckBoxRadioGroup.Name = "btnCheckBoxRadioGroup";
            this.btnCheckBoxRadioGroup.Size = new System.Drawing.Size(123, 41);
            this.btnCheckBoxRadioGroup.TabIndex = 3;
            this.btnCheckBoxRadioGroup.Text = "Check Box/Radio/Group";
            this.btnCheckBoxRadioGroup.UseVisualStyleBackColor = true;
            this.btnCheckBoxRadioGroup.Click += new System.EventHandler(this.btnCheckBoxRadioGroup_Click);
            // 
            // FormZack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 141);
            this.Controls.Add(this.btnCheckBoxRadioGroup);
            this.Controls.Add(this.btnShowMessageBox);
            this.Controls.Add(this.btnShowForm1Dialog);
            this.Controls.Add(this.btnShowPart1);
            this.Name = "FormZack";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowPart1;
        private System.Windows.Forms.Button btnShowForm1Dialog;
        private System.Windows.Forms.Button btnShowMessageBox;
        private System.Windows.Forms.Button btnCheckBoxRadioGroup;
    }
}