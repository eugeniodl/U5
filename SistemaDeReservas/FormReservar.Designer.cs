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
            dateTimePicker = new DateTimePicker();
            label4 = new Label();
            comboBox1 = new ComboBox();
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
            flowLayoutPanel.Controls.Add(dateTimePicker);
            flowLayoutPanel.Controls.Add(label4);
            flowLayoutPanel.Controls.Add(comboBox1);
            flowLayoutPanel.Controls.Add(btnGuardar);
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(20);
            flowLayoutPanel.Size = new Size(368, 311);
            flowLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(261, 50);
            label1.TabIndex = 0;
            label1.Text = "Formulario de Reservas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 70);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(64, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(23, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 124);
            label3.Name = "label3";
            label3.Padding = new Padding(5);
            label3.Size = new Size(110, 25);
            label3.TabIndex = 3;
            label3.Text = "Fecha de Reserva:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(23, 152);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 178);
            label4.Name = "label4";
            label4.Padding = new Padding(5);
            label4.Size = new Size(120, 25);
            label4.TabIndex = 5;
            label4.Text = "Tipo de Habitación:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Simple", "Doble", "Suite" });
            comboBox1.Location = new Point(23, 206);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(30, 242);
            btnGuardar.Margin = new Padding(10);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FormReservar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 311);
            Controls.Add(flowLayoutPanel);
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
        private DateTimePicker dateTimePicker;
        private Label label4;
        private ComboBox comboBox1;
        private Button btnGuardar;
    }
}