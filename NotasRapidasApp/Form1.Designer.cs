namespace NotasRapidasApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtNota = new TextBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // txtNota
            // 
            txtNota.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNota.Location = new Point(81, 38);
            txtNota.Multiline = true;
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(633, 285);
            txtNota.TabIndex = 0;
            txtNota.DoubleClick += DestacarNota;
            txtNota.MouseDown += IniciarArrastre;
            txtNota.MouseMove += ArrastrarControl;
            txtNota.MouseUp += TerminarArrastre;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(130, 368);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(174, 36);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            toolTip1.SetToolTip(btnGuardar, "Guardar Nota (Ctrl+S)");
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += GuardarNota;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(497, 368);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(174, 36);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            toolTip1.SetToolTip(btnLimpiar, "Limpiar Nota (Ctrl+L)");
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += LimpiarNota;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtNota);
            KeyPreview = true;
            Name = "Form1";
            Text = "NotasRapidasApp";
            KeyDown += AtajosDeTeclado;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNota;
        private Button btnGuardar;
        private Button btnLimpiar;
        private ToolTip toolTip1;
    }
}