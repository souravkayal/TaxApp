using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxApp.Model;

namespace TaxApp.Service
{
    public interface ITaxService
    {
        Task<TaxResponse> GetTax(TaxRequest taxRequest);
        Task<TaxResponse> AddTax(TaxEntity entity);
    }
}
