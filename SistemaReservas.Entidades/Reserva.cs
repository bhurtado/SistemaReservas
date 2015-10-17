using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using SistemaReservas.Validacion;

namespace SistemaReservas.Entidades
{
    [MetadataType(typeof(ReservaMetadata))]
    public class Reserva
    {
        public int ID { get; set; }

        public Vuelo NumeroVuelo { get; set; }
        public int? NumeroVueloID { get; set; }

        public Cliente Pasajero { get; set; }
        public int? PasajeroID { get; set; }

        public int Cantidad { get; set; }
        public string Email { get; set; }

    }
}
