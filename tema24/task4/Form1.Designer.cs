﻿namespace task4
{
    partial class WinTimer2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userControlTimer21 = new UserControlTimer2();
            SuspendLayout();
            // 
            // userControlTimer21
            // 
            userControlTimer21.Location = new Point(57, 104);
            userControlTimer21.Name = "userControlTimer21";
            userControlTimer21.Size = new Size(188, 188);
            userControlTimer21.TabIndex = 0;
            // 
            // WinTimer2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 450);
            Controls.Add(userControlTimer21);
            Name = "WinTimer2";
            Text = "Form1";
            Load += WinTimer2_Load;
            ResumeLayout(false);
        }

        #endregion

        private UserControlTimer2 userControlTimer21;
    }
}