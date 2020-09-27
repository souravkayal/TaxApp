using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaxApp.Model
{
    public class TaxRequest
    {
        [Required]
        public string municipalityName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime date { get; set; }
    }
}
