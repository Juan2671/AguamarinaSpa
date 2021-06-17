using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WebApplication1.Areas.Productos.Models;
using WebApplication1.Areas.Servi.Models;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.Paginador;

namespace WebApplication1.Areas.Servi.Controllers
{
    [Area("Servi")]

    [Authorize]
    public class ServicioController : Controller
    {
        public ApplicationDbContext _dbContext;
        private readonly SignInManager<Usuarios> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly UserManager<Usuarios> _userManager;

        public ServicioController(ApplicationDbContext dbContext, SignInManager<Usuarios> signInManager,
            ILogger<LoginModel> logger, UserManager<Usuarios> userManager) {
            _dbContext = dbContext;
            _signInManager = signInManager;
            _logger = logger;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index(int Pag, int Registros, string Search)
        {
            List<Servicio> servicios = null;
            string host = Request.Scheme + "://" + Request.Host.Value;
            if (Search != null)
            {
                servicios = _dbContext.Servici.Include(e => e.Categoria).Where(e => e.Nombre.Contains(Search)).ToList();
            }
            else
            {
                servicios = _dbContext.Servici.Include(e => e.Categoria).ToList();
            }

            object[] resultado = new Paginador<Servicio>().paginador(servicios, Pag, Registros, "Servi", "Servicio", "Index", host);

            DataPaginador<Servicio> modelo = new DataPaginador<Servicio>
            {
                Lista = (List<Servicio>)resultado[2],
                Pagi_info = (string)resultado[0],
                Pagi_navegacion = (string)resultado[1],
                Search = Search,
                Registros = Registros,
                Modelo = new Servicio()
            };

            return View(modelo);
        }

        public IActionResult mis_recetas(int Pag, int Registros, string Search)
        {

            List<Servicio> servicios = null;
            string host = Request.Scheme + "://" + Request.Host.Value;
            if (User.IsInRole("Usuario"))
            {
                if (_signInManager.IsSignedIn(User)) {

                    if (User.IsInRole("Admin")) {
                        if (Search != null)
                        {
                            servicios = _dbContext.Servici.Include(e => e.Categoria).Where(e => e.Nombre.Contains(Search)).ToList();
                        }
                        else
                        {
                            servicios = _dbContext.Servici.Include(e => e.Categoria).ToList();
                        }
                    }else
                    {
                        if (Search != null)
                        {
                            servicios = _dbContext.Servici.Include(e => e.Categoria).Where(e => e.Nombre.Contains(Search) && e.usuario.Email == User.Identity.Name).ToList();
                        }
                        else
                        {
                            servicios = _dbContext.Servici.Include(e => e.Categoria).Where(e => e.usuario.Email == User.Identity.Name).ToList();
                        }
                    }
                }
            }
                object[] resultado = new Paginador<Servicio>().paginador(servicios, Pag, Registros, "Servi", "Servicio", "Index", host);

                DataPaginador<Servicio> modelo = new DataPaginador<Servicio>
                {
                    Lista = (List<Servicio>)resultado[2],
                    Pagi_info = (string)resultado[0],
                    Pagi_navegacion = (string)resultado[1],
                    Search = Search,
                    Registros = Registros,
                    Modelo = new Servicio()
                };

            
            return View(modelo);
            }
        
        public IActionResult Agregar() {

            Servicio servicio = new Servicio();
            servicio.Categorias = _dbContext.Catego.ToList();
            servicio.Productos = _dbContext.ProductosGuardados.ToList();

            return View(servicio);
        }

        public async Task<int>  Guardar(string servicio1, /*string[] ingredientes, string[] cantidades*/ IFormFile imagen) {

            Servicio servicio = JsonConvert.DeserializeObject<Servicio>(servicio1);
    
            if (!ModelState.IsValid) {
                servicio.Categorias = _dbContext.Catego.ToList();

                if (servicio.ResetaId == 0)
                {
                    return 0;
                }
                else {
                    return 0;
                }
            }
            try
            {
                if (servicio.ResetaId == 0)
                {
                    servicio.ImagenCarga = imagen;
                    servicio.Categoria = _dbContext.Catego.Find(servicio.CategoriaId);
                    if (_signInManager.IsSignedIn(User)) {

                        servicio.usuario = await _userManager.FindByEmailAsync(User.Identity.Name);
                    
                    }
                    if (servicio.ImagenCarga != null)
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads", servicio.ImagenCarga.FileName);

                        using (var stream = System.IO.File.Create(path))
                        {
                            servicio.ImagenCarga.CopyTo(stream);
                            servicio.Imagen = servicio.ImagenCarga.FileName;
                        }
                    }
                    else
                    {
                        servicio.Imagen = "defaulti.png";
                    }

                    _dbContext.Add(servicio);
                }
                else {
                    _dbContext.Update(servicio);
                }

                _dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                return 0;
            }
            return 1;
        }

        public int Ingredientes(string ingredientes, string cantidades)
        {

            string[] can = cantidades.Split(',');
            string[] ing = ingredientes.Split(',');

            List<Servicio> lista = _dbContext.Servici.ToList();

            int contador = 0;

            foreach (Servicio ser in lista ) {

                if (ser.ResetaId > contador) {

                    contador = ser.ResetaId;
                
                }
            
            }
            Servicio servicio = _dbContext.Servici.Find(contador);
            foreach (string item in ing) 
            {
                Servicio_Ingredinete ingrediente = new Servicio_Ingredinete();
                ingrediente.producto = _dbContext.ProductosGuardados.Find(Int32.Parse(item));
                ingrediente.cantidad = Int32.Parse(can[Array.IndexOf(ing,item)]);
                ingrediente.servicio = servicio;
                _dbContext.Add(ingrediente);

            }


            _dbContext.SaveChanges();

            return 1;

        }


