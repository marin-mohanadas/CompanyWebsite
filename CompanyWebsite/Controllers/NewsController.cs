using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyWebsite.Entities;
using CompanyWebsite.Model.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CompanyWebsite.Controllers
{
    public class NewsController : BaseController
    {
        private readonly PartnersDataContext _context;
        public NewsController(PartnersDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<News>>> GetAllNews()
        {
            return await _context.News.ToListAsync();
        }

        [HttpGet("{newsId}")]
        public async Task<ActionResult<News>> GetNewsId(int? newsId)
        {
            return await _context.News.FindAsync(newsId);
        }

    }
}