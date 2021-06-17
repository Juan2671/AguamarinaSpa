using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Areas.Servi.Models;
using WebApplication1.Data;
using WebApplication1.Models.Paginador;

namespace WebApplication1.Areas.Catego.Controllers
{
    [Area("Catego")]
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
            List<Categoria> Categorias = null;
            string host = Request.Scheme + "://" + Request.Host.Value;
            if (Search != null)
            {
                Categorias = _dbContext.Catego.Where(e => e.NombreCategoria.Contains(Search)).ToList();
            }
            else
            {
                Categorias = _dbContext.Catego.ToList();
            }

            object[] resultado = new Paginador<Categoria>().paginador(Categorias, Pag, Registros, "Catego", "Categoria", "Index", host);

            DataPaginador<Categoria> modelo = new DataPaginador<Categoria>
            {
                Lista = (List<Categoria>)resultado[2],
                Pagi_info = (string)resultado[0],
                Pagi_navegacion = (string)resultado[1],
                Search = Search,
                Registros = Registros,
                Modelo = new Categoria()
            };

            return View(modelo);
        }

        public IActionResult Agregar()
        {

            Categoria Categoria = new Categoria();

            return View(Categoria);
        }

        public IActionResult Guardar(Categoria Categoria)
        {

            if (!ModelState.IsValid)
            {

                if (Categoria.CategoriaId == 0)
                {
                    return View("Agregar", Categoria);
                }
                else
                {
                    return View("Editar", Categoria);
                }

            }

            try
            {
                if (Categoria.CategoriaId == 0)
                {
                    _dbContext.Add(Categoria);
                }
                else
                {
                    _dbContext.Update(Categoria);
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

            Categoria Categoria = _dbContext.Catego.Find(id);

            if (Categoria == null)
            {
                return RedirectToAction("Index");
            }

            return View(Categoria);

        }

        public IActionResult Eliminar(int id)
        {

            Categoria Categori = _dbContext.Catego.Find(id);

            if (Categori == null)
            {
                return RedirectToAction("Index");
            }

            if (Categori.CategoriaId == 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                _dbContext.Remove(Categori);
            }

            _dbContext.SaveChanges();

            return RedirectToAction("Index");

        }
        public IActionResult IndexDos()
        {
            return View();
        }
    }
}
