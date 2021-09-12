using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetOnlineBooking.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime AppointmentData { get; set; }

    }
}
