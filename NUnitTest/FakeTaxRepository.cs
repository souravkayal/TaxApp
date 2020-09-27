using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaxApp.Model;
using TaxApp.Repository;

namespace NUnitTest
{
    public class FakeTaxRepository : ITaxRepository
    {
        public Task<int> AddTax(TaxEntity entity)
        {
            return Task.FromResult(1);
        }

        public Task<List<TaxEntity>> GetTax(TaxRequest taxRequest)
        {
            throw new NotImplementedException();
        }
    }
}
