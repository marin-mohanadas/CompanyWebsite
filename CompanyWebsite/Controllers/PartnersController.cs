using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CompanyWebsite.Entities;
using CompanyWebsite.Interfaces;
using CompanyWebsite.Model.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebsite.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartnersController : ControllerBase
    {
        private readonly IPartnersRepository _partnersRepository;

        public PartnersController(IPartnersRepository partnersRepository)
        {
            _partnersRepository = partnersRepository;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Partners>>> GetPartners()
        {
            return Ok(await _partnersRepository.GetPartnersAsync());
        }

        [HttpGet("{username}")]
        public async Task<ActionResult<Partners>> GetPartner(string username)
        {
            return await _partnersRepository.GetPartnersByUserNameAsync(username);
        }

        [HttpPost("register")]
        public async Task<ActionResult<Partners>> CreateUserNameHash(UserDTO userDto)
        {
            if (await _partnersRepository.UserExistsAsync(userDto.Name))
                return BadRequest("User Exists");

            var partner = new Partners
            {
                Name = userDto.Name,
                Biography = userDto.Biography,
                UserName = ConvertToHash(userDto.Name)
            };

            _partnersRepository.AddPartnerToTheContext(partner);
            await _partnersRepository.SaveAllAsync();
            return partner;
        }

        private string ConvertToHash(string name)
        {
            using var sha = new SHA256Managed();
            byte[] textData = Encoding.UTF8.GetBytes(name);
            byte[] hash = sha.ComputeHash(textData);
            return BitConverter.ToString(hash)
                .Replace("-", string.Empty)
                .ToLower();
        }


    }
}