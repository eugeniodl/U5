namespace GestorDeTareas
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            tareasToolStripMenuItem = new ToolStripMenuItem();
            agregarTareaToolStripMenuItem = new ToolStripMenuItem();
            editarTareaToolStripMenuItem = new ToolStripMenuItem();
            eliminarTareaToolStripMenuItem = new ToolStripMenuItem();
            lstTareas = new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, tareasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += Salir;
            // 
            // tareasToolStripMenuItem
            // 
            tareasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarTareaToolStripMenuItem, editarTareaToolStripMenuItem, eliminarTareaToolStripMenuItem });
            tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            tareasToolStripMenuItem.Size = new Size(51, 20);
            tareasToolStripMenuItem.Text = "Tareas";
            // 
            // agregarTareaToolStripMenuItem
            // 
            agregarTareaToolStripMenuItem.Name = "agregarTareaToolStripMenuItem";
            agregarTareaToolStripMenuItem.Size = new Size(180, 22);
            agregarTareaToolStripMenuItem.Text = "Agregar Tarea";
            agregarTareaToolStripMenuItem.Click += AgregarTarea;
            // 
            // editarTareaToolStripMenuItem
            // 
            editarTareaToolStripMenuItem.Name = "editarTareaToolStripMenuItem";
            editarTareaToolStripMenuItem.Size = new Size(180, 22);
            editarTareaToolStripMenuItem.Text = "Editar Tarea";
            editarTareaToolStripMenuItem.Click += EditarTarea;
            // 
            // eliminarTareaToolStripMenuItem
            // 
            eliminarTareaToolStripMenuItem.Name = "eliminarTareaToolStripMenuItem";
            eliminarTareaToolStripMenuItem.Size = new Size(180, 22);
            eliminarTareaToolStripMenuItem.Text = "Eliminar Tarea";
            // 
            // lstTareas
            // 
            lstTareas.Dock = DockStyle.Fill;
            lstTareas.FormattingEnabled = true;
            lstTareas.ItemHeight = 15;
            lstTareas.Location = new Point(0, 24);
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(800, 426);
            lstTareas.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstTareas);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Gestor de Tareas";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem tareasToolStripMenuItem;
        private ToolStripMenuItem agregarTareaToolStripMenuItem;
        private ToolStripMenuItem editarTareaToolStripMenuItem;
        private ToolStripMenuItem eliminarTareaToolStripMenuItem;
        private ListBox lstTareas;
    }
}