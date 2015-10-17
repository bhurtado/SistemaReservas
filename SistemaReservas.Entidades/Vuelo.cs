using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using SistemaReservas.Validacion;

namespace SistemaReservas.Entidades
{
    [MetadataType(typeof(VueloMetadata))]
    public class Vuelo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
    }
}
