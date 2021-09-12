using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetOnlineBooking.Models;

namespace NetOnlineBooking.Data
{
    public class NetOnlineBookingContext : DbContext
    {
        public NetOnlineBookingContext (DbContextOptions<NetOnlineBookingContext> options)
            : base(options)
        {
        }

        public DbSet<NetOnlineBooking.Models.Booking> Booking { get; set; }
    }
}
