namespace WinFormsPractice6
{
    partial class frmProgressBar
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
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnIncreaseProgressBar = new System.Windows.Forms.Button();
            this.btnResetProgressBar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(41, 65);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(235, 33);
            this.progressBar1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "0%";
            // 
            // btnIncreaseProgressBar
            // 
            this.btnIncreaseProgressBar.Location = new System.Drawing.Point(27, 121);
            this.btnIncreaseProgressBar.Name = "btnIncreaseProgressBar";
            this.btnIncreaseProgressBar.Size = new System.Drawing.Size(131, 40);
            this.btnIncreaseProgressBar.TabIndex = 2;
            this.btnIncreaseProgressBar.Text = "Increase Progress Bar";
            this.btnIncreaseProgressBar.UseMnemonic = false;
            this.btnIncreaseProgressBar.UseVisualStyleBackColor = true;
            this.btnIncreaseProgressBar.Click += new System.EventHandler(this.btnIncreaseProgressBar_Click);
            // 
            // btnResetProgressBar
            // 
            this.btnResetProgressBar.Location = new System.Drawing.Point(170, 121);
            this.btnResetProgressBar.Name = "btnResetProgressBar";
            this.btnResetProgressBar.Size = new System.Drawing.Size(133, 40);
            this.btnResetProgressBar.TabIndex = 3;
            this.btnResetProgressBar.Text = "Reset Progress Bar";
            this.btnResetProgressBar.UseVisualStyleBackColor = true;
            this.btnResetProgressBar.Click += new System.EventHandler(this.btnResetProgressBar_Click);
            // 
            // frmProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 208);
            this.Controls.Add(this.btnResetProgressBar);
            this.Controls.Add(this.btnIncreaseProgressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Name = "frmProgressBar";
            this.Text = "frmProgressBar";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnResetProgressBar;
        private System.Windows.Forms.Button btnIncreaseProgressBar;
        private System.Windows.Forms.Label label1;
    }
}