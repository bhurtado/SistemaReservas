using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaReservas.Entidades;

namespace SistemaReservas.AccesoDatos.Interfaces
{
    public interface IReservaDAO
    {
        IEnumerable<Reserva> LeerTodos();
        Reserva LeerReserva(Reserva reserva);
        int Insertar(Reserva reserva);
        bool Actualizar(Reserva reserva);
        bool Eliminar(Reserva reserva);
    }
}
