using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaReservas.Entidades;

namespace SistemaReservas.Models
{
    public class ReservaViewModel
    {
        public Reserva Reserva { get; set; }
        public IEnumerable<Cliente> Clientes { get; set; }
        public IEnumerable<Vuelo> Vuelos { get; set; }
    }
}