using PasteleriaMendozaApi.Models.EN;
using Microsoft.EntityFrameworkCore;

namespace PasteleriaMendozaApi.Models.DAL
{
    public class ProductsDAL
    {
        readonly ApiContext _context;

        public ProductsDAL(ApiContext apiContext)
        {
            _context = apiContext;
        }

        public async Task<int> Create(ProductsEN productsEN)
        {
            _context.Add(productsEN);
            return await _context.SaveChangesAsync();
        }

        public async Task<ProductsEN> GetById(int id)
        {
            var products = await _context.Products.FirstOrDefaultAsync(s=>s.Id==id);
            return products != null ? products : new ProductsEN();
        }

        public async Task<int> Edit(ProductsEN productsEN)
        {
            int result = 0;
            var productsENUpdate = await GetById(productsEN.Id);
            if (productsENUpdate.Id != 0)
            {
                productsENUpdate.Name = productsEN.Name;
                productsENUpdate.Quiantity = productsEN.Quiantity;
                productsENUpdate.Dimensions = productsEN.Dimensions;
                productsENUpdate.AcquisitionDate = productsEN.AcquisitionDate;
                productsENUpdate.DueDate = productsEN.DueDate;
                result = await _context.SaveChangesAsync();
            }
            return result;
        }

        public async Task<int> Delete(int id)
        {
            int result = 0;
            var productsENDelete = await GetById(id);
            if (productsENDelete.Id > 0)
            {
                _context.Products.Remove(productsENDelete);
                result = await _context.SaveChangesAsync();
            }
            return result;
        }
    }
}