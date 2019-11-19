using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Stocker.Models
{
    public class Usuario
    {
        private string _Username;
        private string _Password;
        private string _Nombre;

        [Required(ErrorMessage = "El usuario es obligatorio")]
        public string Username { get => _Username; set => _Username = value; }
        [Required(ErrorMessage = "La password es obligatoria")]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "Contraseña debe ser mayor a 6 caracteres y menor a 15")]
        public string Password { get => _Password; set => _Password = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
    }
}
