using System.ComponentModel.DataAnnotations;

namespace Api.DTOs.Product.DTOs
{
    public class CreateProductDTO
    {
        [Display(Name ="Nombre")]
        [Required(ErrorMessage ="El campo nombre es obligatorio.")]
        [MaxLength(50, ErrorMessage ="El campo Nombre no puede tener mas de 50 caracteres.")]
        public string Name {get;set;}

        [Display(Name ="Cantidad")]
        [Required(ErrorMessage ="El campo Cantidad es obligatorio.")]
        public int Quantity {get;set;}

        [Display(Name ="Dimensiones")]
        [Required(ErrorMessage ="El campo Dimensiones es obligatorio.")]
        [MaxLength(100, ErrorMessage ="El campo Dimensiones solo puede tener 100 caracteres.")]
        public string Dimensions {get;set;}

        [Display(Name ="Fecha de Adquisición.")]
        [Required(ErrorMessage ="El campo Fecha de Adquisición es obligatorio.")]
        public DateTime AcquisitionDate {get;set;}

        [Display(Name ="fecha de vencimiento")]
        [Required(ErrorMessage ="El campo fecha de vencimiento es obligarorio.")]
        public DateTime DueDate {get;set;}
    }
}