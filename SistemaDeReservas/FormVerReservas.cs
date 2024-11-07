using System;
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
    public partial class FormVerReservas : Form
    {
        public FormVerReservas(List<Reserva> reservas)
        {
            InitializeComponent();
            ConfigurarTableLayoutPanel(reservas);
        }

        private void ConfigurarTableLayoutPanel(List<Reserva> reservas)
        {
            if (reservas == null || !reservas.Any())
            {
                MessageBox.Show("No hay reservas para mostrar.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int row = 1;
            foreach (Reserva reserva in reservas)
            {
                tableLayoutPanel.Controls.Add(new Label() { Text = reserva.Nombre }, 0, row);
                tableLayoutPanel.Controls.Add(new Label() { Text = reserva.FechaReserva.ToShortDateString() }, 1, row);
                tableLayoutPanel.Controls.Add(new Label() { Text = reserva.TipoHabitacion.ToString() }, 2, row);
                row++;
            }
        }
    }
}
