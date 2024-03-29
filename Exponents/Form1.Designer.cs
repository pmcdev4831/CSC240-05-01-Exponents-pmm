﻿namespace Exponents
{
    partial class UxMainForm
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
            this.UxInputTextBox = new System.Windows.Forms.TextBox();
            this.UxInputLabel = new System.Windows.Forms.Label();
            this.UxGoButton = new System.Windows.Forms.Button();
            this.UxResetButton = new System.Windows.Forms.Button();
            this.UxResultBox = new System.Windows.Forms.TextBox();
            this.UxResultCube = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UxInputTextBox
            // 
            this.UxInputTextBox.Location = new System.Drawing.Point(92, 45);
            this.UxInputTextBox.Name = "UxInputTextBox";
            this.UxInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.UxInputTextBox.TabIndex = 0;
            // 
            // UxInputLabel
            // 
            this.UxInputLabel.AutoSize = true;
            this.UxInputLabel.Location = new System.Drawing.Point(92, 27);
            this.UxInputLabel.Name = "UxInputLabel";
            this.UxInputLabel.Size = new System.Drawing.Size(85, 13);
            this.UxInputLabel.TabIndex = 3;
            this.UxInputLabel.Text = "Enter an integer:";
            // 
            // UxGoButton
            // 
            this.UxGoButton.Location = new System.Drawing.Point(105, 71);
            this.UxGoButton.Name = "UxGoButton";
            this.UxGoButton.Size = new System.Drawing.Size(75, 67);
            this.UxGoButton.TabIndex = 6;
            this.UxGoButton.Text = "Go!";
            this.UxGoButton.UseVisualStyleBackColor = true;
            this.UxGoButton.Click += new System.EventHandler(this.xGoButton_Click);
            // 
            // UxResetButton
            // 
            this.UxResetButton.Location = new System.Drawing.Point(105, 212);
            this.UxResetButton.Name = "UxResetButton";
            this.UxResetButton.Size = new System.Drawing.Size(75, 23);
            this.UxResetButton.TabIndex = 7;
            this.UxResetButton.Text = "Reset";
            this.UxResetButton.UseVisualStyleBackColor = true;
            this.UxResetButton.Click += new System.EventHandler(this.xResetButton_Click);
            // 
            // UxResultBox
            // 
            this.UxResultBox.Location = new System.Drawing.Point(92, 144);
            this.UxResultBox.Name = "UxResultBox";
            this.UxResultBox.Size = new System.Drawing.Size(151, 20);
            this.UxResultBox.TabIndex = 8;
            // 
            // UxResultCube
            // 
            this.UxResultCube.Location = new System.Drawing.Point(92, 186);
            this.UxResultCube.Name = "UxResultCube";
            this.UxResultCube.Size = new System.Drawing.Size(151, 20);
            this.UxResultCube.TabIndex = 9;
            // 
            // UxMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.UxResultCube);
            this.Controls.Add(this.UxResultBox);
            this.Controls.Add(this.UxResetButton);
            this.Controls.Add(this.UxGoButton);
            this.Controls.Add(this.UxInputLabel);
            this.Controls.Add(this.UxInputTextBox);
            this.Name = "UxMainForm";
            this.Text = "Exponents Demo";
            this.Load += new System.EventHandler(this.UxMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UxInputTextBox;
        private System.Windows.Forms.Label UxInputLabel;
        private System.Windows.Forms.Button UxGoButton;
        private System.Windows.Forms.Button UxResetButton;
        private System.Windows.Forms.TextBox UxResultBox;
        private System.Windows.Forms.TextBox UxResultCube;
    }
}

