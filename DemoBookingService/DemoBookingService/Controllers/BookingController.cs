using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using DemoBookingService.Models;
using DemoBookingService.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoBookingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingRepository _bookingRepository;
        //static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(BookingController));
        public BookingController(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        [HttpGet]
        public ActionResult<List<Booking>> Get()
        {
            /*_log4net.Info("API initiated");
            _log4net.Info(" Http GET is accesed");*/
            return _bookingRepository.GetAll();
        }
        [HttpPost]
        public IActionResult Post(Booking booking)
        {
            try
            {
             //   _log4net.Info("Book Details Getting Added");
                if (ModelState.IsValid)
                {
                    _bookingRepository.Book(booking);
                    return CreatedAtAction(nameof(Post), new { id = booking.Booking_Id }, booking);

                }
                return BadRequest();


            }
            catch
            {
                //_log4net.Error("Error in Adding Booking Details");
                return new NoContentResult();
            }

        }
    }
}
