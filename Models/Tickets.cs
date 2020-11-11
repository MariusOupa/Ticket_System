using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Models
{
    public class Tickets
    {
        public int Id { get; set; }
        public string TicketType { get; set; }
        public string Description { get; set; }
        public DateTime DateIssued { get; set; } = DateTime.Now;
        public string Status { get; set; }
        public User user { get; set; }
    }
}
