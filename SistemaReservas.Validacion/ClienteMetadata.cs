using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SistemaReservas.Validacion
{
    public class ClienteMetadata
    {
        [Display(Name = "Nombre:")]
        [Required(ErrorMessage = "Se requiere un nombre")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 50 caracteres")]
        public string Nombre { get; set; }
    }
}
