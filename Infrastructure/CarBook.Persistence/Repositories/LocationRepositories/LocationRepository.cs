using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.LocationInterfaces;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repositories.LocationRepositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly CarBookContext _context;

        public LocationRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<List<GetCarCountByLocationQueryResult>> GetCarCountByLocation()
        {
            var values = await _context.RentACars
                .Include(x => x.Location) // Lokasyon ismine ulaşmak için
                .Where(x => x.Available == true) // İstersen sadece müsait olanları filtreleyebilirsin
                .GroupBy(x => x.Location.Name)
                .Select(y => new GetCarCountByLocationQueryResult
                {
                    LocationName = y.Key,
                    CarCount = y.Count()
                }).ToListAsync();

            return values;
        }
    }
}
