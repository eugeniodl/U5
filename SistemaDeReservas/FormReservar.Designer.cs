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
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(27);
            flowLayoutPanel.Size = new Size(322, 321);
            flowLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(9, 8, 9, 8);
            label1.Size = new Size(259, 46);
            label1.TabIndex = 0;
            label1.Text = "Formulario de Reservas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 73);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(5, 4, 5, 4);
            label2.Size = new Size(64, 23);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(29, 98);
            txtNombre.Margin = new Padding(2, 2, 2, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(106, 23);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 123);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(4);
            label3.Size = new Size(108, 23);
            label3.TabIndex = 3;
            label3.Text = "Fecha de Reserva:";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(29, 148);
            dtpFecha.Margin = new Padding(2, 2, 2, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(211, 23);
            dtpFecha.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 173);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(4);
            label4.Size = new Size(118, 23);
            label4.TabIndex = 5;
            label4.Text = "Tipo de Habitación:";
            // 
            // cmbTipoHabitacion
            // 
            cmbTipoHabitacion.FormattingEnabled = true;
            cmbTipoHabitacion.Location = new Point(29, 198);
            cmbTipoHabitacion.Margin = new Padding(2, 2, 2, 2);
            cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            cmbTipoHabitacion.Size = new Size(129, 23);
            cmbTipoHabitacion.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(39, 235);
            btnGuardar.Margin = new Padding(12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(95, 38);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FormReservar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 321);
            Controls.Add(flowLayoutPanel);
            Margin = new Padding(2, 2, 2, 2);
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