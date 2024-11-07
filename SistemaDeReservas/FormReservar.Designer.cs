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
            flowLayoutPanel.Padding = new Padding(23, 27, 23, 27);
            flowLayoutPanel.Size = new Size(608, 484);
            flowLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 27);
            label1.Name = "label1";
            label1.Padding = new Padding(11, 13, 11, 13);
            label1.Size = new Size(289, 57);
            label1.TabIndex = 0;
            label1.Text = "Formulario de Reservas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 84);
            label2.Name = "label2";
            label2.Padding = new Padding(7);
            label2.Size = new Size(81, 34);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(26, 121);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 151);
            label3.Name = "label3";
            label3.Padding = new Padding(7);
            label3.Size = new Size(140, 34);
            label3.TabIndex = 3;
            label3.Text = "Fecha de Reserva:";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(26, 188);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 225);
            label4.Name = "label4";
            label4.Padding = new Padding(7);
            label4.Size = new Size(154, 34);
            label4.TabIndex = 5;
            label4.Text = "Tipo de Habitación:";
            // 
            // cmbTipoHabitacion
            // 
            cmbTipoHabitacion.FormattingEnabled = true;
            cmbTipoHabitacion.Location = new Point(26, 262);
            cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            cmbTipoHabitacion.Size = new Size(250, 28);
            cmbTipoHabitacion.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(34, 311);
            btnGuardar.Margin = new Padding(11);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(126, 53);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += Guardar;
            // 
            // FormReservar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 484);
            Controls.Add(flowLayoutPanel);
            Margin = new Padding(3, 4, 3, 4);
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