﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketSystem.Dto_s;
using TicketSystem.Interfaces;
using TicketSystem.Models;

namespace TicketSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ITicketRepository _ticketRepository;
        public UsersController(IUserRepository userRepository,ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
            _userRepository = userRepository;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUser()
        {
            var users = await _userRepository.GetUsersAsync();
            return Ok(users);

        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            return await _userRepository.GetUserbyId(id);
        }

        [HttpPost ("add-ticket")]

        public async Task<ActionResult<TicketDto>> AddTicket(TicketDto ticketDto)
        {
            if()
        }

        private async Task<bool>TicketExists(string type, string description, DateTime issued)
        {
            return await 
        }
    }
}
