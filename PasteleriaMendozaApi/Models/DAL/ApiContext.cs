using Microsoft.EntityFrameworkCore;
using PasteleriaMendozaApi.Models.EN;

namespace PasteleriaMendozaApi.Models.DAL
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }
        public DbSet<AdminEn> admins {get;set;}

        public DbSet<ProductsEN> Products {get;set;}

        public DbSet<BookingsEN> Bookings {get;set;}
    }
}