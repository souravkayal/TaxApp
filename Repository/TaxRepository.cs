using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxApp.Db;
using TaxApp.Model;
using Microsoft.EntityFrameworkCore;

namespace TaxApp.Repository
{
    public class TaxRepository : ITaxRepository
    {
        private TaxDbContext _taxContext;
        public TaxRepository(TaxDbContext taxContext)
        {
            this._taxContext = taxContext;
        }

        public async Task<List<TaxEntity>> GetTax(TaxRequest taxRequest)
        {
            return await _taxContext.Tax.Where(f => f.municipalityName.ToUpper() == taxRequest.municipalityName.ToUpper()
                                              && taxRequest.date >= f.fromDate 
                                              && taxRequest.date <= f.toDate).ToListAsync();
        }


        public async Task<int> AddTax(TaxEntity entity)
        {
            await _taxContext.AddAsync(entity);
            return await _taxContext.SaveChangesAsync();
        }
    }
}
