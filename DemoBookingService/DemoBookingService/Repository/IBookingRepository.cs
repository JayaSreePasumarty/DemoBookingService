using DemoBookingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBookingService
{
    public interface IBookingRepository
    {
        //IEnumerable<Booking> GetAll();
        List<Booking> GetAll();
        Booking Book(Booking entity);
    }
}