using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.Models;

namespace TicketSystem.Interfaces
{
    public interface ITicketRepository
    {
        void UpdateTicket(Tickets ticket);

        Task<IEnumerable<Tickets>> GetTicketsAsync();

        Task<Tickets> AddTicket();

    }
}