        public IActionResult Editar(int id) {

            Servicio servicio = _dbContext.Servici.Find(id);
            
            servicio.Categorias = _dbContext.Catego.ToList();

            //servicio.producto = _dbContext.detalleservicio.Include(e => e.producto).Where(e => e.servicio.ResetaId == servicio.ResetaId).ToList();

            //servicio.Productos = _dbContext.ProductosGuardados.ToList();

            if (servicio == null) {
                return RedirectToAction("Index");
            }
           return View(servicio);

        }

        public IActionResult GuardarEditar(Servicio servicio) {
            Servicio servicio1 = _dbContext.Servici.Include(e => e.usuario).Where(e => e.ResetaId == servicio.ResetaId).Single();

            //servicio.usuario = servicio1.usuario;

            if (!ModelState.IsValid)
            {
                return View("Editar",servicio);

            }

            if (servicio.ImagenCarga != null)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads", servicio.ImagenCarga.FileName);

                using (var stream = System.IO.File.Create(path))
                {
                    servicio.ImagenCarga.CopyTo(stream);
                    servicio1.Imagen = servicio.ImagenCarga.FileName;
                }
            }
            
            servicio1.Categoria = _dbContext.Catego.Find(servicio.CategoriaId);
            servicio1.Nombre = servicio.Nombre;
            servicio1.Estado = servicio.Estado;
            servicio1.Fecha = servicio.Fecha;
            servicio1.Descripcion = servicio.Descripcion;
            _dbContext.Servici.Update(servicio1);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
 
        }

        public IActionResult Eliminar(int id)
        {
            Servicio servicio = _dbContext.Servici.Find(id);
            servicio.producto = _dbContext.detalleservicio.Include(e => e.producto).Where(e => e.servicio.ResetaId == servicio.ResetaId ).ToList();

            if (servicio == null)
            {
                return RedirectToAction("Index");
            }

            if (servicio.ResetaId == 0)
            {
                return RedirectToAction("Index");
            }
            
            else {

                foreach (Servicio_Ingredinete item in servicio.producto)
                {

                    _dbContext.Remove(item);
                }

                _dbContext.Remove(servicio);
            }

            _dbContext.SaveChanges();

            return RedirectToAction("Index");

        }

        public IActionResult EditarI(int id)
        {

            List<Servicio_Ingredinete> servicio_ingrediente = _dbContext.detalleservicio.Include(e => e.producto).Where(e => e.servicio.ResetaId == id).ToList();
            ViewBag.productos = _dbContext.ProductosGuardados.ToList();
            ViewBag.id = id;

            if (servicio_ingrediente == null)
            {
                return RedirectToAction("Index");
            }
            return View(servicio_ingrediente);

        }

        public int GuardarEditarI(string ingredientes, string cantidades, int id)
        {

            string[] can = cantidades.Split(',');
            string[] ing = ingredientes.Split(',');
            List<Servicio_Ingredinete> lista = _dbContext.detalleservicio.Include(e => e.producto).Where(e => e.servicio.ResetaId == id).ToList();
            Servicio servicio = _dbContext.Servici.Find(id);
            foreach (Servicio_Ingredinete item in lista)
            {
                _dbContext.Remove(item);
            }

            int con = 0;

            foreach (string listo in ing)
            {
                Servicio_Ingredinete detalle = new Servicio_Ingredinete();
                Producto producto = _dbContext.ProductosGuardados.Find(Int32.Parse(listo));
                detalle.servicio = servicio;
                detalle.producto = producto;
                detalle.cantidad = Int32.Parse(can[con]);
                _dbContext.Add(detalle);
                con++;
            }

            _dbContext.SaveChanges();
            return 1;
        
        }


            public IActionResult CambiarEstado(int id)
        {

            Servicio servicio = _dbContext.Servici.Find(id);


            if (servicio == null)
            {
                return RedirectToAction("Index");
            }

            if (servicio.ResetaId == 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                if (servicio.Estado == "Agotado") {

                    servicio.Estado = "Disponible";

                } else if (servicio.Estado == "Disponible") {

                    servicio.Estado = "Agotado";

                }

                _dbContext.Update(servicio);

            }

            _dbContext.SaveChanges();

            return RedirectToAction("Index");

        }

        public IActionResult Detalle(int id)
        {
           
           List<Servicio_Ingredinete> servicio_ingrediente = _dbContext.detalleservicio.Include(e => e.producto).Where(e => e.servicio.ResetaId == id).ToList();

            if (servicio_ingrediente == null)
            {
                return RedirectToAction("Index");
            }
            return View(servicio_ingrediente);

        }

        public IActionResult IndexDos(int Pag, int Registros, string Search) {
            List<Servicio> servicios = null;
            string host = Request.Scheme + "://" + Request.Host.Value;
            if (Search != null)
            {
                servicios = _dbContext.Servici.Include(e => e.Categoria).Where(e => e.Nombre.Contains(Search)).ToList();
            }
            else
            {
                servicios = _dbContext.Servici.Include(e => e.Categoria).ToList();
            }

            object[] resultado = new Paginador<Servicio>().paginador(servicios, Pag, Registros, "Servi", "Servicio", "IndexDos", host);

            DataPaginador<Servicio> modelo = new DataPaginador<Servicio>
            {
                Lista = (List<Servicio>)resultado[2],
                Pagi_info = (string)resultado[0],
                Pagi_navegacion = (string)resultado[1],
                Search = Search,
                Registros = Registros,
                Modelo = new Servicio()
            };

            return View(modelo);
        }
    }
}
