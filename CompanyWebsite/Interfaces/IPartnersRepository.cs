using CompanyWebsite.Entities;
using CompanyWebsite.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyWebsite.Interfaces
{
    public interface IPartnersRepository
    {
        Task<bool> SaveAllAsync();
        Task<IEnumerable<Partners>> GetPartnersAsync();
        Task<Partners> GetPartnersByIdAsync(int id);
        Task<Partners> GetPartnersByUserNameAsync(string userName);
        Task<bool> UserExistsAsync(string name);
        void AddPartnerToTheContext(Partners partner);
    }
}
