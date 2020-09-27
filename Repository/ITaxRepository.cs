using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxApp.Model;

namespace TaxApp.Repository
{
    public interface ITaxRepository
    {
       Task<List<TaxEntity>> GetTax(TaxRequest taxRequest);
       Task<int> AddTax(TaxEntity entity);
    }
}
