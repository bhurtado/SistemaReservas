using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaReservas.LogicaNegocio.Interfaces;
using SistemaReservas.AccesoDatos.Interfaces;
using SistemaReservas.AccesoDatos;

namespace SistemaReservas.LogicaNegocio
{
    public class ClienteLN : IClienteLN
    {
        private readonly IClienteDAO clienteDAO;

        public ClienteLN()
        {
            clienteDAO = new ClienteDAO();
        }
        public ClienteLN(IClienteDAO dao)
        {
            clienteDAO = dao;
        }

        public IEnumerable<Entidades.Cliente> LeerTodos()
        {
            return clienteDAO.LeerTodos();
        }

        public Entidades.Cliente LeerCliente(Entidades.Cliente cliente)
        {
            return clienteDAO.LeerCliente(cliente);
        }

        public int Insertar(Entidades.Cliente cliente)
        {
            return clienteDAO.Insertar(cliente);
        }

        public bool Actualizar(Entidades.Cliente cliente)
        {
            return clienteDAO.Actualizar(cliente);
        }

        public bool Eliminar(Entidades.Cliente cliente)
        {
            return clienteDAO.Eliminar(cliente);
        }
    }
}
