using System.ComponentModel.DataAnnotations;
namespace ManteCompu.App.Models
{
    public class Tecnico
    {
        
        [Key]
        [Required(ErrorMessage = "Este campo es requerido")]
        public int idTecnico { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string nivelEstudio { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public int numeroRegistro { get; set; }

        //*Relación con la clase Usuario | Creación de llave Foranea
        public Usuario usuario { get; set; }
        
    }
}