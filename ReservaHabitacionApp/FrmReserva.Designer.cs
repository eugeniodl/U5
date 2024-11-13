namespace ReservaHabitacionApp
{
    partial class FrmReserva
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
            picHabitacion = new PictureBox();
            label1 = new Label();
            dtpFechaEntrada = new DateTimePicker();
            label2 = new Label();
            nudDiasEstancia = new NumericUpDown();
            btnCalcular = new Button();
            lblPrecioTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)picHabitacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDiasEstancia).BeginInit();
            SuspendLayout();
            // 
            // picHabitacion
            // 
            picHabitacion.Image = Properties.Resources.habitacion;
            picHabitacion.Location = new Point(57, 36);
            picHabitacion.Name = "picHabitacion";
            picHabitacion.Size = new Size(675, 291);
            picHabitacion.SizeMode = PictureBoxSizeMode.StretchImage;
            picHabitacion.TabIndex = 0;
            picHabitacion.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 359);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 1;
            label1.Text = "Fecha de entrada:";
            // 
            // dtpFechaEntrada
            // 
            dtpFechaEntrada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaEntrada.Format = DateTimePickerFormat.Short;
            dtpFechaEntrada.Location = new Point(206, 353);
            dtpFechaEntrada.Name = "dtpFechaEntrada";
            dtpFechaEntrada.Size = new Size(119, 29);
            dtpFechaEntrada.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(69, 399);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 3;
            label2.Text = "Días de estancia:";
            // 
            // nudDiasEstancia
            // 
            nudDiasEstancia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudDiasEstancia.Location = new Point(205, 397);
            nudDiasEstancia.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nudDiasEstancia.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDiasEstancia.Name = "nudDiasEstancia";
            nudDiasEstancia.Size = new Size(120, 29);
            nudDiasEstancia.TabIndex = 4;
            nudDiasEstancia.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(69, 444);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(107, 45);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += Calcular;
            // 
            // lblPrecioTotal
            // 
            lblPrecioTotal.AutoSize = true;
            lblPrecioTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecioTotal.Location = new Point(206, 449);
            lblPrecioTotal.Name = "lblPrecioTotal";
            lblPrecioTotal.Size = new Size(67, 30);
            lblPrecioTotal.TabIndex = 6;
            lblPrecioTotal.Text = "Total:";
            // 
            // FrmReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 521);
            Controls.Add(lblPrecioTotal);
            Controls.Add(btnCalcular);
            Controls.Add(nudDiasEstancia);
            Controls.Add(label2);
            Controls.Add(dtpFechaEntrada);
            Controls.Add(label1);
            Controls.Add(picHabitacion);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmReserva";
            Text = "Reserva de habitación";
            ((System.ComponentModel.ISupportInitialize)picHabitacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDiasEstancia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picHabitacion;
        private Label label1;
        private DateTimePicker dtpFechaEntrada;
        private Label label2;
        private NumericUpDown nudDiasEstancia;
        private Button btnCalcular;
        private Label lblPrecioTotal;
    }
}