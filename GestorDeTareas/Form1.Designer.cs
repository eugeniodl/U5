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
            agregarTareasToolStripMenuItem = new ToolStripMenuItem();
            editarTareasToolStripMenuItem = new ToolStripMenuItem();
            eliminarTareasToolStripMenuItem = new ToolStripMenuItem();
            lstTareas = new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, tareasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(588, 24);
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
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += Salir;
            // 
            // tareasToolStripMenuItem
            // 
            tareasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarTareasToolStripMenuItem, editarTareasToolStripMenuItem, eliminarTareasToolStripMenuItem });
            tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            tareasToolStripMenuItem.Size = new Size(51, 20);
            tareasToolStripMenuItem.Text = "Tareas";
            // 
            // agregarTareasToolStripMenuItem
            // 
            agregarTareasToolStripMenuItem.Name = "agregarTareasToolStripMenuItem";
            agregarTareasToolStripMenuItem.Size = new Size(180, 22);
            agregarTareasToolStripMenuItem.Text = "Agregar Tarea";
            agregarTareasToolStripMenuItem.Click += AgregarTarea;
            // 
            // editarTareasToolStripMenuItem
            // 
            editarTareasToolStripMenuItem.Name = "editarTareasToolStripMenuItem";
            editarTareasToolStripMenuItem.Size = new Size(180, 22);
            editarTareasToolStripMenuItem.Text = "Editar Tarea";
            // 
            // eliminarTareasToolStripMenuItem
            // 
            eliminarTareasToolStripMenuItem.Name = "eliminarTareasToolStripMenuItem";
            eliminarTareasToolStripMenuItem.Size = new Size(180, 22);
            eliminarTareasToolStripMenuItem.Text = "Eliminar Tarea";
            // 
            // lstTareas
            // 
            lstTareas.Dock = DockStyle.Left;
            lstTareas.FormattingEnabled = true;
            lstTareas.ItemHeight = 15;
            lstTareas.Location = new Point(0, 24);
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(120, 310);
            lstTareas.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 334);
            Controls.Add(lstTareas);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Gestor de tareas";
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
        private ToolStripMenuItem agregarTareasToolStripMenuItem;
        private ToolStripMenuItem editarTareasToolStripMenuItem;
        private ToolStripMenuItem eliminarTareasToolStripMenuItem;
        private ListBox lstTareas;
    }
}