using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Api.DTOs.Product.DTOs
{
    public class GetIdResultProductDTO
    {
        public int Id {get;set;}

        [Display(Name ="Nombre")]
        public string Name {get;set;}

        [Display(Name ="Cantidad")]
        public int Quantity {get;set;}

        [Display(Name ="Dimensiones.")]
        public string Dimensions {get;set;}

        [Display(Name ="Fecha de Adquisición")]
        public DateTime AcquisitionDate {get;set;}

        [Display(Name ="fecha de vencimiento")]
        public DateTime DueDate {get;set;}
    }
}