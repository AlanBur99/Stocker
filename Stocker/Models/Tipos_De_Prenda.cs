using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stocker.Models
{
    public class Tipos_De_Prenda
    {
        private int _IdTipoPrenda;
        private string _NombreTipoPrenda;


        public int IdTipoPrenda { get => _IdTipoPrenda; set => _IdTipoPrenda = value; }
        public string NombreTipoPrenda { get => _NombreTipoPrenda; set => _NombreTipoPrenda = value; }


        public Tipos_De_Prenda()
        {
            _IdTipoPrenda = 0;
            _NombreTipoPrenda = "";

        }


        public Tipos_De_Prenda(int Id, string nom)
        {
            _IdTipoPrenda = Id;
            _NombreTipoPrenda = nom;
        }


    }
}