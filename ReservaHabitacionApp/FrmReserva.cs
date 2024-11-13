using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaHabitacionApp
{
    public partial class FrmReserva : Form
    {
        public FrmReserva()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e)
        {
            // Crear instancia de la clase ReservaHabitacion
            DateTime fechaEntrada = dtpFechaEntrada.Value;
            int diasEstancia = (int)nudDiasEstancia.Value;
            var reserva = new ReservaHabitacion(fechaEntrada, diasEstancia);

            // Calcular la fecha de salida y el precio total
            DateTime fechaSalida = reserva.CalcularFechaSalida();
            decimal precioTotal = reserva.CalcularPrecioTotal();

            // Mostrar el resultado en el Label
            lblPrecioTotal.Text = $"Total: ${precioTotal} " +
                $"(Estancia hasta: {fechaSalida.ToShortDateString()})";
        }
    }
}
