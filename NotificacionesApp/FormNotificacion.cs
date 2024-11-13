﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificacionesApp
{
    public partial class FormNotificacion : Form
    {
        public FormNotificacion()
        {
            InitializeComponent();
        }

        private void Confirmar(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una categoría principal.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("¿Desea guardar estas configuraciones?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.No)
            {
                return;
            }

            string resumen = GenerarResumenConfiguracion();
            MessageBox.Show(resumen, "Resumen de Selección",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GenerarResumenConfiguracion()
        {
            string notificaciones = chkNotificaciones.Checked ? "Sí" : "No";
            string boletin = chkBoletin.Checked ? "Sí" : "No";
            string tipoUsuario = rbtnEstudiante.Checked ? "Estudiante" :
                (rbtnProfesional.Checked ? "Profesional" : "No seleccionado");
            string categoria = cmbCategoria.SelectedItem != null ?
                cmbCategoria.SelectedItem.ToString() : "No seleccionada";
            string categoriasSeleccionadas = lstCategorias.SelectedItems.Count > 0
                ? string.Join(", ", lstCategorias.SelectedItems.Cast<string>())
                : "Ninguna";
            var opcionesAdicionales =
                clsOpcionesAdicionales.CheckedItems.Cast<string>();
            string opcionesSeleccionadas = opcionesAdicionales.Any() ?
                string.Join(", ", opcionesAdicionales) : "Ninguna";

            return $"Notificaciones: {notificaciones}\n" +
                $"Boletín: {boletin}\n" +
                $"Tipo de usuario: {tipoUsuario}\n" +
                $"Categoría Principal: {categoria}\n" +
                $"Categorías de Notificación: {categoriasSeleccionadas}\n" +
                $"Opciones Adicionales: {opcionesSeleccionadas}";
        }

        private void Guardar(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string resumen = GenerarResumenConfiguracion();
                File.WriteAllText(saveFileDialog.FileName, resumen);
                MessageBox.Show("Configuración guardada exitosamente.",
                    "Información", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void Cargar(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] configuracion = File.ReadAllLines(openFileDialog.FileName);
                AplicarConfiguracion(configuracion);
                MessageBox.Show("Configuración cargada exitosamente.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AplicarConfiguracion(string[] configuracion)
        {
            chkNotificaciones.Checked = configuracion.Contains("Notificaciones: Sí");
            chkBoletin.Checked = configuracion.Contains("Boletín: Sí");
            rbtnEstudiante.Checked = configuracion
                .Contains("Tipo de usuario: Estudiante");
            rbtnProfesional.Checked = configuracion
                .Contains("Tipo de usuario: Profesional");

            string categoria = configuracion.FirstOrDefault(line => line
            .StartsWith("Categoría Principal: "))?.Split(':')[1].Trim();

            if(!string.IsNullOrEmpty(categoria) 
                && cmbCategoria.Items.Contains(categoria))
            {
                cmbCategoria.SelectedItem = categoria;
            }

            string categoriasSeleccionadas = configuracion.FirstOrDefault(
                line => line.StartsWith("Categorías de Notificación: "))?
                .Split(":")[1].Trim();

            if(!string.IsNullOrEmpty(categoriasSeleccionadas))
            {
                foreach (string categoriaSeleccionada 
                    in categoriasSeleccionadas.Split(',').Select(c => c.Trim()))
                {
                    int index = lstCategorias.Items
                        .IndexOf(categoriaSeleccionada);
                    if(index >= 0)
                    {
                        lstCategorias.SetSelected(index, true);
                    }
                }
            }

            string opcionesAdicionales = configuracion.FirstOrDefault(
                line => line.StartsWith("Opciones Adicionales: "))?
                .Split(':')[1].Trim();

            if(!string.IsNullOrEmpty(opcionesAdicionales))
            {
                foreach (string opcion in opcionesAdicionales.Split(',')
                    .Select(op => op.Trim()))
                {
                    int index = clsOpcionesAdicionales.Items.IndexOf(opcion);
                    if(index >= 0)
                    {
                        clsOpcionesAdicionales.SetItemChecked(index, true);
                    }
                }
            }
        }
    }
}
