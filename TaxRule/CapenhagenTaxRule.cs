using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxApp.Model;

namespace TaxApp.TaxRule
{
    //Rule implementation for Capenhagen 
    public class CapenhagenTaxRule : ITaxRule
    {
        public double ApplyRule(List<TaxEntity> taxs)
        {
           var result = taxs.OrderBy(f => (int)f.taxType);
           return result.First().taxAmount;
        }
    }
}
