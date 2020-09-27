using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaxApp.Model;
using TaxApp.Service;

namespace NUnitTest
{
    public class FakeTaxService : ITaxService
    {
        public FakeTaxService()
        {

        }

        public Task<TaxResponse> GetTax(TaxRequest taxRequest)
        {
            return Task.FromResult(new TaxResponse { message = "fake message ", taxRate = 1.1, municipilityName = "some name" });
        }

        public Task<TaxResponse> AddTax(TaxEntity tax)
        {
            return Task.FromResult(new TaxResponse { message = "fake message ", taxRate = 1.1, municipilityName = "some name" });
        }

        
    }
}
