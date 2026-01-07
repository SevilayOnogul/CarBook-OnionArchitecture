using CarBook.Application.Features.CQRS.Queries.CarQueries;
using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {

        private readonly ICarRepository _repository;

        public GetCarByIdQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarByIdQueryResult>Handle(GetCarByIdQuery query)
        {
            var values=await _repository.GetCarByIdWithBrand(query.Id);
            return new GetCarByIdQueryResult
            {
                BrandID = values.BrandID,
                BrandName = values.Brand.Name,
                BigImageUrl = values.BigImageUrl,
                CarID = values.CarID,
                CoverImageUrl = values.CoverImageUrl,
                Fuel = values.Fuel,
                Km = values.Km,
                Luggage = values.Luggage,
                Model = values.Model,
                Seat = values.Seat,
                Transmission = values.Transmission,
                
            };
        }
    }
}
