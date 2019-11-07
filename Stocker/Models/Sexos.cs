using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stocker.Models
{
    public class Sexos
    {
        private int _IdSexo;
        private string _NombreSexo;


        public int IdSexo { get => _IdSexo; set => _IdSexo = value; }
        public string NombreSexo { get => _NombreSexo; set => _NombreSexo = value; }


        public Sexos()
        {
            _IdSexo = 0;
            _NombreSexo = "";

        }


        public Sexos(int Id, string nom)
        {
            _IdSexo = Id;
            _NombreSexo = nom;
        }

    }
}