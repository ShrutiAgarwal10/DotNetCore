using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Practice_Project.Models
{
    [Table("MembersTable")]
    public partial class MembersTable
    {
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Company { get; set; }
        [StringLength(50)]
        public string JobTitle { get; set; }
        [StringLength(50)]
        public string MemberType { get; set; }
        [Key]
        [Column("AMS_ID")]
        public int AmsId { get; set; }
        public bool? IsAttendee { get; set; }
    }
}
