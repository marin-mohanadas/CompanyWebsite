using CompanyWebsite.Entities;
using CompanyWebsite.Interfaces;
using CompanyWebsite.Model.Data;
using CompanyWebsite.Model.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyWebsite.Model
{
    public class PartnersRepository : IPartnersRepository
    {
        private readonly PartnersDataContext _context;

        public PartnersRepository(PartnersDataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Partners>> GetPartnersAsync()
        {
            return await _context.Partners
                .Include(p => p.Photos)
                .ToListAsync();
        }

        public async Task<Partners> GetPartnersByIdAsync(int id)
        {
            return await _context.Partners.FindAsync(id);
        }

        public async Task<Partners> GetPartnersByUserNameAsync(string userName)
        {
            return await _context.Partners
                .Include(p => p.Photos)
                .SingleOrDefaultAsync(x => x.UserName == userName);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;

        }

        public async Task<bool> UserExistsAsync(string name)
        {
            return await _context.Partners.AnyAsync(x => x.Name.ToLower() == name.ToLower());
        }

        public void AddPartnerToTheContext(Partners partner)
        {
            _context.Partners.Add(partner);
        }
    }
}
