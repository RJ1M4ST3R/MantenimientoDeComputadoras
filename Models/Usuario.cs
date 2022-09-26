using System.ComponentModel.DataAnnotations;

namespace ManteCompu.App.Models
{
    public class Usuario
    {
        
        [Key]
        public int idUsuario { get; set; }
        
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string tipoIdentificacion { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string numeroIdentificacion { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string Apellido { get; set; }
        
        public DateTime fechaNacimiento { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string eMail { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string tipoUsuario { get; set; }
        
        [Required(ErrorMessage = "Este campo es requerido")]
        public Boolean estadoUsuario { get; set; }
        
                    
    }
}

