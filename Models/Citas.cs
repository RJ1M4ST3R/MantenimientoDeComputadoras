using System.ComponentModel.DataAnnotations;

namespace ManteCompu.App.Models
{
    public class Citas
    {
        [Key]
       
        public int idCitas { get; set; }
        
        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime Fecha { get; set; }
        
        [Required(ErrorMessage = "Este campo es requerido")]
        public TimeSpan Horario { get; set; }

        //*Relación con la clase Cliente | Creación de la llave Foranea
        public Cliente cliente { get; set; }

        //*Relación con la clase Tecnico | Creación de la llave Foranea
        public Tecnico tecnico { get; set; }

        //*Relación con la clase Administrador | Creación de la llave Foranea
        public Administrador administrador { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public Boolean Estado { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public float totalServicio { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public float Comision { get; set; } 
    }
}