namespace Tic_Tac_Toe_Game
{
    partial class frmDrawing
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.tic_tac_teo;
            this.pictureBox1.Location = new System.Drawing.Point(41, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pb9
            // 
            this.pb9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb9.Location = new System.Drawing.Point(714, 192);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(39, 37);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb9.TabIndex = 18;
            this.pb9.TabStop = false;
            this.pb9.Tag = "0";
            this.pb9.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pb8
            // 
            this.pb8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb8.Location = new System.Drawing.Point(642, 192);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(39, 37);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb8.TabIndex = 17;
            this.pb8.TabStop = false;
            this.pb8.Tag = "0";
            this.pb8.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pb7
            // 
            this.pb7.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb7.Location = new System.Drawing.Point(564, 192);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(39, 37);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb7.TabIndex = 16;
            this.pb7.TabStop = false;
            this.pb7.Tag = "0";
            this.pb7.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pb6
            // 
            this.pb6.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb6.Location = new System.Drawing.Point(714, 130);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(39, 37);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb6.TabIndex = 15;
            this.pb6.TabStop = false;
            this.pb6.Tag = "0";
            this.pb6.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pb5
            // 
            this.pb5.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb5.Location = new System.Drawing.Point(642, 130);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(39, 37);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb5.TabIndex = 14;
            this.pb5.TabStop = false;
            this.pb5.Tag = "0";
            this.pb5.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pb4
            // 
            this.pb4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb4.Location = new System.Drawing.Point(564, 130);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(39, 37);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 13;
            this.pb4.TabStop = false;
            this.pb4.Tag = "0";
            this.pb4.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pb3
            // 
            this.pb3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb3.Location = new System.Drawing.Point(714, 68);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(39, 37);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 12;
            this.pb3.TabStop = false;
            this.pb3.Tag = "0";
            this.pb3.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pb2
            // 
            this.pb2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb2.Location = new System.Drawing.Point(642, 68);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(39, 37);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 11;
            this.pb2.TabStop = false;
            this.pb2.Tag = "0";
            this.pb2.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pb1
            // 
            this.pb1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb1.Location = new System.Drawing.Point(564, 68);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(39, 37);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 10;
            this.pb1.TabStop = false;
            this.pb1.Tag = "0";
            this.pb1.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(341, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 42);
            this.label2.TabIndex = 20;
            this.label2.Text = "Turn";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1.Location = new System.Drawing.Point(476, 9);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(167, 42);
            this.lblPlayer1.TabIndex = 21;
            this.lblPlayer1.Tag = "Y";
            this.lblPlayer1.Text = "Player1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2.Location = new System.Drawing.Point(649, 9);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(167, 42);
            this.lblPlayer2.TabIndex = 22;
            this.lblPlayer2.Tag = "N";
            this.lblPlayer2.Text = "Player2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(308, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 42);
            this.label5.TabIndex = 23;
            this.label5.Text = "Winner";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.White;
            this.lblWinner.Location = new System.Drawing.Point(268, 149);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(239, 42);
            this.lblWinner.TabIndex = 24;
            this.lblWinner.Text = "In progress";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRestartGame.Location = new System.Drawing.Point(348, 206);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(115, 53);
            this.btnRestartGame.TabIndex = 25;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // frmDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(858, 283);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.label1);
            this.Name = "frmDrawing";
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.frmDrawing_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestartGame;
    }
}