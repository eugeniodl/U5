namespace SistemaDeReservas
{
    partial class FormVerReservas
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
            label1 = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(236, 37);
            label1.TabIndex = 0;
            label1.Text = "Lista de Reservas";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.Controls.Add(label2, 0, 0);
            tableLayoutPanel.Controls.Add(label3, 1, 0);
            tableLayoutPanel.Controls.Add(label4, 2, 0);
            tableLayoutPanel.Location = new Point(0, 64);
            tableLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(616, 46);
            tableLayoutPanel.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(4, 1);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(209, 1);
            label3.Name = "label3";
            label3.Size = new Size(176, 28);
            label3.TabIndex = 1;
            label3.Text = "Fecha de Reserva";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(414, 1);
            label4.Name = "label4";
            label4.Size = new Size(192, 28);
            label4.TabIndex = 2;
            label4.Text = "Tipo de Habitación";
            // 
            // FormVerReservas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 501);
            Controls.Add(tableLayoutPanel);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormVerReservas";
            Text = "FormVerReservas";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}