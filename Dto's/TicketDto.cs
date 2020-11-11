using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Dto_s
{
    public class TicketDto
    {
        public string TicketType { get; set; }
        public string Description { get; set; }
        public DateTime DateIssued { get; set; }
        public string Status { get; set; }
    }
}
