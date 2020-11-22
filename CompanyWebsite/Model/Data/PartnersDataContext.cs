using CompanyWebsite.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyWebsite.Model.Data
{
    public class PartnersDataContext : DbContext
    {
        public PartnersDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Partners> Partners { get; set; }
        public DbSet<News> News { get; set; }
    }
}
