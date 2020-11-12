using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TicketSystem.Dto_s;
using TicketSystem.Interfaces;
using TicketSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TicketSystem.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly DBContext _context;
        public TicketRepository(DBContext context)
        {
            _context = context;
        }

        public Task<Tickets> AddTicket()
        {
            throw new NotImplementedException();
        }

        public async Task<Tickets> CreateTicket(TicketDto ticketDto)
        {
          
            var ticket = new Tickets
            {
                TicketType = ticketDto.TicketType,
                Description = ticketDto.Description,
                DateIssued = ticketDto.DateIssued,
                Status = ticketDto.Status
            };

            _context.Tickets.Add(ticket);
            await _context.SaveChangesAsync();
            return ticket;
            

        }

        

        //public async Task<ActionResult<UserDto>> AddTicket(TicketDto ticketdto)
        //{
        //    //var ticketType = ticketdto.TicketType;
        //    //var ticketDescript = ticketdto.Description;
        //    //if (await TicketExists(ticketType,ticketDescript)) return new BadRequestObjectResult("Ticket Already exists");

        //    //var ticket = new Tickets
        //    //{
        //    //    TicketType = ticketdto.TicketType,
        //    //    Description = ticketdto.Description,
        //    //    DateIssued = ticketdto.DateIssued,
        //    //    Status = ticketdto.Status
        //    //};
        //    //_context.Tickets.Add(ticket);


        //    //return 

        //}

        public async Task<IEnumerable<Tickets>> GetTicketsAsync()
        {
            return await _context.Tickets.ToListAsync();
        }

        public void UpdateTicket(Tickets ticket)
        {
            _context.Entry(ticket).State = EntityState.Modified;
        }

        private async Task<bool>TicketExists(string type, string description)
        {
            return await _context.Tickets.AnyAsync(x => x.TicketType == type && x.Description == description); 
        }


    }
}
