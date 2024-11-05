using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeReservas
{
    public enum TipoHabitacion
    {
        Simple,
        Doble,
        Suite
    }

    public class Reserva
    {
        public string Nombre { get; set; }
        public DateTime FechaReserva { get; set; }
        public TipoHabitacion TipoHabitacion { get; set; }
    }
}
