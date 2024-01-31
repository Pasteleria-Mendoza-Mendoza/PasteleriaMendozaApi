using System.ComponentModel.DataAnnotations;

namespace Api.DTOs.Admin.DTOs
{
    public class GetidResultAdminDTO
    {
        public int Id {get;set;}

        [Display(Name ="Nombre")]
        public string Name {get;set;}

        [Display(Name ="Contrasena")]
        public string Password {get;set;}
    }
}