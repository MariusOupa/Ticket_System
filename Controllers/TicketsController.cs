﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using TicketSystem.Interfaces;
//using TicketSystem.Models;

//namespace TicketSystem.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class TicketsController : ControllerBase
//    {
//        private readonly ITicketRepository _ticketRespository;

//        public TicketsController(ITicketRepository ticketRepository)
//        {
//            _ticketRespository = ticketRepository;
//        }

//        // GET: api/Tickets
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<Tickets>>> GetTickets()
//        {
//            return await _context.Tickets.ToListAsync();
//        }

//        // GET: api/Tickets/5
//        [HttpGet("{id}")]
//        public async Task<ActionResult<Tickets>> GetTickets(int id)
//        {
//            var tickets = await _context.Tickets.FindAsync(id);

//            if (tickets == null)
//            {
//                return NotFound();
//            }

//            return tickets;
//        }

//        // PUT: api/Tickets/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for
//        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
//        [HttpPut("{id}")]
//        public async Task<IActionResult> PutTickets(int id, Tickets tickets)
//        {
//            if (id != tickets.Id)
//            {
//                return BadRequest();
//            }

//            _context.Entry(tickets).State = EntityState.Modified;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!TicketsExists(id))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return NoContent();
//        }

//        // POST: api/Tickets
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for
//        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
//        [HttpPost]
//        public async Task<ActionResult<Tickets>> PostTickets(Tickets tickets)
//        {
//            _context.Tickets.Add(tickets);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction("GetTickets", new { id = tickets.Id }, tickets);
//        }

//        // DELETE: api/Tickets/5
//        [HttpDelete("{id}")]
//        public async Task<ActionResult<Tickets>> DeleteTickets(int id)
//        {
//            var tickets = await _context.Tickets.FindAsync(id);
//            if (tickets == null)
//            {
//                return NotFound();
//            }

//            _context.Tickets.Remove(tickets);
//            await _context.SaveChangesAsync();

//            return tickets;
//        }

//        private bool TicketsExists(int id)
//        {
//            return _context.Tickets.Any(e => e.Id == id);
//        }
//    }
//}
