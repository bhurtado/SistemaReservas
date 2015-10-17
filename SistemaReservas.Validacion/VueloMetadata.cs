using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SistemaReservas.Validacion
{
    public class VueloMetadata
    {
        [Display(Name="Numero de Vuelo:")]
        [Required(ErrorMessage="Debe colocar el numero de vuelo")]
        public string Nombre{get;set;}
    }
}
