using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CompanyWebsite.Entities;
using CompanyWebsite.Interfaces;
using CompanyWebsite.Model.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebsite.Controllers
{
    public class PartnersController : BaseController
    {
        private readonly IPartnersRepository _partnersRepository;
        private readonly IMapper _mapper;

        public PartnersController(IPartnersRepository partnersRepository, IMapper mapper)
        {
            _partnersRepository = partnersRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetPartners()
        {
            var partners = await _partnersRepository.GetPartnersAsync();
            var partnersToReturn = _mapper.Map<IEnumerable<UserDTO>>(partners);
            return Ok(partnersToReturn);
        }

        [HttpGet("{username}")]
        public async Task<ActionResult<UserDTO>> GetPartner(string username)
        {
            var partner = await _partnersRepository.GetPartnersByUserNameAsync(username);
            return _mapper.Map<UserDTO>(partner);
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