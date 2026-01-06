using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.LocationInterfaces
{
    public interface ILocationRepository
    {
        Task<List<GetCarCountByLocationQueryResult>> GetCarCountByLocation();
    }
}
