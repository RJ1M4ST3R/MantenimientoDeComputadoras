using System.ComponentModel.DataAnnotations;

namespace ManteCompu.App.Models
{
    public class CitasServicios
    {
        [Key]

        [Required(ErrorMessage = "Este campo es requerido.")]
        public int idCitasServicios { get; set; }

       public int idServicio { get; set; }
       public int idCitas { get; set; }
    }
}