using Microsoft.Extensions.Primitives;
using Microsoft.VisualStudio.Web.CodeGeneration.Templating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.Dto_s;
using TicketSystem.Models;

namespace TicketSystem.Interfaces
{
    public interface ITicketRepository
    {
        void UpdateTicket(Tickets ticket);


        Task<Tickets> AddTicket();

       
    }
}
