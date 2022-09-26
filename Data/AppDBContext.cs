using Microsoft.EntityFrameworkCore;
using ManteCompu.App.Models;

namespace ManteCompu.App.Data
    {

        public class AppDBContext : DbContext

        {

            public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
            {

            }
            public DbSet<Usuario> Usuario { get; set; }
            public DbSet<Cliente> Cliente { get; set; }
            public DbSet<Tecnico> Tecnico { get; set; }
            public DbSet<Administrador> Administrador { get; set; }
            public DbSet<Citas> Citas { get; set; }
            public DbSet<CitasServicios> CitasServicios { get; set; }
            public DbSet<Servicio> Servicios { get; set; }
        }

    }