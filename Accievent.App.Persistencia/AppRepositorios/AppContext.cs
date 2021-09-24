using Microsoft.EntityFrameworkCore;
using Accievent.App.Dominio;

namespace Accievent.App.Persistencia
{
    public class AppContext : DbContext {

        public DbSet<Persona> Personas {get;set;}
        public DbSet<Accidente> Accidentes {get;set;}
        public DbSet<AgenteDeTransito> Agentes {get;set;}
        public DbSet<Vehiculo> Vehiculos {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            if(!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = AccieventData");
            }
        }
    }
}