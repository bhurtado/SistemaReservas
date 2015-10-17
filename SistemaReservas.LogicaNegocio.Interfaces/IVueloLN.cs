using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaReservas.Entidades;

namespace SistemaReservas.LogicaNegocio.Interfaces
{
    public interface IVueloLN
    {
        IEnumerable<Vuelo> LeerTodos();
        Vuelo LeerVuelo(Vuelo vuelo);
        int Insertar(Vuelo vuelo);
        bool Actualizar(Vuelo vuelo);
        bool Eliminar(Vuelo vuelo);
    }
}
