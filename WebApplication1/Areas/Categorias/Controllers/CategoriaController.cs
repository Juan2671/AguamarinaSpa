using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Areas.Productos.Models;
using WebApplication1.Data;
using WebApplication1.Models.Paginador;

namespace WebApplication1.Areas.Categorias.Controllers
{
    [Area("Categorias")]
    [Authorize]
    public class CategoriaController : Controller
    {
        public ApplicationDbContext _dbContext;

        public CategoriaController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index(int Pag, int Registros, string Search)
        {
            List<CategoriaProductos> CategoriasProduct = null;
            string host = Request.Scheme + "://" + Request.Host.Value;
            if (Search != null)
            {
                CategoriasProduct = _dbContext.CategoriaDeProductos.Where(e => e.NombreCategoria.Contains(Search)).ToList();
            }
            else
            {
                CategoriasProduct = _dbContext.CategoriaDeProductos.ToList();
            }

            object[] resultado = new Paginador<CategoriaProductos>().paginador(CategoriasProduct, Pag, Registros, "Categorias", "Categoria", "Index", host);

            DataPaginador<CategoriaProductos> modelo = new DataPaginador<CategoriaProductos>
            {
                Lista = (List<CategoriaProductos>)resultado[2],
                Pagi_info = (string)resultado[0],
                Pagi_navegacion = (string)resultado[1],
                Search = Search,
                Registros = Registros,
                Modelo = new CategoriaProductos()
            };

            return View(modelo);
        }

        public IActionResult Agregar()
        {

            CategoriaProductos CategoriaProduct = new CategoriaProductos();

            return View(CategoriaProduct);
        }

        public IActionResult Guardar(CategoriaProductos CategoriaProduct)
        {

            if (!ModelState.IsValid)
            {

                if (CategoriaProduct.CategoriaProductosId == 0)
                {
                    return View("Agregar", CategoriaProduct);
                }
                else
                {
                    return View("Editar", CategoriaProduct);
                }

            }

            try
            {
                if (CategoriaProduct.CategoriaProductosId == 0)
                {
                    _dbContext.Add(CategoriaProduct);
                }
                else
                {
                    _dbContext.Update(CategoriaProduct);
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

            CategoriaProductos CategoriaProduct = _dbContext.CategoriaDeProductos.Find(id);

            if (CategoriaProduct == null)
            {
                return RedirectToAction("Index");
            }

            return View(CategoriaProduct);

        }

        public IActionResult Eliminar(int CategoriaProductosId)
        {
            
            CategoriaProductos CategoriaProduct = _dbContext.CategoriaDeProductos.Find(CategoriaProductosId);

            if (CategoriaProduct == null)
            {
                return RedirectToAction("Index");
            }

            if (CategoriaProduct.CategoriaProductosId == 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                _dbContext.Remove(CategoriaProduct);
            }

            _dbContext.SaveChanges();

            return RedirectToAction("Index");

        }
        public IActionResult IndexDos() {

            return View();
        }
    }
}       
