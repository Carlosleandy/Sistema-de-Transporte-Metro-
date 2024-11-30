using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MetroWeb.Models
{ // Carlos L. Comenteario = Aquí están las propiedades que funcionan como columna dentro de nuestra tabla. 
  // Los campos Required son Obligatorios. 
    public class Usuario 
    {
        public int IdUsuario { get; set; }

        [Required]
        public string NombreCompleto { get; set; }

        [Required]
        [EmailAddress]
        public string Correo { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Clave { get; set; }

        [Required]
        public string Cedula { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
    }
}
