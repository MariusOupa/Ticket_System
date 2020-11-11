using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.Interfaces;
using TicketSystem.Models;

namespace TicketSystem.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly DBContext _context;
        public TicketRepository(DBContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Tickets>> GetTicketsAsync()
        {
            return await _context.Tickets.ToListAsync();
        }

        public void UpdateTicket(Tickets ticket)
        {
            _context.Entry(ticket).State = EntityState.Modified;
        }
    }
}
