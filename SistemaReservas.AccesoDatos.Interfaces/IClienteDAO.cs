using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaReservas.Entidades;

namespace SistemaReservas.AccesoDatos.Interfaces
{
    interface IClienteDAO
    {
        public IEnumerable<Cliente> LeerTodos();
        public Cliente LeerCliente(Cliente cliente);
        public int Insertar(Cliente cliente);
        public bool Actualizar(Cliente cliente);
        public bool Eliminar(Cliente cliente);
    }
}
