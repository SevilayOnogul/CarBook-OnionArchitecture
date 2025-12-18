using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Commands.CarCommands
{
    public class RemoveCarComand
    {
        public RemoveCarComand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
