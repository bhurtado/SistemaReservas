using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaReservas.Entidades;
using SistemaReservas.AccesoDatos.Interfaces;

namespace SistemaReservas.AccesoDatos
{
    public class ClienteDAO : IClienteDAO
    {

        public IEnumerable<Cliente> LeerTodos()
        {
            throw new NotImplementedException();
        }

        public Cliente LeerCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public int Insertar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public bool Actualizar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
