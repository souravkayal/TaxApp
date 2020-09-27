using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxApp.Model;
using TaxApp.Repository;
using TaxApp.TaxRule;

namespace TaxApp.Service
{
    public class TaxService : ITaxService
    {
        readonly ITaxRepository _taxRepository;

        public TaxService(ITaxRepository taxRepository)
        {
            this._taxRepository = taxRepository;
        }

        public async Task<TaxResponse> GetTax(TaxRequest taxRequest)
        {
            var taxSetupResult = await _taxRepository.GetTax(taxRequest);
            var taxAmount = TaxRuleFactory.GetTaxRule(taxRequest.municipalityName)?.ApplyRule(taxSetupResult);

            return new TaxResponse
            {
                municipilityName = taxRequest?.municipalityName,  
                taxRate = taxAmount ,
                message = !taxSetupResult.Any() ? "No result found." : String.Empty
            };
        }

        public async Task<TaxResponse> AddTax(TaxEntity entity)
        {
            return new TaxResponse
            {
                message = await _taxRepository.AddTax(entity) + " Tax information added",
                taxRate = entity.taxAmount,
                municipilityName = entity.municipalityName,
            };
        }

    }
}
