namespace task5
{
    partial class WinButNum
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
            clickButton1 = new ClickButton();
            SuspendLayout();
            // 
            // clickButton1
            // 
            clickButton1.Location = new Point(30, 27);
            clickButton1.Name = "clickButton1";
            clickButton1.Size = new Size(257, 239);
            clickButton1.TabIndex = 0;
            clickButton1.Text = "clickButton1";
            clickButton1.UseVisualStyleBackColor = true;
            // 
            // WinButNum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 295);
            Controls.Add(clickButton1);
            Name = "WinButNum";
            Text = "Form1";
            Load += WinButNum_Load;
            ResumeLayout(false);
        }

        #endregion

        private ClickButton clickButton1;
    }
}
