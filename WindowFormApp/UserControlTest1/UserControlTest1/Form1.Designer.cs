﻿namespace UserControlTest1
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
            this.button2 = new System.Windows.Forms.Button();
            this.ctrlSimpleCalc1 = new UserControlTest1.CtrlSimpleCalc();
            this.ctrlSimpleCalc2 = new UserControlTest1.CtrlSimpleCalc();
            this.ctrlSimpleCalc3 = new UserControlTest1.CtrlSimpleCalc();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "ShowResultFromForm1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ctrlSimpleCalc1
            // 
            this.ctrlSimpleCalc1.Location = new System.Drawing.Point(12, 12);
            this.ctrlSimpleCalc1.Name = "ctrlSimpleCalc1";
            this.ctrlSimpleCalc1.Size = new System.Drawing.Size(256, 268);
            this.ctrlSimpleCalc1.TabIndex = 5;
            this.ctrlSimpleCalc1.OnCalculationComplete += new System.Action<int>(this.ctrlSimpleCalc1_OnCalculationComplete);
            // 
            // ctrlSimpleCalc2
            // 
            this.ctrlSimpleCalc2.Location = new System.Drawing.Point(259, 12);
            this.ctrlSimpleCalc2.Name = "ctrlSimpleCalc2";
            this.ctrlSimpleCalc2.Size = new System.Drawing.Size(256, 268);
            this.ctrlSimpleCalc2.TabIndex = 6;
            this.ctrlSimpleCalc2.OnCalculationComplete += new System.Action<int>(this.ctrlSimpleCalc2_OnCalculationComplete);
            // 
            // ctrlSimpleCalc3
            // 
            this.ctrlSimpleCalc3.Location = new System.Drawing.Point(472, 12);
            this.ctrlSimpleCalc3.Name = "ctrlSimpleCalc3";
            this.ctrlSimpleCalc3.Size = new System.Drawing.Size(256, 268);
            this.ctrlSimpleCalc3.TabIndex = 7;
            this.ctrlSimpleCalc3.OnCalculationComplete += new System.Action<int>(this.ctrlSimpleCalc3_OnCalculationComplete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 418);
            this.Controls.Add(this.ctrlSimpleCalc3);
            this.Controls.Add(this.ctrlSimpleCalc2);
            this.Controls.Add(this.ctrlSimpleCalc1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private CtrlSimpleCalc ctrlSimpleCalc1;
        private CtrlSimpleCalc ctrlSimpleCalc2;
        private CtrlSimpleCalc ctrlSimpleCalc3;
    }
}

