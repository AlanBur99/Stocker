using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Stocker.Models
{
    public class Productos
    {
        private int _IdProducto;
        private int _FkTipoPrenda;
        private int _FkMarca;
        private int _FkSexo;
        private int _FkEquipo;
        private string _Titulo;
        private string _Descipcion;
        private string _Imagen;
        private int _Precio;
        private bool _ReBaja;
        private bool _Destacado;

        public int IdProducto { get => _IdProducto; set => _IdProducto = value; }
        public int FkTipoPrenda { get => _FkTipoPrenda; set => _FkTipoPrenda = value; }
        public int FkMarca { get => _FkMarca; set => _FkMarca = value; }
        public int FkSexo { get => _FkSexo; set => _FkSexo = value; }
        public int FkEquipo { get => _FkEquipo; set => _FkEquipo = value; }
        [Required(ErrorMessage = "El titulo es obligatorio")]
        public string Titulo { get => _Titulo; set => _Titulo = value; }
        public string Descipcion { get => _Descipcion; set => _Descipcion = value; }
        public string Imagen { get => _Imagen; set => _Imagen = value; }
        public int Precio { get => _Precio; set => _Precio = value; }
        public bool ReBaja { get => _ReBaja; set => _ReBaja = value; }
        public bool Destacado { get => _Destacado; set => _Destacado = value; }
        public HttpPostedFileBase ImagenFile { get; set; }


        public Productos()
        {
            _IdProducto = 0;
            _FkTipoPrenda = 0;
            _FkMarca = 0;
            _FkSexo = 0;
            _FkEquipo = 0;
            _Titulo = "";
            _Descipcion = "";
            _Imagen = "";
            _Precio = 0;
            _ReBaja = false;
            _Destacado = true;

        }


        public Productos(int Id, int FkPren, int FkMar, int FkSex, int FkEqui, string tit, string Desc, string Ima, int pre, bool Baja, bool Dest)
        {
            _IdProducto = Id;
            _FkTipoPrenda = FkPren;
            _FkMarca = FkMar;
            _FkSexo = FkSex;
            _FkEquipo = FkEqui;
            _Titulo = tit;
            _Descipcion = Desc;
            _Imagen = Ima;
            _Precio = pre;
            _ReBaja = Baja;
            _Destacado = Dest;

        }


    }
}