using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Areas.Productos.Models;

namespace WebApplication1.Areas.Servi.Models
{
    public class Servicio_Ingredinete
    {
        
        public int id { set; get; }
        public Servicio servicio { set; get; }
        public Producto producto { set; get; }
        public int cantidad { set; get; }

        //[NotMapped]
        //public List<Producto> productos { set; get; }

    }
}
