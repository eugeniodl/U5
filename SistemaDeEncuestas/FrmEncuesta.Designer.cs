namespace SistemaDeEncuestas
{
    partial class FrmEncuesta
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
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            tvSecciones = new TreeView();
            label2 = new Label();
            lvPreguntas = new ListView();
            label3 = new Label();
            dgvDetallesPregunta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesPregunta).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvSecciones);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvDetallesPregunta);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(lvPreguntas);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(569, 288);
            splitContainer1.SplitterDistance = 189;
            splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Lista de secciones:";
            // 
            // tvSecciones
            // 
            tvSecciones.Dock = DockStyle.Top;
            tvSecciones.Location = new Point(0, 15);
            tvSecciones.Name = "tvSecciones";
            tvSecciones.Size = new Size(189, 162);
            tvSecciones.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Preguntas:";
            // 
            // lvPreguntas
            // 
            lvPreguntas.Dock = DockStyle.Top;
            lvPreguntas.Location = new Point(0, 15);
            lvPreguntas.Name = "lvPreguntas";
            lvPreguntas.Size = new Size(376, 97);
            lvPreguntas.TabIndex = 1;
            lvPreguntas.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(0, 112);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 2;
            label3.Text = "Detalles de las preguntas:";
            // 
            // dgvDetallesPregunta
            // 
            dgvDetallesPregunta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesPregunta.Dock = DockStyle.Top;
            dgvDetallesPregunta.Location = new Point(0, 127);
            dgvDetallesPregunta.Name = "dgvDetallesPregunta";
            dgvDetallesPregunta.RowTemplate.Height = 25;
            dgvDetallesPregunta.Size = new Size(376, 150);
            dgvDetallesPregunta.TabIndex = 3;
            // 
            // FrmEncuesta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 288);
            Controls.Add(splitContainer1);
            Name = "FrmEncuesta";
            Text = "FrmEncuesta";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetallesPregunta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TreeView tvSecciones;
        private Label label1;
        private DataGridView dgvDetallesPregunta;
        private Label label3;
        private ListView lvPreguntas;
        private Label label2;
    }
}