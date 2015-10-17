using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

using SistemaReservas.Validacion;

namespace SistemaReservas.Entidades
{
    [MetadataType(typeof(ClienteMetadata))]
    public class Cliente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
     
        public string NombreCompleto
        {
            get
            {
                return Apellido + "  " + Nombre;
            }
        }
    }
}
