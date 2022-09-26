using System.ComponentModel.DataAnnotations;

namespace ManteCompu.App.Models
{
    public class Cliente
    {
        
        [Key]
        public int idCliente { get; set; }
        
        //*Relación con la clase Usuario | Creación de la llave Foranea
        public Usuario usuario { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string Rut { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string formaPago { get; set; }
        
       
    }
}