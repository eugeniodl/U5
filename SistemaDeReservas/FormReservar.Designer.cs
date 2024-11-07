﻿namespace SistemaDeReservas
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
            label5 = new Label();
            mtbTelefono = new MaskedTextBox();
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
            flowLayoutPanel.Controls.Add(label5);
            flowLayoutPanel.Controls.Add(mtbTelefono);
            flowLayoutPanel.Controls.Add(btnGuardar);
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(23, 27, 23, 27);
            flowLayoutPanel.Size = new Size(430, 483);
            flowLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 27);
            label1.Name = "label1";
            label1.Padding = new Padding(11, 13, 11, 13);
            label1.Size = new Size(340, 63);
            label1.TabIndex = 0;
            label1.Text = "Formulario de Reservas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 90);
            label2.Name = "label2";
            label2.Padding = new Padding(6, 7, 6, 7);
            label2.Size = new Size(79, 34);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(26, 128);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 27);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 159);
            label3.Name = "label3";
            label3.Padding = new Padding(6, 7, 6, 7);
            label3.Size = new Size(138, 34);
            label3.TabIndex = 3;
            label3.Text = "Fecha de Reserva:";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(26, 197);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(228, 27);
            dtpFecha.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 228);
            label4.Name = "label4";
            label4.Padding = new Padding(6, 7, 6, 7);
            label4.Size = new Size(152, 34);
            label4.TabIndex = 5;
            label4.Text = "Tipo de Habitación:";
            // 
            // cmbTipoHabitacion
            // 
            cmbTipoHabitacion.FormattingEnabled = true;
            cmbTipoHabitacion.Items.AddRange(new object[] { "Simple", "Doble", "Suite" });
            cmbTipoHabitacion.Location = new Point(26, 266);
            cmbTipoHabitacion.Margin = new Padding(3, 4, 3, 4);
            cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            cmbTipoHabitacion.Size = new Size(228, 28);
            cmbTipoHabitacion.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 298);
            label5.Name = "label5";
            label5.Padding = new Padding(7);
            label5.Size = new Size(84, 34);
            label5.TabIndex = 7;
            label5.Text = "Teléfono:";
            // 
            // mtbTelefono
            // 
            mtbTelefono.Location = new Point(26, 335);
            mtbTelefono.Mask = "(999)000-0000";
            mtbTelefono.Name = "mtbTelefono";
            mtbTelefono.Size = new Size(228, 27);
            mtbTelefono.TabIndex = 8;
            mtbTelefono.Validating += mtbTelefono_Validating;
            mtbTelefono.Validated += mtbTelefono_Validated;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(34, 378);
            btnGuardar.Margin = new Padding(11, 13, 11, 13);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 40);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += Guardar;
            // 
            // FormReservar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 483);
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
        private Label label5;
        private MaskedTextBox mtbTelefono;
    }
}