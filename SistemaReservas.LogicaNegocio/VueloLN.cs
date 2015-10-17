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
    public class VueloLN : IVueloLN
    {
         private readonly IVueloDAO vueloDAO;

        public VueloLN()
        {
            vueloDAO = new VueloDAO();
        }
        public VueloLN(IVueloDAO dao)
        {
            vueloDAO = dao;
        }

        public IEnumerable<Entidades.Vuelo> LeerTodos()
        {
            return vueloDAO.LeerTodos();
        }

        public Entidades.Vuelo LeerVuelo(Entidades.Vuelo vuelo)
        {
            return vueloDAO.LeerVuelo(vuelo);
        }

        public int Insertar(Entidades.Vuelo vuelo)
        {
            return vueloDAO.Insertar(vuelo);
        }

        public bool Actualizar(Entidades.Vuelo vuelo)
        {
            return vueloDAO.Actualizar(vuelo);
        }

        public bool Eliminar(Entidades.Vuelo vuelo)
        {
            return vueloDAO.Eliminar(vuelo);
        }
    }
}
