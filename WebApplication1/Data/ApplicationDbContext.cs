using System;
using System.Collections.Generic;

using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using WebApplication1.Areas.Productos.Models;
using WebApplication1.Areas.Servi.Models;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Categoria> Catego { get; set; }
        public DbSet<Servicio> Servici { get; set; }
        public DbSet<Servicio_Ingredinete> detalleservicio { get; set; }
        public DbSet<Producto> ProductosGuardados { get; set; }
        public DbSet<CategoriaProductos> CategoriaDeProductos { get; set;}
    }
}
