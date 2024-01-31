using System.ComponentModel.DataAnnotations;

namespace Api.DTOs.Admin.DTOs
{
    public class SearchQueryAdminDTO
    {
        [Display(Name ="Nombre")]
        public String? Name_Like {get;set;}

        [Display(Name ="Pagina")]
        public int Skip {get;set;}

        [Display(Name ="CantRed X Pagina")]
        public int Take {get;set;}

        public byte SeandRowCout {get;set;}
    }
}