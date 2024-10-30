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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            tareasToolStripMenuItem = new ToolStripMenuItem();
            agregarTareaToolStripMenuItem = new ToolStripMenuItem();
            editarTareaToolStripMenuItem = new ToolStripMenuItem();
            eliminarTareaToolStripMenuItem = new ToolStripMenuItem();
            lstTareas = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            agregarTareaToolStripMenuItem1 = new ToolStripMenuItem();
            editarTareaToolStripMenuItem1 = new ToolStripMenuItem();
            eliminarTareaToolStripMenuItem1 = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
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
            agregarTareaToolStripMenuItem.Size = new Size(147, 22);
            agregarTareaToolStripMenuItem.Text = "Agregar Tarea";
            agregarTareaToolStripMenuItem.Click += AgregarTarea;
            // 
            // editarTareaToolStripMenuItem
            // 
            editarTareaToolStripMenuItem.Name = "editarTareaToolStripMenuItem";
            editarTareaToolStripMenuItem.Size = new Size(147, 22);
            editarTareaToolStripMenuItem.Text = "Editar Tarea";
            editarTareaToolStripMenuItem.Click += EditarTarea;
            // 
            // eliminarTareaToolStripMenuItem
            // 
            eliminarTareaToolStripMenuItem.Name = "eliminarTareaToolStripMenuItem";
            eliminarTareaToolStripMenuItem.Size = new Size(147, 22);
            eliminarTareaToolStripMenuItem.Text = "Eliminar Tarea";
            eliminarTareaToolStripMenuItem.Click += EliminarTarea;
            // 
            // lstTareas
            // 
            lstTareas.ContextMenuStrip = contextMenuStrip1;
            lstTareas.Dock = DockStyle.Right;
            lstTareas.FormattingEnabled = true;
            lstTareas.ItemHeight = 15;
            lstTareas.Location = new Point(680, 24);
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(120, 426);
            lstTareas.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { agregarTareaToolStripMenuItem1, editarTareaToolStripMenuItem1, eliminarTareaToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(148, 70);
            // 
            // agregarTareaToolStripMenuItem1
            // 
            agregarTareaToolStripMenuItem1.Name = "agregarTareaToolStripMenuItem1";
            agregarTareaToolStripMenuItem1.Size = new Size(147, 22);
            agregarTareaToolStripMenuItem1.Text = "Agregar Tarea";
            agregarTareaToolStripMenuItem1.Click += AgregarTarea;
            // 
            // editarTareaToolStripMenuItem1
            // 
            editarTareaToolStripMenuItem1.Name = "editarTareaToolStripMenuItem1";
            editarTareaToolStripMenuItem1.Size = new Size(147, 22);
            editarTareaToolStripMenuItem1.Text = "Editar Tarea";
            editarTareaToolStripMenuItem1.Click += EditarTarea;
            // 
            // eliminarTareaToolStripMenuItem1
            // 
            eliminarTareaToolStripMenuItem1.Name = "eliminarTareaToolStripMenuItem1";
            eliminarTareaToolStripMenuItem1.Size = new Size(147, 22);
            eliminarTareaToolStripMenuItem1.Text = "Eliminar Tarea";
            eliminarTareaToolStripMenuItem1.Click += EliminarTarea;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(680, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "Agregar Tarea";
            toolStripButton1.Click += AgregarTarea;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "Editar Tarea";
            toolStripButton2.Click += EditarTarea;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "Eliminar Tarea";
            toolStripButton3.Click += EliminarTarea;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(680, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(lstTareas);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Gestor de Tareas";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem agregarTareaToolStripMenuItem1;
        private ToolStripMenuItem editarTareaToolStripMenuItem1;
        private ToolStripMenuItem eliminarTareaToolStripMenuItem1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}