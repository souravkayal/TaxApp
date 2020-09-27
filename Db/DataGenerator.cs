using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxApp.Model;

namespace TaxApp.Db
{
    //Data setup
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context = new TaxDbContext(serviceProvider.GetRequiredService<DbContextOptions<TaxDbContext>>()))
            {

                if (context.Tax.Any())
                {
                    return;   // Data was already seeded
                }

                context.AddRange(
                    new TaxEntity
                    {
                        id = 1,
                        municipalityName = "Copenhagen",
                        taxType = Enum.TaxType.YEARLY,
                        fromDate = new DateTime(2016, 01, 01),
                        toDate = new DateTime(2016, 12, 31),
                        taxAmount = 0.2
                    },
                    new TaxEntity
                    {
                        id = 2,
                        municipalityName = "Copenhagen",
                        taxType = Enum.TaxType.MONTHLY,
                        fromDate = new DateTime(2016, 05, 01),
                        toDate = new DateTime(2016, 05, 31),
                        taxAmount = 0.4
                    },
                    new TaxEntity
                    {
                        id = 3,
                        municipalityName = "Copenhagen",
                        taxType = Enum.TaxType.DAILY,
                        fromDate = new DateTime(2016, 01, 01),
                        toDate = new DateTime(2016, 01, 01) ,
                        taxAmount = 0.1
                    },
                    new TaxEntity
                    {
                        id = 4,
                        municipalityName = "Copenhagen",
                        taxType = Enum.TaxType.YEARLY,
                        fromDate = new DateTime(2016, 12, 25),
                        toDate = new DateTime(2016, 12, 25),
                        taxAmount = 0.1
                    });

                context.SaveChanges();

            }
        }
        
    }
}
