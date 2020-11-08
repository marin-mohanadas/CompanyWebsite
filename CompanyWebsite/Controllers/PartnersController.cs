using System.Collections.Generic;
using System.Threading.Tasks;
using CompanyWebsite.Entities;
using CompanyWebsite.Model.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CompanyWebsite.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartnersController : ControllerBase
    {
        private readonly PartnersDataContext _context;

        public PartnersController(PartnersDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Partners>>> GetPartners()
        {
            return await _context.Partners.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Partners>> GetPartner(int id)
        {
            return await _context.Partners.FindAsync(id);
        }


    }
}