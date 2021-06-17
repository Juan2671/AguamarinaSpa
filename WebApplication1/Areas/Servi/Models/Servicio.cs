using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Areas.Productos.Models;
using WebApplication1.Models;

namespace WebApplication1.Areas.Servi.Models
{
    public class Servicio
    {

        [Required]
        [Display(Name = "ID Reseta")]
        [Key]
        public int ResetaId { set; get; }

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

        [Required(ErrorMessage = "La Fecha es requerida")]
        [Display(Name = "FechaActual")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Categoria requerida")]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Estado requerido")]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        public Categoria Categoria { get; set; }

        public Usuarios usuario { get; set; }

        [NotMapped]
        public List<Categoria> Categorias { get; set; }

        [NotMapped]
        public List<Producto> Productos { get; set; }

        [NotMapped]
        public List<Servicio_Ingredinete> producto { get; set; }

        [NotMapped]
        [Display(Name = "Imagen")]
        public IFormFile ImagenCarga { get; set; }

        
    }
}
