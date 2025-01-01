namespace WinFormsPractice1
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnChangeFormTitle = new System.Windows.Forms.Button();
            this.btnChangeColorToBlack = new System.Windows.Forms.Button();
            this.btnEnabletxtBox2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowTextBox1 = new System.Windows.Forms.Button();
            this.btnHideTextBox1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnChangeColorToGreen = new System.Windows.Forms.Button();
            this.btnDisabletxtBox2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Write below your text";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsPractice1.Properties.Resources.Pizza;
            this.pictureBox1.Location = new System.Drawing.Point(584, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.FlatAppearance.BorderSize = 5;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(119, 150);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 34);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnChangeFormTitle
            // 
            this.btnChangeFormTitle.Location = new System.Drawing.Point(421, 150);
            this.btnChangeFormTitle.Name = "btnChangeFormTitle";
            this.btnChangeFormTitle.Size = new System.Drawing.Size(137, 23);
            this.btnChangeFormTitle.TabIndex = 23;
            this.btnChangeFormTitle.Text = "Change Form Title";
            this.btnChangeFormTitle.UseVisualStyleBackColor = true;
            // 
            // btnChangeColorToBlack
            // 
            this.btnChangeColorToBlack.Location = new System.Drawing.Point(595, 74);
            this.btnChangeColorToBlack.Name = "btnChangeColorToBlack";
            this.btnChangeColorToBlack.Size = new System.Drawing.Size(137, 23);
            this.btnChangeColorToBlack.TabIndex = 22;
            this.btnChangeColorToBlack.Text = "TxtBox 1 And 2 to black";
            this.btnChangeColorToBlack.UseVisualStyleBackColor = true;
            // 
            // btnEnabletxtBox2
            // 
            this.btnEnabletxtBox2.Location = new System.Drawing.Point(595, 36);
            this.btnEnabletxtBox2.Name = "btnEnabletxtBox2";
            this.btnEnabletxtBox2.Size = new System.Drawing.Size(137, 23);
            this.btnEnabletxtBox2.TabIndex = 21;
            this.btnEnabletxtBox2.Text = "Enable TextBox2";
            this.btnEnabletxtBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 38);
            this.label1.TabIndex = 24;
            this.label1.Text = "This is a Practice Project";
            // 
            // btnShowTextBox1
            // 
            this.btnShowTextBox1.Location = new System.Drawing.Point(595, 112);
            this.btnShowTextBox1.Name = "btnShowTextBox1";
            this.btnShowTextBox1.Size = new System.Drawing.Size(137, 23);
            this.btnShowTextBox1.TabIndex = 20;
            this.btnShowTextBox1.Text = "Show TextBox 1";
            this.btnShowTextBox1.UseVisualStyleBackColor = true;
            // 
            // btnHideTextBox1
            // 
            this.btnHideTextBox1.Location = new System.Drawing.Point(421, 112);
            this.btnHideTextBox1.Name = "btnHideTextBox1";
            this.btnHideTextBox1.Size = new System.Drawing.Size(137, 23);
            this.btnHideTextBox1.TabIndex = 19;
            this.btnHideTextBox1.Text = "Hide TextBox 1";
            this.btnHideTextBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 14;
            // 
            // btnChangeColorToGreen
            // 
            this.btnChangeColorToGreen.Location = new System.Drawing.Point(421, 74);
            this.btnChangeColorToGreen.Name = "btnChangeColorToGreen";
            this.btnChangeColorToGreen.Size = new System.Drawing.Size(137, 23);
            this.btnChangeColorToGreen.TabIndex = 18;
            this.btnChangeColorToGreen.Text = "TxtBox 1 And 2 to green";
            this.btnChangeColorToGreen.UseVisualStyleBackColor = true;
            // 
            // btnDisabletxtBox2
            // 
            this.btnDisabletxtBox2.Location = new System.Drawing.Point(421, 36);
            this.btnDisabletxtBox2.Name = "btnDisabletxtBox2";
            this.btnDisabletxtBox2.Size = new System.Drawing.Size(137, 23);
            this.btnDisabletxtBox2.TabIndex = 17;
            this.btnDisabletxtBox2.Text = "Disable TextBox2";
            this.btnDisabletxtBox2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(238, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(763, 271);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChangeFormTitle);
            this.Controls.Add(this.btnChangeColorToBlack);
            this.Controls.Add(this.btnEnabletxtBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowTextBox1);
            this.Controls.Add(this.btnHideTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnChangeColorToGreen);
            this.Controls.Add(this.btnDisabletxtBox2);
            this.Controls.Add(this.textBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnChangeFormTitle;
        private System.Windows.Forms.Button btnChangeColorToBlack;
        private System.Windows.Forms.Button btnEnabletxtBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowTextBox1;
        private System.Windows.Forms.Button btnHideTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnChangeColorToGreen;
        private System.Windows.Forms.Button btnDisabletxtBox2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

