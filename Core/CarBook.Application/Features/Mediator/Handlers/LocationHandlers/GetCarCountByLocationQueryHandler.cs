using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.LocationInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class GetCarCountByLocationQueryHandler : IRequestHandler<GetCarCountByLocationQuery, List<GetCarCountByLocationQueryResult>>
    {
        private readonly ILocationRepository _repository;

        public GetCarCountByLocationQueryHandler(ILocationRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarCountByLocationQueryResult>> Handle(GetCarCountByLocationQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetCarCountByLocation();
        }
    }
}
