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
            tvSecciones = new TreeView();
            label1 = new Label();
            tbPonderacion = new TrackBar();
            label4 = new Label();
            dgvDetallesPregunta = new DataGridView();
            label3 = new Label();
            lvPreguntas = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbPonderacion).BeginInit();
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
            splitContainer1.Panel2.Controls.Add(tbPonderacion);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(dgvDetallesPregunta);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(lvPreguntas);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(792, 371);
            splitContainer1.SplitterDistance = 263;
            splitContainer1.TabIndex = 0;
            // 
            // tvSecciones
            // 
            tvSecciones.Dock = DockStyle.Top;
            tvSecciones.Location = new Point(0, 25);
            tvSecciones.Name = "tvSecciones";
            tvSecciones.Size = new Size(263, 162);
            tvSecciones.TabIndex = 1;
            tvSecciones.AfterSelect += tvSecciones_AfterSelect;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 0;
            label1.Text = "Lista de secciones:";
            // 
            // tbPonderacion
            // 
            tbPonderacion.Location = new Point(145, 312);
            tbPonderacion.Name = "tbPonderacion";
            tbPonderacion.Size = new Size(104, 45);
            tbPonderacion.TabIndex = 5;
            tbPonderacion.Value = 1;
            tbPonderacion.Scroll += tbPonderacion_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 312);
            label4.Name = "label4";
            label4.Size = new Size(111, 21);
            label4.TabIndex = 4;
            label4.Text = "Ponderación:";
            // 
            // dgvDetallesPregunta
            // 
            dgvDetallesPregunta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetallesPregunta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesPregunta.Dock = DockStyle.Top;
            dgvDetallesPregunta.Location = new Point(0, 147);
            dgvDetallesPregunta.Name = "dgvDetallesPregunta";
            dgvDetallesPregunta.RowTemplate.Height = 25;
            dgvDetallesPregunta.Size = new Size(525, 150);
            dgvDetallesPregunta.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 122);
            label3.Name = "label3";
            label3.Size = new Size(221, 25);
            label3.TabIndex = 2;
            label3.Text = "Detalles de la pregunta:";
            // 
            // lvPreguntas
            // 
            lvPreguntas.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvPreguntas.Dock = DockStyle.Top;
            lvPreguntas.GridLines = true;
            lvPreguntas.Location = new Point(0, 25);
            lvPreguntas.Name = "lvPreguntas";
            lvPreguntas.Size = new Size(525, 97);
            lvPreguntas.TabIndex = 1;
            lvPreguntas.UseCompatibleStateImageBehavior = false;
            lvPreguntas.View = View.Details;
            lvPreguntas.SelectedIndexChanged += lvPreguntas_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Texto de la pregunta";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tipo de respuesta";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Estado";
            columnHeader3.Width = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 0;
            label2.Text = "Preguntas:";
            // 
            // FrmEncuesta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 371);
            Controls.Add(splitContainer1);
            Name = "FrmEncuesta";
            Text = "Sistema de Encuestas";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbPonderacion).EndInit();
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
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TrackBar tbPonderacion;
        private Label label4;
    }
}