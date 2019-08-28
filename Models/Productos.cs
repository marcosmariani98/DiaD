using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace DiaD.Models
{

public class Producto 
    {
        [Key]
        public int ProductoId { get; set; }
        public int Precio {get; set;}
        public string Titulo {get; set;}
        public int Descripcion {get; set;}

        public int CategoriaId {get; set;}

        public Categoria Categoria { get; set; }

    }
}