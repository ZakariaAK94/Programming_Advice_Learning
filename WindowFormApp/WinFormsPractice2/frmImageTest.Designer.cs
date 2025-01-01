namespace WinFormsPractice2
{
    partial class frmImageTest
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
            this.btnBoy = new System.Windows.Forms.Button();
            this.btnGirl = new System.Windows.Forms.Button();
            this.btnPen = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbBoy = new System.Windows.Forms.RadioButton();
            this.rbGirl = new System.Windows.Forms.RadioButton();
            this.rbPen = new System.Windows.Forms.RadioButton();
            this.rbBook = new System.Windows.Forms.RadioButton();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBoy
            // 
            this.btnBoy.Location = new System.Drawing.Point(23, 276);
            this.btnBoy.Name = "btnBoy";
            this.btnBoy.Size = new System.Drawing.Size(64, 42);
            this.btnBoy.TabIndex = 1;
            this.btnBoy.Tag = "Boy";
            this.btnBoy.Text = "Boy";
            this.btnBoy.UseVisualStyleBackColor = true;
            this.btnBoy.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGirl
            // 
            this.btnGirl.Location = new System.Drawing.Point(112, 276);
            this.btnGirl.Name = "btnGirl";
            this.btnGirl.Size = new System.Drawing.Size(64, 42);
            this.btnGirl.TabIndex = 3;
            this.btnGirl.Text = "Girl";
            this.btnGirl.UseVisualStyleBackColor = true;
            this.btnGirl.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPen
            // 
            this.btnPen.Location = new System.Drawing.Point(201, 276);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(64, 42);
            this.btnPen.TabIndex = 4;
            this.btnPen.Text = "Pen";
            this.btnPen.UseVisualStyleBackColor = true;
            this.btnPen.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(283, 276);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(64, 42);
            this.btnBook.TabIndex = 5;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsPractice2.Properties.Resources.Book;
            this.pictureBox1.Location = new System.Drawing.Point(118, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // rbBoy
            // 
            this.rbBoy.AutoSize = true;
            this.rbBoy.Location = new System.Drawing.Point(11, 21);
            this.rbBoy.Name = "rbBoy";
            this.rbBoy.Size = new System.Drawing.Size(43, 17);
            this.rbBoy.TabIndex = 6;
            this.rbBoy.TabStop = true;
            this.rbBoy.Tag = "Boy";
            this.rbBoy.Text = "Boy";
            this.rbBoy.UseVisualStyleBackColor = true;
            this.rbBoy.CheckedChanged += new System.EventHandler(this.rbBoy_CheckedChanged);
            // 
            // rbGirl
            // 
            this.rbGirl.AutoSize = true;
            this.rbGirl.Location = new System.Drawing.Point(11, 65);
            this.rbGirl.Name = "rbGirl";
            this.rbGirl.Size = new System.Drawing.Size(40, 17);
            this.rbGirl.TabIndex = 7;
            this.rbGirl.TabStop = true;
            this.rbGirl.Tag = "Girl";
            this.rbGirl.Text = "Girl";
            this.rbGirl.UseVisualStyleBackColor = true;
            this.rbGirl.CheckedChanged += new System.EventHandler(this.rbGirl_CheckedChanged);
            // 
            // rbPen
            // 
            this.rbPen.AutoSize = true;
            this.rbPen.Location = new System.Drawing.Point(11, 111);
            this.rbPen.Name = "rbPen";
            this.rbPen.Size = new System.Drawing.Size(44, 17);
            this.rbPen.TabIndex = 8;
            this.rbPen.TabStop = true;
            this.rbPen.Tag = "Pen";
            this.rbPen.Text = "Pen";
            this.rbPen.UseVisualStyleBackColor = true;
            this.rbPen.CheckedChanged += new System.EventHandler(this.rbPen_CheckedChanged);
            // 
            // rbBook
            // 
            this.rbBook.AutoSize = true;
            this.rbBook.BackColor = System.Drawing.SystemColors.Control;
            this.rbBook.Location = new System.Drawing.Point(11, 155);
            this.rbBook.Name = "rbBook";
            this.rbBook.Size = new System.Drawing.Size(50, 17);
            this.rbBook.TabIndex = 9;
            this.rbBook.TabStop = true;
            this.rbBook.Tag = "Book";
            this.rbBook.Text = "Book";
            this.rbBook.UseVisualStyleBackColor = false;
            this.rbBook.CheckedChanged += new System.EventHandler(this.rbBook_CheckedChanged);
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbBook);
            this.gbType.Controls.Add(this.rbPen);
            this.gbType.Controls.Add(this.rbGirl);
            this.gbType.Controls.Add(this.rbBoy);
            this.gbType.Location = new System.Drawing.Point(24, 68);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(76, 194);
            this.gbType.TabIndex = 10;
            this.gbType.TabStop = false;
            this.gbType.Text = "Type";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(170, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(101, 34);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(377, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmImageTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 375);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnPen);
            this.Controls.Add(this.btnGirl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBoy);
            this.Name = "frmImageTest";
            this.Text = "frmImageTest";
            this.Load += new System.EventHandler(this.frmImageTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBoy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGirl;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.RadioButton rbBoy;
        private System.Windows.Forms.RadioButton rbGirl;
        private System.Windows.Forms.RadioButton rbPen;
        private System.Windows.Forms.RadioButton rbBook;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}