using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NetOnlineBooking.Data;
using NetOnlineBooking.Models;

namespace NetOnlineBooking.Pages.Booking
{
    public class IndexModel : PageModel
    {
        private readonly NetOnlineBooking.Data.NetOnlineBookingContext _context;

        public IndexModel(NetOnlineBooking.Data.NetOnlineBookingContext context)
        {
            _context = context;
        }

        public IList<Models.Booking> Booking { get;set; }

        public async Task OnGetAsync()
        {
            Booking = await _context.Booking.ToListAsync();
        }
    }
}
