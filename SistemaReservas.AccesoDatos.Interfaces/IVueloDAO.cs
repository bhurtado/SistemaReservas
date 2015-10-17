using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaReservas.Entidades;

namespace SistemaReservas.AccesoDatos.Interfaces
{
    public interface IVueloDAO
    {
        IEnumerable<Vuelo> LeerTodos();
        Vuelo LeerVuelo(Vuelo vuelo);
        int Insertar(Vuelo vuelo);
        bool Actualizar(Vuelo vuelo);
        bool Eliminar(Vuelo vuelo);
    }
}
