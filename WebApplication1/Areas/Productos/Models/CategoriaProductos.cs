using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Areas.Productos.Models
{
    public class CategoriaProductos
    {
        [Display(Name = "ID Categoria")]
        [Required(ErrorMessage = "ID de categoria requerido")]
        public int CategoriaProductosId { get; set; }

        [Display(Name = "Nombre Categoria")]
        [Required(ErrorMessage = "Nombre de categoria requerido")]
        [StringLength(40, ErrorMessage = "Debe contener como minimo 3 y maximo 40 caracteres.", MinimumLength = 3)]
        public string NombreCategoria { get; set; }

        public ICollection<Producto> Productos { get; set; }
    }
}
