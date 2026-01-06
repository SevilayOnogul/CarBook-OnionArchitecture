using CarBook.Application.Features.Mediator.Queries.BrandQueries;
using CarBook.Application.Features.Mediator.Results.BrandResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.BrandInterfaces.CarBook.Application.Interfaces.BrandInterfaces;
using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BrandHandlers
{
    public class GetCarCountByBrandQueryHandler : IRequestHandler<GetCarCountByBrandQuery, List<GetCarCountByBrandQueryResult>>
    {
        private readonly IBrandRepository _repository; // Veya Context kullanıyorsan direkt Context

        public GetCarCountByBrandQueryHandler(IBrandRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarCountByBrandQueryResult>> Handle(GetCarCountByBrandQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetCarCountByBrand();
            return values;
        }
    }
}
