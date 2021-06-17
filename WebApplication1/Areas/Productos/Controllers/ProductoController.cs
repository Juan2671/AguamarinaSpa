using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Areas.Productos.Models;
using WebApplication1.Data;
using WebApplication1.Models.Paginador;

namespace WebApplication1.Areas.Productos.Controllers
{
    [Area("Productos")]
    [Authorize]
    public class ProductoController : Controller
    {
        public ApplicationDbContext _dbContext;

        public ProductoController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index(int Pag, int Registros, string Search)
        {
            List<Producto> Productos = null;
            string host = Request.Scheme + "://" + Request.Host.Value;
            if (Search != null)
            {
                Productos = _dbContext.ProductosGuardados.Include(e => e.Categoria).Where(e => e.Nombre.Contains(Search)).ToList();
            }
            else
            {
                Productos = _dbContext.ProductosGuardados.Include(e => e.Categoria).ToList();
            }

            object[] resultado = new Paginador<Producto>().paginador(Productos, Pag, Registros, "Productos", "Producto", "Index", host);

            DataPaginador<Producto> modelo = new DataPaginador<Producto>
            {
                Lista = (List<Producto>)resultado[2],
                Pagi_info = (string)resultado[0],
                Pagi_navegacion = (string)resultado[1],
                Search = Search,
                Registros = Registros,
                Modelo = new Producto()
            };

            return View(modelo);
        }
        public IActionResult Agregar()
        {

            Producto producto = new Producto();
            producto.Categorias = _dbContext.CategoriaDeProductos.ToList();

            return View(producto);
        }

        public IActionResult Guardar(Producto producto)
        {

            if (!ModelState.IsValid)
            {
                producto.Categorias = _dbContext.CategoriaDeProductos.ToList();

                if (producto.IngredienteId == 0)
                {
                    return View("Agregar", producto);
                }
                else
                {
                    return View("Editar", producto);
                }

            }

            try
            {
                if (producto.IngredienteId == 0)
                {

                    if (producto.ImagenCarga != null)
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads", producto.ImagenCarga.FileName);

                        using (var stream = System.IO.File.Create(path))
                        {
                            producto.ImagenCarga.CopyTo(stream);
                            producto.Imagen = producto.ImagenCarga.FileName;
                        }
                    }
                    else
                    {
                        producto.Imagen = "defaulti.png";
                    }

                    _dbContext.Add(producto);
                }
                else
                {
                    _dbContext.Update(producto);
                }

                _dbContext.SaveChanges();
            }
            catch (Exception e)
            {

            }

            return RedirectToAction("Index");
        }


        public IActionResult Editar(int id)
        {

            Producto producto = _dbContext.ProductosGuardados.Find(id);
            
            producto.Categorias = _dbContext.CategoriaDeProductos.ToList();

            if (producto == null)
            {
                return RedirectToAction("Index");
            }

            return View(producto);

        }

        public IActionResult Eliminar(int id)
        {

            Producto producto = _dbContext.ProductosGuardados.Find(id);

            if (producto == null)
            {
                return RedirectToAction("Index");
            }

            if (producto.IngredienteId == 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                _dbContext.Remove(producto);
            }

            _dbContext.SaveChanges();

            return RedirectToAction("Index");

        }

        public IActionResult CambiarEstado(int id)
        {

            Producto producto = _dbContext.ProductosGuardados.Find(id);


            if (producto == null)
            {
                return RedirectToAction("Index");
            }

            if (producto.IngredienteId == 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                if (producto.Estado == "Agotado")
                {

                    producto.Estado = "Disponible";

                }
                else if (producto.Estado == "Disponible")
                {

                    producto.Estado = "Agotado";

                }

                _dbContext.Update(producto);

            }

            _dbContext.SaveChanges();

            return RedirectToAction("Index");

        }
        public IActionResult IndexDos() {
            return View();
        }
    }

}
