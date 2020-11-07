﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CompanyWebsite.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartnersController : ControllerBase
    {
        [HttpGet]
        [AllowAnonymous]
        public ActionResult<IEnumerable<Partners>> GetPartners()
        {
            var partners = new Partners();
            return partners.PartnersLists();
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Partners>> GetPartner(int id)
        {
            var partners = new Partners();
            return partners.FindPartners(id);

        }


    }
}

public class Partners
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Biography { get; set; }



    public List<Partners> PartnersLists()
    {
        return new List<Partners>
            {
                new Partners
                {
                    Id = 1,
                    Name = "Jane Doe",
                    Biography = "This is a test Biography about Ms.Doe"
                },
                new Partners
                {
                     Id = 2,
                    Name = "John Smith",
                    Biography = "This is a test Biography about Mr.Smith"
                },
                new Partners
                {
                    Id = 3,
                    Name = "Mike Scott",
                    Biography = "This is a test Biography about Mr.Scott"
                },
                new Partners
                {
                    Id = 4,
                    Name = "Mary Kaitch",
                    Biography = "This is a test Biography about Ms.Kaitch"
                },
                new Partners
                {
                    Id = 5,
                    Name = "Joe Stanley",
                    Biography = "This is a test Biography about Mr.Stanley"
                },
                new Partners
                {
                    Id = 6,
                    Name = "Steve Robert",
                    Biography = "This is a test Biography about Mr.Robert"
                }

            };
    }


    public List<Partners> FindPartners(int id)
    {
        return PartnersLists().Where(x => x.Id == id).ToList(); ;
    }



}