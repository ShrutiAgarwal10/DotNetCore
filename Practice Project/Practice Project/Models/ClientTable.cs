using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Practice_Project.Models
{
    
    [Table("ClientTable")]
    public partial class ClientTable
    {
        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }

        [Key]
        public int ClientNumber { get; set; }
    }
}
