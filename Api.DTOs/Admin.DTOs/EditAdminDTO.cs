using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Reflection.Metadata.Ecma335;

namespace Api.DTOs.Admin.DTOs
{
    public class EditAdminDTO
    {
        public EditAdminDTO(GetidResultAdminDTO getidResultAdminDTO)
        {
            Id = getidResultAdminDTO.Id;
            Name = getidResultAdminDTO.Name;
            Password = getidResultAdminDTO.Password;
        }

        public EditAdminDTO()
        {
            Name = string.Empty;
            Password = string.Empty;
        }
        [Required(ErrorMessage ="El campo Id es obligatorio.")]
        public int Id {get;set;}

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