using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxApp.Model;

namespace TaxApp.TaxRule
{
    public interface ITaxRule
    {
        double ApplyRule(List<TaxEntity> taxs);
    }
}
