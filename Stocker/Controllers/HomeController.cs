using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stocker.Models;

namespace Stocker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Productos Destacado = new Productos();
            List<Tipos_De_Prenda> ListaProd = new List<Tipos_De_Prenda>();
            Destacado = BD.Destacada();
            ListaProd = BD.ListadoTipoProducto();
            ViewBag.Titulo = Destacado.Titulo;
            ViewBag.Imagen = Destacado.Imagen;
            ViewBag.Precio = Destacado.Precio;
            ViewBag.Id = Destacado.IdProducto;
            ViewBag.ListaProd = ListaProd;

            Productos ProdReBaja = new Productos();
            List<Tipos_De_Prenda> ListaaProd = new List<Tipos_De_Prenda>();
            ProdReBaja = BD.ProdReBaja();
            ListaaProd = BD.ListadoTipoProducto();
            ViewBag.Titulo1 = ProdReBaja.Titulo;
            ViewBag.Imagen1 = ProdReBaja.Imagen;
            ViewBag.Precio1 = ProdReBaja.Precio;
            ViewBag.Id1 = ProdReBaja.IdProducto;
            ViewBag.ListaaProd = ListaaProd;
            return View();
        }

        public ActionResult DetalleProducto(int Id)
        {
            Productos Pro = new Productos();
            Pro = BD.TraerProducto(Id);
            ViewBag.Pro = Pro;

            return View();
        }

        public ActionResult Login()
        {
            return View("Login");
        }


     //  public ActionResult ListadoDeProductos(int IdPro)
     //  {
     //      List<Productos> ListaProd = new List<Productos>();
     //      ListaProd = BD.ListadoDeProductosXTipo(IdPro);
     //      ViewBag.ListaProd = ListaProd;
     //
     //      return View();
     //  }


    }
}