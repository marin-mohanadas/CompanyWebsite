using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyWebsite.Entities
{
    public class Partners
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public string UserName { get; internal set; }

        public ICollection<Photo> Photos { get; set; }
    }
}
