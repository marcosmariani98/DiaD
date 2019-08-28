using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiaD.Models
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options)
            : base(options)
        { }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias {get; set;}
        public DbSet<Cliente> Clientes { get; set; }
    }
}