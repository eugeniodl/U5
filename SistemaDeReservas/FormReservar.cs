﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeReservas
{
    public partial class FormReservar : Form
    {
        private List<Reserva> listaReservas = new List<Reserva>();
        public FormReservar()
        {
            InitializeComponent();
            ConfigurarComboBoxTipoHabitacion();
        }

        private void ConfigurarComboBoxTipoHabitacion()
        {
            cmbTipoHabitacion.DataSource = Enum.GetValues(typeof(TipoHabitacion));
            cmbTipoHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoHabitacion.SelectedIndex = 0;
        }

        private void Guardar(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fechaReserva = dtpFecha.Value;
            TipoHabitacion? tipoHabitacion = cmbTipoHabitacion.SelectedItem as TipoHabitacion?;

            if(string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if(tipoHabitacion == null)
            {
                MessageBox.Show("Seleccione un tipo de habitación válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Agregar la nueva reserva a la lista
            var nuevaReserva = new Reserva
            {
                Nombre = nombre,
                FechaReserva = fechaReserva,
                TipoHabitacion = tipoHabitacion.Value
            };

            listaReservas.Add(nuevaReserva);

            // Confirmación al usuario
            MessageBox.Show($"Reserva guardada con éxito:\nNombre: {nombre}" +
                $"\nFecha: {fechaReserva.ToShortDateString()}" +
                $"\nTipo de Habitación: {tipoHabitacion}", "Confirmación",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los campos después de guardar
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            cmbTipoHabitacion.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Now;
        }

        public List<Reserva> ObtenerListaReservas()
        {
            return new List<Reserva>(listaReservas); // Devuelve una copia para evitar modificaciones externas
        }
    }
}
