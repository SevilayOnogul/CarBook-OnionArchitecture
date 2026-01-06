using CarBook.Application.Features.Mediator.Results.BrandResults;
using CarBook.Application.Interfaces.BrandInterfaces.CarBook.Application.Interfaces.BrandInterfaces;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repositories.BrandRepositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly CarBookContext _context;
        public BrandRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<List<GetCarCountByBrandQueryResult>> GetCarCountByBrand()
        {
            var values = await _context.Cars
                .Include(x => x.Brand)
                .GroupBy(x => x.Brand.Name)
                .Select(y => new GetCarCountByBrandQueryResult
                {
                    BrandName = y.Key,
                    CarCount = y.Count()
                }).ToListAsync();
            return values;
        }
    }
}
