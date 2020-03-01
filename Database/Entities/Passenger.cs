using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Entities
{
    public class Passenger
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Lastname { get; set; }
        public string USN { get; set; }
        public string PhoneNumber { get; set; }
        public string Nationality { get; set; }
        public string TicketType { get; set; }
        public int ReservationId { get; set; }

    }
}
