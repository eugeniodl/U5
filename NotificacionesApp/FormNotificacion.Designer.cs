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
            lblResumen = new Label();
            btnGuardar = new Button();
            btnCargarConfiguracion = new Button();
            btnConfirmar = new Button();
            cmbCategoria = new ComboBox();
            clbOpcionesAdicionales = new CheckedListBox();
            lstCategorias = new ListBox();
            grpTipoUsuario = new GroupBox();
            rbtnProfesional = new RadioButton();
            rbtnEstudiante = new RadioButton();
            chkBoletin = new CheckBox();
            chkNotificaciones = new CheckBox();
            grpTipoUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(44, 367);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(38, 15);
            lblResumen.TabIndex = 19;
            lblResumen.Text = "label1";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(426, 307);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(155, 23);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += Guardar;
            // 
            // btnCargarConfiguracion
            // 
            btnCargarConfiguracion.Location = new Point(226, 307);
            btnCargarConfiguracion.Name = "btnCargarConfiguracion";
            btnCargarConfiguracion.Size = new Size(155, 23);
            btnCargarConfiguracion.TabIndex = 17;
            btnCargarConfiguracion.Text = "Cargar Configuración";
            btnCargarConfiguracion.UseVisualStyleBackColor = true;
            btnCargarConfiguracion.Click += CargarConfiguracion;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(44, 307);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(155, 23);
            btnConfirmar.TabIndex = 16;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += Confirmar;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Teconología", "Ciencia", "Arte" });
            cmbCategoria.Location = new Point(36, 237);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 15;
            // 
            // clbOpcionesAdicionales
            // 
            clbOpcionesAdicionales.FormattingEnabled = true;
            clbOpcionesAdicionales.Items.AddRange(new object[] { "Modo oscuro", "Recepción de novedades", "Descuento en productos" });
            clbOpcionesAdicionales.Location = new Point(334, 166);
            clbOpcionesAdicionales.Name = "clbOpcionesAdicionales";
            clbOpcionesAdicionales.Size = new Size(247, 94);
            clbOpcionesAdicionales.TabIndex = 14;
            // 
            // lstCategorias
            // 
            lstCategorias.FormattingEnabled = true;
            lstCategorias.ItemHeight = 15;
            lstCategorias.Items.AddRange(new object[] { "Noticias", "Eventos", "Promociones" });
            lstCategorias.Location = new Point(334, 33);
            lstCategorias.Name = "lstCategorias";
            lstCategorias.SelectionMode = SelectionMode.MultiExtended;
            lstCategorias.Size = new Size(247, 94);
            lstCategorias.TabIndex = 13;
            // 
            // grpTipoUsuario
            // 
            grpTipoUsuario.Controls.Add(rbtnProfesional);
            grpTipoUsuario.Controls.Add(rbtnEstudiante);
            grpTipoUsuario.Location = new Point(36, 109);
            grpTipoUsuario.Name = "grpTipoUsuario";
            grpTipoUsuario.Size = new Size(200, 100);
            grpTipoUsuario.TabIndex = 12;
            grpTipoUsuario.TabStop = false;
            grpTipoUsuario.Text = "Tipo de usuario";
            // 
            // rbtnProfesional
            // 
            rbtnProfesional.AutoSize = true;
            rbtnProfesional.Location = new Point(11, 57);
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
            rbtnEstudiante.Location = new Point(11, 32);
            rbtnEstudiante.Name = "rbtnEstudiante";
            rbtnEstudiante.Size = new Size(80, 19);
            rbtnEstudiante.TabIndex = 0;
            rbtnEstudiante.TabStop = true;
            rbtnEstudiante.Text = "Estudiante";
            rbtnEstudiante.UseVisualStyleBackColor = true;
            // 
            // chkBoletin
            // 
            chkBoletin.AutoSize = true;
            chkBoletin.Location = new Point(35, 62);
            chkBoletin.Name = "chkBoletin";
            chkBoletin.Size = new Size(131, 19);
            chkBoletin.TabIndex = 11;
            chkBoletin.Text = "Suscribirse a boletín";
            chkBoletin.UseVisualStyleBackColor = true;
            // 
            // chkNotificaciones
            // 
            chkNotificaciones.AutoSize = true;
            chkNotificaciones.Location = new Point(36, 33);
            chkNotificaciones.Name = "chkNotificaciones";
            chkNotificaciones.Size = new Size(139, 19);
            chkNotificaciones.TabIndex = 10;
            chkNotificaciones.Text = "Recibir notificaciones";
            chkNotificaciones.UseVisualStyleBackColor = true;
            // 
            // FormNotificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 430);
            Controls.Add(lblResumen);
            Controls.Add(btnGuardar);
            Controls.Add(btnCargarConfiguracion);
            Controls.Add(btnConfirmar);
            Controls.Add(cmbCategoria);
            Controls.Add(clbOpcionesAdicionales);
            Controls.Add(lstCategorias);
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

        private Label lblResumen;
        private Button btnGuardar;
        private Button btnCargarConfiguracion;
        private Button btnConfirmar;
        private ComboBox cmbCategoria;
        private CheckedListBox clbOpcionesAdicionales;
        private ListBox lstCategorias;
        private GroupBox grpTipoUsuario;
        private RadioButton rbtnProfesional;
        private RadioButton rbtnEstudiante;
        private CheckBox chkBoletin;
        private CheckBox chkNotificaciones;
    }
}