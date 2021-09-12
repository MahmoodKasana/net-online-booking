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
    public class DetailsModel : PageModel
    {
        private readonly NetOnlineBooking.Data.NetOnlineBookingContext _context;

        public DetailsModel(NetOnlineBooking.Data.NetOnlineBookingContext context)
        {
            _context = context;
        }

        public Models.Booking Booking { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Booking = await _context.Booking.FirstOrDefaultAsync(m => m.Id == id);

            if (Booking == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
