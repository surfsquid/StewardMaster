using System;
using System.ComponentModel;

namespace StewardMaster.Models
{
    public class LogEntryModel
    {
        public int Id { get; set; }

        [DisplayName("Number of Tickets")]
        public int NumberOfTickets { get; set; }

        public string Username { get; set; }

        [DisplayName("Requested")]
        public DateTime RequestDateTime { get; set; }
    }
}