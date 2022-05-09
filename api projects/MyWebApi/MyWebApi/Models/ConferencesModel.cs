using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApi.Models
{
    public class ConferencesModel
    {
        public int ConferenceId { get; set; }

        [Required]
        public string Name { get; set; }

        
        public DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }

        public string Location { get; set; }
    }
}
