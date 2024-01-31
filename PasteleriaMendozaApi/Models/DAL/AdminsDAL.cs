using PasteleriaMendozaApi.Models.EN;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;
using Microsoft.AspNetCore.Mvc;

namespace PasteleriaMendozaApi.Models.DAL
{
    public class AdminsDAL
    {
        readonly ApiContext _context;

        public AdminsDAL(ApiContext pasteleriaMendozaApiContext)
        {
            _context = pasteleriaMendozaApiContext;
        }

        public async Task<int> Create(AdminEn adminEn)
        {
            _context.Add(adminEn);
            return await _context.SaveChangesAsync();
        }

        public async Task<AdminEn> GetById(int id)
        {
            var adminen = await _context.admins.FirstOrDefaultAsync(s=>s.Id==id);
            return adminen != null ? adminen : new AdminEn();
        }

        public async Task<int> Edit(AdminEn adminEn)
        {
            int result = 0;
            var adminEnUpdate = await GetById(adminEn.Id);
            if (adminEnUpdate.Id != 0)
            {
                adminEnUpdate.Name = adminEn.Name;
                adminEnUpdate.Password = adminEn.Password;
                result = await _context.SaveChangesAsync();
            }
            return result;
        }

        public async Task<int> Delete(int id)
        {
            int result = 0;
            var adminEnDelete = await GetById(id);
            if (adminEnDelete.Id > 0)
            {
                _context.admins.Remove(adminEnDelete);
                result = await _context .SaveChangesAsync();
            }
            return result;
        }

        private IQueryable<AdminEn> Query(AdminEn adminEn)
        {
            var query = _context.admins.AsQueryable();
            if (!string.IsNullOrWhiteSpace(adminEn.Name))
                query = query.Where(s=>s.Name.Contains(adminEn.Name));
            if (!string.IsNullOrWhiteSpace(adminEn.Password))
                query = query.Where(s=>s.Password.Contains(adminEn.Password));
            return query;
        }

        public async Task<int> CountSearch(AdminEn adminEn)
        {
            return await Query(adminEn).CountAsync();
        }

        public async Task<List<AdminEn>> Search(AdminEn adminEn, int take = 10, int skip = 0)
        {
            take = take == 0 ? 10 :take;
            var query = Query(adminEn);
            query = query.OrderByDescending(s =>s.Id).Skip(skip).Take(take);
            return await query.ToListAsync();
        }
    }
}