namespace RangoDefinidoApp
{
    partial class MainForm
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
            progressBar = new ProgressBar();
            hScrollBar = new HScrollBar();
            trackBar = new TrackBar();
            lblValue = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Dock = DockStyle.Top;
            progressBar.Location = new Point(0, 0);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(376, 23);
            progressBar.TabIndex = 0;
            progressBar.Value = 50;
            // 
            // hScrollBar
            // 
            hScrollBar.Dock = DockStyle.Top;
            hScrollBar.Location = new Point(0, 23);
            hScrollBar.Name = "hScrollBar";
            hScrollBar.Size = new Size(376, 17);
            hScrollBar.TabIndex = 1;
            hScrollBar.Value = 50;
            hScrollBar.Scroll += hScrollBar_Scroll;
            // 
            // trackBar
            // 
            trackBar.Dock = DockStyle.Top;
            trackBar.Location = new Point(0, 40);
            trackBar.Maximum = 100;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(376, 45);
            trackBar.TabIndex = 2;
            trackBar.Value = 50;
            trackBar.Scroll += trackBar_Scroll;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Location = new Point(12, 98);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(86, 15);
            lblValue.TabIndex = 3;
            lblValue.Text = "Valor actual: 50";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 138);
            Controls.Add(lblValue);
            Controls.Add(trackBar);
            Controls.Add(hScrollBar);
            Controls.Add(progressBar);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar;
        private HScrollBar hScrollBar;
        private TrackBar trackBar;
        private Label lblValue;
    }
}