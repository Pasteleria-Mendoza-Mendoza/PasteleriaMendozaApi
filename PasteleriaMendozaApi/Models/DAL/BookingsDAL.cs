using PasteleriaMendozaApi.Models.EN;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace PasteleriaMendozaApi.Models.DAL
{
    public class BookingsDAL
    {
        readonly ApiContext _context;

        public BookingsDAL(ApiContext apiContext)
        {
            _context = apiContext;
        }

        public async Task<int> Create(BookingsEN bookingsEN)
        {
            _context.Add(bookingsEN);
            return await _context.SaveChangesAsync();
        }

        public async Task<BookingsEN> GetById(int Id)
        {
            var bookings = await _context.Bookings.FirstOrDefaultAsync(s=>s.Id==Id);
            return bookings != null ? bookings : new BookingsEN();
        }

        public async Task<int> Edit(BookingsEN bookingsEN)
        {
            int result = 0;
            var bookingsUpdate = await GetById(bookingsEN.Id);
            if (bookingsUpdate.Id !=0)
            {
                bookingsUpdate.CustomerName = bookingsEN.CustomerName;
                bookingsUpdate.ContactNumber = bookingsEN.ContactNumber;
                bookingsUpdate.CakeQuantity = bookingsEN.CakeQuantity;
                bookingsUpdate.CakeDimensions = bookingsEN.CakeDimensions;
                bookingsUpdate.CakeDedication = bookingsEN.CakeDedication;
                bookingsUpdate.ReservationShipping = bookingsEN.ReservationShipping;
                bookingsUpdate.ReservationDate = bookingsEN.ReservationDate;
                bookingsUpdate.CakeCost = bookingsEN.CakeCost;
                result = await _context.SaveChangesAsync();
            }
            return result;
        }

        public async Task<int> Delete(int id)
        {
            int result = 0;
            var bookingsDelete = await GetById(id);
            if (bookingsDelete.Id > 0)
            {
                _context.Bookings.Remove(bookingsDelete);
                result = await _context.SaveChangesAsync();
            }
            return result;
        }
    }
}