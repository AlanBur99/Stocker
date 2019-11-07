using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stocker.Models
{
    public class TiposEquipo
    {
        private int _IdTipoEquipo;
        private string _TipoEquipo;


        public int IdTipoEquipo { get => _IdTipoEquipo; set => _IdTipoEquipo = value; }
        public string TipoEquipo { get => _TipoEquipo; set => _TipoEquipo = value; }



        public TiposEquipo()
        {
            _IdTipoEquipo = 0;
            _TipoEquipo = "";

        }


        public TiposEquipo(int Id, string nom)
        {
            _IdTipoEquipo = Id;
            _TipoEquipo = nom;
        }


    }
}