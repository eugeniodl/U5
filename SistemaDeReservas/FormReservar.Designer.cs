namespace SistemaDeReservas
{
    partial class FormReservar
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
            flowLayoutPanel = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            label4 = new Label();
            cmbTipoHabitacion = new ComboBox();
            btnGuardar = new Button();
            flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Controls.Add(label1);
            flowLayoutPanel.Controls.Add(label2);
            flowLayoutPanel.Controls.Add(txtNombre);
            flowLayoutPanel.Controls.Add(label3);
            flowLayoutPanel.Controls.Add(dtpFecha);
            flowLayoutPanel.Controls.Add(label4);
            flowLayoutPanel.Controls.Add(cmbTipoHabitacion);
            flowLayoutPanel.Controls.Add(btnGuardar);
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(31, 36, 31, 36);
            flowLayoutPanel.Size = new Size(412, 442);
            flowLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 11, 10, 11);
            label1.Size = new Size(338, 59);
            label1.TabIndex = 0;
            label1.Text = "Formulario de Reservas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 95);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(6, 5, 6, 5);
            label2.Size = new Size(79, 30);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(33, 128);
            txtNombre.Margin = new Padding(2, 3, 2, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(121, 27);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 158);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(5, 5, 5, 5);
            label3.Size = new Size(136, 30);
            label3.TabIndex = 3;
            label3.Text = "Fecha de Reserva:";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(33, 191);
            dtpFecha.Margin = new Padding(2, 3, 2, 3);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(241, 27);
            dtpFecha.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 221);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(5, 5, 5, 5);
            label4.Size = new Size(150, 30);
            label4.TabIndex = 5;
            label4.Text = "Tipo de Habitación:";
            // 
            // cmbTipoHabitacion
            // 
            cmbTipoHabitacion.FormattingEnabled = true;
            cmbTipoHabitacion.Location = new Point(33, 254);
            cmbTipoHabitacion.Margin = new Padding(2, 3, 2, 3);
            cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            cmbTipoHabitacion.Size = new Size(147, 28);
            cmbTipoHabitacion.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(45, 301);
            btnGuardar.Margin = new Padding(14, 16, 14, 16);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(109, 51);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += Guardar;
            // 
            // FormReservar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 442);
            Controls.Add(flowLayoutPanel);
            Margin = new Padding(2, 3, 2, 3);
            Name = "FormReservar";
            Text = "Reservar";
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private DateTimePicker dtpFecha;
        private Label label4;
        private ComboBox cmbTipoHabitacion;
        private Button btnGuardar;
    }
}