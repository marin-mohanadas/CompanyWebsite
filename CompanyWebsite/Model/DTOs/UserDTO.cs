using CompanyWebsite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyWebsite.Model.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public string UserName { get; set; }
        public string PhotoUrl { get; set; }

        public ICollection<PhotoDto> Photos { get; set; }
    }
}
