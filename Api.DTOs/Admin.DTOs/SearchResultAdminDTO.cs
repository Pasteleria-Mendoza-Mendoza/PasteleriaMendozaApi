using System.ComponentModel.DataAnnotations;

namespace Api.DTOs.Admin.DTOs
{
    public class SearchResultAdminDTO
    {
        public int CountRow {get;set;}
        public List<AdminDTO> Data {get;set;}
        public class AdminDTO
        {
            public int Id {get;set;}

            [Display(Name ="Nombre")]
            public string Name {get;set;}

            [Display(Name ="Contrasena")]
            public string Password {get;set;}
        }
    }
}