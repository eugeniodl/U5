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
        List<Reserva> reservas = new List<Reserva>();

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
            string telefono = mtbTelefono.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tipoHabitacion == null)
            {
                MessageBox.Show("Seleccione un tipo de habitación válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!mtbTelefono.MaskCompleted)
            {
                MessageBox.Show("El campo 'Teléfono' es obligatorio y debe ser completo.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbTelefono.Focus();
                return;
            }

            // Agregar la nueva reserva a la lista
            var nuevaReserva = new Reserva
            {
                Nombre = nombre,
                FechaReserva = fechaReserva,
                TipoHabitacion = tipoHabitacion.Value,
                Telefono = telefono
            };

            reservas.Add(nuevaReserva);

            MessageBox.Show($"Reserva guardada con éxito:\nNombre: {nombre}" +
                $"\nFecha: {fechaReserva.ToShortDateString()}" +
                $"\nTipo de Habitación: {tipoHabitacion}" +
                $"\nTeléfono: {telefono}",
                "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los campos después de guardar
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            cmbTipoHabitacion.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Now;
            mtbTelefono.Clear();
        }

        public List<Reserva> ObtenerReservas()
        {
            return new List<Reserva>(reservas); // Devuelve una copia para evitar modificaciones externas
        }

        private void mtbTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (!mtbTelefono.MaskCompleted)
            {
                MessageBox.Show("Por favor, complete el número de teléfono en el formato correcto.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void mtbTelefono_Validated(object sender, EventArgs e)
        {
            MessageBox.Show("Número de teléfono válido ingresado.",
                "Validación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
