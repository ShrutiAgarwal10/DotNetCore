using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Practice_Project.Models
{
    
    [Table("UsersTable")]
    public partial class UsersTable
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Company { get; set; }
        [Column("Office_Phone_Number", TypeName = "numeric(18, 0)")]
        public decimal? OfficePhoneNumber { get; set; }
        [Column("Mobile_Phone_Number", TypeName = "numeric(18, 0)")]
        public decimal? MobilePhoneNumber { get; set; }
        [StringLength(50)]
        public string Website { get; set; }
    }
}
