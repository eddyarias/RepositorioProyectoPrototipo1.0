using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProyectoPrototipo_1._0.CLASES
{

    public class FarmaciaDbContext : DbContext
    {
        public FarmaciaDbContext()
            : base("Data Source=LAPTOP-S7D8N62P\\MSSQLSERVER10;Initial Catalog=db_farmacy;User ID=jonathan;Password=PJseverous75")
        {
        }

        public DbSet<Class_Proveedores> Proveedores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configuraciones adicionales para tu modelo de datos
            // Aquí puedes establecer relaciones, configurar propiedades, etc.
            base.OnModelCreating(modelBuilder);
        }
    }



}

