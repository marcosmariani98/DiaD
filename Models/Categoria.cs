using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace DiaD.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Titulo { get; set; }
        public int Precio { get; set; }

        public string Descripcion {get; set; }

        public List<Producto> Productos { get; set; }
    }
}