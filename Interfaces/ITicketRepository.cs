using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.Models;

namespace TicketSystem.Interfaces
{
    interface ITicketRepository
    {
        void UpdateTicket(Tickets ticket);

        Task<IEnumerable<Tickets>> GetTicketsAsync();

        

    }
}
