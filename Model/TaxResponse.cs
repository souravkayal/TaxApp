using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxApp.Model
{
    public class TaxResponse
    {
        public string municipilityName { get; set; }
        public double? taxRate { get; set; }
        public string message { get; set; }
    }
}
