using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SistemaReservas.Validacion
{
    public class ReservaMetadata
    {
     [Display(Name="Numero de Boletos:")]
        [Required(ErrorMessage="Debe colocar la cantidad de boletos")]
        [Range(1,5, ErrorMessage="Cantidad valida de Boletos entre 1 y 5")]
        public int Cantidad{get; set;}

        [Display(Name="Correo Electronico")]
        [EmailAddress(ErrorMessage="Correo invalido")]
        public string Email {get; set;}
    }
}
