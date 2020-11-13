﻿using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyWebsite.Entities
{
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }

        public Partners Partners { get; set; }
        public int PartnerId { get; set; }
    }
}