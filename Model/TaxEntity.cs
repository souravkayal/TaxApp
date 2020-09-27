using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TaxApp.Enum;

namespace TaxApp.Model
{
    public class TaxEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }

        [Required]
        public string municipalityName { get; set; }

        [Required]
        public DateTime fromDate { get; set; }

        [Required]
        public DateTime toDate { get; set; }

        [Required]
        public TaxType taxType { get; set; }

        [Required]
        public double taxAmount { get; set; }
    }
}
