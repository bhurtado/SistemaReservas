using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaReservas.AccesoDatos.Interfaces;

namespace SistemaReservas.AccesoDatos
{
    public class VueloDAO : IVueloDAO
    {
        ReservaDatabaseContext context = new ReservaDatabaseContext();

        public IEnumerable<Entidades.Vuelo> LeerTodos()
        {
            var vuelos = context.Vuelos;
            return vuelos.ToList();
        }

        public Entidades.Vuelo LeerVuelo(Entidades.Vuelo vuelo)
        {
            throw new NotImplementedException();
        }

        public int Insertar(Entidades.Vuelo vuelo)
        {
            context.Vuelos.Add(vuelo);
            return context.SaveChanges();
        }

        public bool Actualizar(Entidades.Vuelo vuelo)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Entidades.Vuelo vuelo)
        {
            throw new NotImplementedException();
        }
    }
}
