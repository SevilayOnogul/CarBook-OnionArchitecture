using CarBook.Application.Features.Mediator.Results.BrandResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.BrandInterfaces
{
    namespace CarBook.Application.Interfaces.BrandInterfaces
    {
        public interface IBrandRepository 
        {
            Task<List<GetCarCountByBrandQueryResult>> GetCarCountByBrand();
        }
    }
}
