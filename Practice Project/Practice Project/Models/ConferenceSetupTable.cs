using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Practice_Project.Models
{
    
    [Table("ConferenceSetupTable")]
    public partial class ConferenceSetupTable
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string ConferenceName { get; set; }
        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }
        [StringLength(50)]
        public string Location { get; set; }
        [Column("QRCodeFormat")]
        [StringLength(50)]
        public string QrcodeFormat { get; set; }
        [StringLength(50)]
        public string BadgeTemplate { get; set; }
    }
}
