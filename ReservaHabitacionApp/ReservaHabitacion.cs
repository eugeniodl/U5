using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaHabitacionApp
{
    public class ReservaHabitacion
    {
        public DateTime FechaEntrada { get; set; }
        public int DiasEstancia { get; set; }

        private const decimal PRECIOPORDIA = 100m;

        public ReservaHabitacion(DateTime fechaEntrada,
            int diasEstancia)
        {
            FechaEntrada = fechaEntrada;
            DiasEstancia = diasEstancia;
        }

        public DateTime CalcularFechaSalida()
        {
            return FechaEntrada.AddDays(DiasEstancia);
        }

        public decimal CalcularPrecioTotal()
        {
            return DiasEstancia * PRECIOPORDIA;
        }
    }
}
