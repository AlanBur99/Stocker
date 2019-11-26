using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stocker.Models
{
    public class Marcas
    {
        private int _IdMarca;
        private string _NombreMarca;


        public int IdMarca { get => _IdMarca; set => _IdMarca = value; }
        public string NombreMarca { get => _NombreMarca; set => _NombreMarca = value; }


        public Marcas()
        {
            _IdMarca = 0;
            _NombreMarca = "";

        }


        public Marcas(int Id, string nom)
        {
            _IdMarca = Id;
            _NombreMarca = nom;
        }

    }
}