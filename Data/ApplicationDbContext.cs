using GestionFacturasApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionFacturasApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Define los DbSet para las entidades que representan tus tablas en la base de datos
        public DbSet<FacturaCabecera> FacturasCabecera { get; set; }
        public DbSet<FacturaDetalle> FacturasDetalle { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
    }
}
