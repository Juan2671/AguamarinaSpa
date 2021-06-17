using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Areas.Productos.Models
{
    public class Producto
    {
        [Required]
        [Display(Name = "ID Ingresiente")]
        [Key]
        public int IngredienteId { set; get; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(40, ErrorMessage = "Debe contener como minimo 3 y maximo 40 caracteres.", MinimumLength = 3)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Descripción requerida")]
        [Display(Name = "Descripción")]
        [StringLength(150, ErrorMessage = "Debe contener como minimo 3 y maximo 150 caracteres.", MinimumLength = 3)]
        public string Descripcion { get; set; }

        [Display(Name = "Imagen")]
        public string Imagen { get; set; }

        [Required(ErrorMessage = "Categoria requerida")]
        [Display(Name = "Categoria")]
        public int CategoriaProductosId { get; set; }

        [Required(ErrorMessage = "Estado requerido")]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        public CategoriaProductos Categoria { get; set; }

       
        [NotMapped]
        public List<CategoriaProductos> Categorias { get; set; }
        
        [NotMapped]
        [Display(Name = "Imagen")]
        public IFormFile ImagenCarga { get; set; }

    }
}
