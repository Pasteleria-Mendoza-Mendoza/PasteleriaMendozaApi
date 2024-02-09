using System;
using System.ComponentModel.DataAnnotations;

namespace PasteleriaMendozaWeb.Models
{
    public class Booking
    {
         public int Id { get; set; }

    [Required(ErrorMessage = "El nombre del cliente es obligatorio.")]
    [StringLength(100, ErrorMessage = "El nombre del cliente debe tener como máximo {1} caracteres.")]
    public string CustomerName { get; set; }

    [Required(ErrorMessage = "El número de contacto es obligatorio.")]
    public int ContactNumber { get; set; }

    [Required(ErrorMessage = "La cantidad de pasteles es obligatoria.")]
    public int CakeQuantity { get; set; }

    [Required(ErrorMessage = "Las dimensiones del pastel son obligatorias.")]
    [StringLength(100, ErrorMessage = "Las dimensiones del pastel deben tener como máximo {1} caracteres.")]
    public string CakeDimensions { get; set; }

    [Required(ErrorMessage = "La dedicatoria del pastel es obligatoria.")]
    [StringLength(100, ErrorMessage = "La dedicatoria del pastel debe tener como máximo {1} caracteres.")]
    public string CakeDedication { get; set; }

    [Required(ErrorMessage = "La fecha de reserva es obligatoria.")]
    [DataType(DataType.DateTime, ErrorMessage = "El formato de fecha y hora no es válido.")]
    public DateTime ReservationDate { get; set; }

    [DataType(DataType.DateTime, ErrorMessage = "El formato de fecha y hora no es válido.")]
    public DateTime? ReservationShipping { get; set; }

    [Required(ErrorMessage = "El costo del pastel es obligatorio.")]
    public int CakeCost { get; set; }
    }
}