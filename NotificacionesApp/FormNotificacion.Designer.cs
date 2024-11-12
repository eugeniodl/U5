namespace NotificacionesApp
{
    partial class FormNotificacion
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
            chkNotificaciones = new CheckBox();
            chkBoletin = new CheckBox();
            grpTipoUsuario = new GroupBox();
            rbtnProfesional = new RadioButton();
            rbtnEstudiante = new RadioButton();
            cmbCategoria = new ComboBox();
            lstCategorias = new ListBox();
            clsOpcionesAdicionales = new CheckedListBox();
            btnConfirmar = new Button();
            btnCargar = new Button();
            btnGuardar = new Button();
            grpTipoUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // chkNotificaciones
            // 
            chkNotificaciones.AutoSize = true;
            chkNotificaciones.Location = new Point(28, 28);
            chkNotificaciones.Name = "chkNotificaciones";
            chkNotificaciones.Size = new Size(139, 19);
            chkNotificaciones.TabIndex = 0;
            chkNotificaciones.Text = "Recibir notificaciones";
            chkNotificaciones.UseVisualStyleBackColor = true;
            // 
            // chkBoletin
            // 
            chkBoletin.AutoSize = true;
            chkBoletin.Location = new Point(28, 53);
            chkBoletin.Name = "chkBoletin";
            chkBoletin.Size = new Size(131, 19);
            chkBoletin.TabIndex = 1;
            chkBoletin.Text = "Suscribirse a boletín";
            chkBoletin.UseVisualStyleBackColor = true;
            // 
            // grpTipoUsuario
            // 
            grpTipoUsuario.Controls.Add(rbtnProfesional);
            grpTipoUsuario.Controls.Add(rbtnEstudiante);
            grpTipoUsuario.Location = new Point(28, 93);
            grpTipoUsuario.Name = "grpTipoUsuario";
            grpTipoUsuario.Size = new Size(200, 100);
            grpTipoUsuario.TabIndex = 2;
            grpTipoUsuario.TabStop = false;
            grpTipoUsuario.Text = "Tipo de Usuario";
            // 
            // rbtnProfesional
            // 
            rbtnProfesional.AutoSize = true;
            rbtnProfesional.Location = new Point(21, 59);
            rbtnProfesional.Name = "rbtnProfesional";
            rbtnProfesional.Size = new Size(84, 19);
            rbtnProfesional.TabIndex = 1;
            rbtnProfesional.TabStop = true;
            rbtnProfesional.Text = "Profesional";
            rbtnProfesional.UseVisualStyleBackColor = true;
            // 
            // rbtnEstudiante
            // 
            rbtnEstudiante.AutoSize = true;
            rbtnEstudiante.Location = new Point(21, 34);
            rbtnEstudiante.Name = "rbtnEstudiante";
            rbtnEstudiante.Size = new Size(80, 19);
            rbtnEstudiante.TabIndex = 0;
            rbtnEstudiante.TabStop = true;
            rbtnEstudiante.Text = "Estudiante";
            rbtnEstudiante.UseVisualStyleBackColor = true;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Tecnología", "Ciencia", "Arte" });
            cmbCategoria.Location = new Point(24, 213);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 3;
            // 
            // lstCategorias
            // 
            lstCategorias.FormattingEnabled = true;
            lstCategorias.ItemHeight = 15;
            lstCategorias.Items.AddRange(new object[] { "Noticias", "Eventos", "Promociones" });
            lstCategorias.Location = new Point(253, 29);
            lstCategorias.Name = "lstCategorias";
            lstCategorias.SelectionMode = SelectionMode.MultiExtended;
            lstCategorias.Size = new Size(202, 94);
            lstCategorias.TabIndex = 4;
            // 
            // clsOpcionesAdicionales
            // 
            clsOpcionesAdicionales.FormattingEnabled = true;
            clsOpcionesAdicionales.Items.AddRange(new object[] { "Modo Oscuro", "Recepción de Novedades", "Descuento en Productos" });
            clsOpcionesAdicionales.Location = new Point(255, 142);
            clsOpcionesAdicionales.Name = "clsOpcionesAdicionales";
            clsOpcionesAdicionales.Size = new Size(200, 94);
            clsOpcionesAdicionales.TabIndex = 5;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(24, 260);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(138, 29);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += Confirmar;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(168, 260);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(138, 29);
            btnCargar.TabIndex = 7;
            btnCargar.Text = "Cargar Configuración";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += Cargar;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(317, 260);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(138, 29);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += Guardar;
            // 
            // FormNotificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 318);
            Controls.Add(btnGuardar);
            Controls.Add(btnCargar);
            Controls.Add(btnConfirmar);
            Controls.Add(clsOpcionesAdicionales);
            Controls.Add(lstCategorias);
            Controls.Add(cmbCategoria);
            Controls.Add(grpTipoUsuario);
            Controls.Add(chkBoletin);
            Controls.Add(chkNotificaciones);
            Name = "FormNotificacion";
            Text = "Configuración de Notificaciones";
            grpTipoUsuario.ResumeLayout(false);
            grpTipoUsuario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkNotificaciones;
        private CheckBox chkBoletin;
        private GroupBox grpTipoUsuario;
        private RadioButton rbtnProfesional;
        private RadioButton rbtnEstudiante;
        private ComboBox cmbCategoria;
        private ListBox lstCategorias;
        private CheckedListBox clsOpcionesAdicionales;
        private Button btnConfirmar;
        private Button btnCargar;
        private Button btnGuardar;
    }
}