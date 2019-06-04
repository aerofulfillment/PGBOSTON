using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PGBOSTON.Models
{
    public class EnrollmentData
    {
        public int Id { get; set; }
        public string Employee { get; set; }

        [DataType(DataType.Date)]
        public DateTime RequestEventDate { get; set; }
        public string HomeAddress { get; set; }
        public int RequestMoreTickets { get; set; }
        public int MaxTicketCount { get; }
        public Boolean RequireTransportation { get; set; }
        public Boolean Retiree { get; set; }

    }
}