namespace task9
{
    partial class Form1
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
            statusStrip1 = new StatusStrip();
            spWin = new ToolStripStatusLabel();
            spData = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { spWin, spData });
            statusStrip1.Location = new Point(0, 277);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(432, 26);
            statusStrip1.TabIndex = 0;
            // 
            // spWin
            // 
            spWin.Name = "spWin";
            spWin.Size = new Size(49, 20);
            spWin.Text = "Status";
            spWin.Click += spWin_Click;
            // 
            // spData
            // 
            spData.Name = "spData";
            spData.Size = new Size(41, 20);
            spData.Text = "Data";
            spData.Click += spData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 303);
            Controls.Add(statusStrip1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel spWin;
        private ToolStripStatusLabel spData;
    }
}
