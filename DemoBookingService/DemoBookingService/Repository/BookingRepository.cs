using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoBookingService.Models;

namespace DemoBookingService.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private List<Booking> _bookings;
        public BookingRepository()
        {
            _bookings = new List<Booking>{
                new Booking {Booking_Id = 1, Ticket_Cost = 100},
                new Booking {Booking_Id = 2, Ticket_Cost = 150},
                new Booking {Booking_Id = 3, Ticket_Cost = 200},

            };
        }

        public Booking Add(Booking item)
        {
            _bookings.Add(item);
            return item;
        }

        public Booking Book(Booking entity)
        {
            throw new NotImplementedException();
        }

        public List<Booking> GetAll()
        {
            return _bookings;
        }

        public int Remove(int id)
        {
            for (var index = _bookings.Count - 1; index >= 0; index--)
            {
                if (_bookings[index].Booking_Id == id)
                {
                    _bookings.RemoveAt(index);
                }
            }

            return id;
        }

        public int Update(int id, int cost)
        {
            for (var index = _bookings.Count - 1; index >= 0; index--)
            {
                if (_bookings[index].Booking_Id == id)
                {
                    _bookings[id].Ticket_Cost = cost;
                }
            }
            return cost;
        }
    }
}