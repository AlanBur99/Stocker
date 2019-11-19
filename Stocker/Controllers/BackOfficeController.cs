using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stocker.Models;

namespace Stocker.Controllers
{
    public class BackOfficeController : Controller
    {
        [HttpPost]
        public ActionResult Index(Usuario user)
        {
            if (ModelState.IsValid)
            {
                bool Cierto = BD.BuscarUsuario(user);
                if (Cierto == true)
                {
                    ViewBag.ListaProdu = BD.ListadoDeProductosBack();
                    return View();
                }
                else
                {
                    return View("Login", user);
                }
            }
            else
            {
                return View("Login", user);
            }
        }
        public ActionResult Login()
        {
            return View();
        }


        public ActionResult Destacar(int Id)
        {
            BD.Destacar(Id);

            ViewBag.ListaProdu = BD.ListadoDeProductosBack();
            return View("Index");

        }
        public ActionResult SacarDestacar(int Id)
        {
            BD.SacarDestacar(Id);

            ViewBag.ListaProdu = BD.ListadoDeProductosBack();
            return View("Index");

        }

        public ActionResult Crear()
        {
            ViewBag.ListaTipoProdu = BD.ListadoDeProductosBack();
            ViewBag.Accion = "Crear";
            return View("CreaoEdita");
        }
        public ActionResult Editar(int Id)
        {
            ViewBag.ListaTipoProdu = BD.ListadoDeProductosBack();
            Productos Prod = BD.TraerProducto(Id);
            ViewBag.Accion = "Editar";
            return View("CreaoEdita", Prod);
        }

        public ActionResult Eliminar(int Id)
        {
            BD.BorrarProd(Id);
            ViewBag.ListaProdu = BD.ListadoDeProductosBack();
            return View("Index");
        }

        [HttpPost]
        public ActionResult ValidarNoti(Productos Prod, string Accion)
        {
            if (ModelState.IsValid)
            {
                if (Prod.ImagenFile != null)
                {

                    string NuevaUbicacion = Server.MapPath("~/Content/") + Prod.ImagenFile.FileName;

                    Prod.ImagenFile.SaveAs(NuevaUbicacion);

                    Prod.Imagen = Prod.ImagenFile.FileName;

                }

                if (Accion == "Editar")
                {
                    BD.EditarProd(Prod);
                }
                else
                {
                    BD.CrearProducto(Prod);
                }
                ViewBag.ListaProdu = BD.ListadoDeProductosBack();
                return View("Index");
            }

            else
            {
                ViewBag.ListaTipoProdu = BD.ListadoDeProductosBack();
                ViewBag.Accion = Accion;
                return View("CreaoEdita", Prod);
            }
        }
    }
}