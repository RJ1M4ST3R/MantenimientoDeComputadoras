using System.ComponentModel.DataAnnotations;

namespace ManteCompu.App.Models
{
    public class Servicio
     {
        [Key]

        [Required(ErrorMessage = "Este campo es requerido.")]
        public int idServicio { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        public float Preciode { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        public Boolean Estado { get; set; }
        
    }
}