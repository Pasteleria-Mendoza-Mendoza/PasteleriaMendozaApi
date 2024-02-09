namespace PasteleriaMendozaApi.Models.EN
{
    public class BookingsEN
    {
        public int Id {get;set;}
        public string CustomerName {get;set;}
        public int ContactNumber {get;set;}
        public  int CakeQuantity {get;set;}
        public string CakeDimensions {get;set;}
        public string CakeDedication {get;set;}
        public DateTime ReservationShipping {get;set;}
        public DateTime ReservationDate {get;set;}
        public int CakeCost {get;set;}
    }
}