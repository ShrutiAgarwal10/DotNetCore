using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Practice_Project.Models
{
    [Table("AttendeesTable")]
    public partial class AttendeesTable
    {
        [Key]
        [Column("AMS_ID")]
        public int AmsId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Company { get; set; }
        [StringLength(50)]
        public string RegistrationType { get; set; }
        [Column(TypeName = "date")]
        public DateTime? RegistrationDate { get; set; }
        public bool Confirmed { get; set; }
    }
}
