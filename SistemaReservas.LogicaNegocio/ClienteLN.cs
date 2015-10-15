using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaReservas.LogicaNegocio.Interfaces;

namespace SistemaReservas.LogicaNegocio
{
    public class ClienteLN : IClienteLN
    {


        public IEnumerable<Entidades.Cliente> LeerTodos()
        {
            throw new NotImplementedException();
        }

        public Entidades.Cliente LeerCliente(Entidades.Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public int Insertar(Entidades.Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public bool Actualizar(Entidades.Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Entidades.Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
