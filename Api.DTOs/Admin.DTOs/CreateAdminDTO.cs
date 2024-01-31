using System.ComponentModel.DataAnnotations;

namespace Api.DTOs.Admin.DTOs
{
    public class CreateAdminDTO
    {
        [Display(Name ="Nombre")]
        [Required(ErrorMessage ="El campo Nombre es obligatorio")]
        [MaxLength(50,ErrorMessage = "El campo Nombre no puede tener mas de 50 caracteres.")]
        public string Name {get;set;}

        [Display(Name ="Contrasena")]
        [Required(ErrorMessage ="El campo Contrasena es obligatorio")]
        [MaxLength(50,ErrorMessage = "El campo Contrasena no puede tener mas de 50 caracteres.")]
        public string Password {get;set;}
    }
}