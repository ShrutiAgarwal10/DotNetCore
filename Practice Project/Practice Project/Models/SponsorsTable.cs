using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Practice_Project.Models
{
    
    [Table("SponsorsTable")]
    public partial class SponsorsTable
    {
        [Key]
        [Required]
        public int SponsorId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Company { get; set; }
        [Column("Sponsor_Level")]
        public int? SponsorLevel { get; set; }
    }
}
