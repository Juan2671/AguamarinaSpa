using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Areas.Servi.Models;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.Paginador;

namespace WebApplication1.Areas.Usu.Controllers
{
    [Area("Usu")]

    [Authorize]
    public class UsuarioController : Controller
    {
        public ApplicationDbContext _dbContext;

        public UsuarioController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index(int Pag, int Registros, string Search)
        {
            List<Usuarios> usuarios = null;
            string host = Request.Scheme + "://" + Request.Host.Value;
            if (Search != null)
            {
                usuarios = _dbContext.Usuario.Where(e => e.Nombre.Contains(Search)).ToList();
            }
            else
            {
                usuarios = _dbContext.Usuario.ToList();
            }

            object[] resultado = new Paginador<Usuarios>().paginador(usuarios, Pag, Registros, "Usu", "Usuario", "Index", host);

            DataPaginador<Usuarios> modelo = new DataPaginador<Usuarios>
            {
                Lista = (List<Usuarios>)resultado[2],
                Pagi_info = (string)resultado[0],
                Pagi_navegacion = (string)resultado[1],
                Search = Search,
                Registros = Registros,
                Modelo = new Usuarios()
            };

            return View(modelo);
        }

        public IActionResult Agregar()
        {

            Usuarios usuario = new Usuarios();

            return View(usuario);
        }

        public IActionResult ComprasRealizadas()
        {

            return View();
        }

        public IActionResult Guardar(Usuarios usuario)
        {

            if (!ModelState.IsValid)
            {

                if (usuario.Id == null)
                {
                    return View("Agregar", usuario);
                }

            }

            try
            {
                if (usuario.Id == null)
                {
                    _dbContext.Add(usuario);
                }

                _dbContext.SaveChanges();
            }
            catch (Exception e)
            {

            }

            return RedirectToAction("Index");
        }

        public IActionResult IndexDos() {
            return View();
        }

        public IActionResult Editar(string id)
        {

            Usuarios usuario = _dbContext.Usuario.Find(id);

            if (usuario == null)
            {
                return RedirectToAction("Index");
            }

            return View(usuario);

        }

        public IActionResult Modificar(Usuarios usuario)
        {
            if (!ModelState.IsValid)
            {
                Usuarios usuarios = _dbContext.Usuario.Find(usuario.Id);
                
                usuarios.Nombre = usuario.Nombre;
                usuarios.Email = usuario.Email;
                usuarios.Apellido = usuario.Apellido;
                usuarios.Documento = usuario.Documento;
                usuarios.UserName = usuario.Email;
                usuarios.NormalizedEmail = usuario.Email.ToUpper();
                usuarios.NormalizedUserName = usuario.Email.ToUpper();

                _dbContext.Update(usuarios);

                _dbContext.SaveChanges();

                return RedirectToAction("Index");

            }
            return RedirectToAction("Editar", usuario);
        }

        public IActionResult Detalle(string id)
        {

            Usuarios usuario = _dbContext.Usuario.Find(id);

            if (usuario == null)
            {
                return RedirectToAction("Index");
            }
            return View(usuario);

        }

        public IActionResult Eliminar(string id)
        {

            Usuarios usuarios = _dbContext.Usuario.Find(id);

            if (usuarios == null)
            {
                return RedirectToAction("Index");
            }

            if (usuarios.Id == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                _dbContext.Remove(usuarios);
            }

            _dbContext.SaveChanges();

            return RedirectToAction("Index");

        }

        public IActionResult Estado(string id)
        {

            Usuarios usuarios = _dbContext.Usuario.Find(id);

            if (usuarios == null)
            {
                return RedirectToAction("Index");
            }

            if (usuarios.Id == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                if (usuarios.Estado == "Desconectado")
                {

                    usuarios.Estado = "Disponible";

                }
                else if (usuarios.Estado == "Disponible")
                {

                    usuarios.Estado = "Desconectado";

                }

                _dbContext.Update(usuarios);

            }

            _dbContext.SaveChanges();

            return RedirectToAction("Index");

        }

    }
}
