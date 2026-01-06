using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.StatisticsDtos
{
    public class ResultReservationCountByLocationDto
    {
        public string LocationName { get; set; }
        public int ReservationCount { get; set; }
    }
}
