using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaReservas.Entidades;

namespace SistemaReservas.LogicaNegocio.Interfaces
{
    public interface IClienteLN
    {
        IEnumerable<Cliente> LeerTodos();
        Cliente LeerCliente(Cliente cliente);
        int Insertar(Cliente cliente);
        bool Actualizar(Cliente cliente);
        bool Eliminar(Cliente cliente);
    }
}
