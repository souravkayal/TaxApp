using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxApp.Model;

namespace TaxApp.TaxRule
{

    //Factory class to return Rule Object
    public static class TaxRuleFactory
    {
        public static ITaxRule GetTaxRule(string name)
        {
            switch (name)
            {
                case "Copenhagen": return new CapenhagenTaxRule();
                default: return null;
            }
        }
    }
}
