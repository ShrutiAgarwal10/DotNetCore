using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Practice_Project.Models
{
    [Table("SessionsTable")]
    public partial class SessionsTable
    {
        [Required]
        [StringLength(50)]
        public string SessionName { get; set; }
        [Key]
        [Column("AMS_ID")]
        [StringLength(50)]
        public string AmsId { get; set; }
        [Column("MobileID")]
        [StringLength(50)]
        public string MobileId { get; set; }
        [StringLength(50)]
        public string SpeakerName { get; set; }
    }
}
