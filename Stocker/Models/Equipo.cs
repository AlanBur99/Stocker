using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stocker.Models
{
    public class Equipo
    {
        private int _IdEquipo;
        private string _NombreEquipo;
        private int _FkTipoEquipo;

        public int IdEquipo { get => _IdEquipo; set => _IdEquipo = value; }
        public string NombreEquipo { get => _NombreEquipo; set => _NombreEquipo = value; }
        public int FkTipoEquipo { get => _FkTipoEquipo; set => _FkTipoEquipo = value; }


        public Equipo()
        {
            _IdEquipo = 0;
            _NombreEquipo = "";
            _FkTipoEquipo = 0;

        }


        public Equipo(int Id, int FK,string nom)
        {
            _IdEquipo = Id;
            _NombreEquipo = nom;
            _FkTipoEquipo = FK;
        }
    }
}