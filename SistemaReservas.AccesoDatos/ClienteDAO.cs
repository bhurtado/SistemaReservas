using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaReservas.Entidades;
using SistemaReservas.AccesoDatos.Interfaces;
using System.Data.Entity;

namespace SistemaReservas.AccesoDatos
{
    public class ClienteDAO : IClienteDAO
    {
        ReservaDatabaseContext context = new ReservaDatabaseContext();
       
        public IEnumerable<Cliente> LeerTodos()
        {
            var clientes = context.Clientes;
            return clientes.ToList();
        }

        public Cliente LeerCliente(Cliente cliente)
        {
            var p = context.Clientes.Where(c => c.ID == cliente.ID);
            return p.SingleOrDefault();
        }

        public int Insertar(Cliente cliente)
        {
            context.Clientes.Add(cliente);
            return context.SaveChanges();
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
