using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SistemaReservas.Entidades;

namespace SistemaReservas.AccesoDatos
{
    public class ReservaDatabaseContext : DbContext
    {
        public ReservaDatabaseContext() :
            base("name=ReservaDatabase")
        { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vuelo> Vuelos { get; set; }
        
        //  Fluent  API
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Vuelo>().HasKey(t =>new {
            //    t.ID, t.Nombre});

        }
    }
}
