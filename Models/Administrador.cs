using System.ComponentModel.DataAnnotations;

namespace ManteCompu.App.Models
{
    public class Administrador
      {
        
        [Key]
        
        [Required(ErrorMessage = "Este campo es requerido")]
        public int idAdmin { get; set; }

        //*Relación con la clase Usuario
        public Usuario usuario { get; set; }
                
                  
      }
}