using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.Interfaces;
using TicketSystem.Models;

namespace TicketSystem.Repositories
{
    public class UserRepository : IUserRepository

    {
        private readonly DBContext _context;
    

        public UserRepository(DBContext context)
        {
            _context = context;
        }
        public async Task<User> GetUserbyId(int id)
        {
            return await _context.User.FindAsync(id);
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _context.User
                .Include(t => t.Ticket)
                .ToListAsync();
        }
    }
}
