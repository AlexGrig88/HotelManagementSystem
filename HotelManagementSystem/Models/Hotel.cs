using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;
        public string Name { get; set; }

        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }

        public IEnumerable<Reservation> GetAllResevations() => _reservationBook.GetAllResevations();

        public IEnumerable<Reservation> GetReservationByUsername(string username) => _reservationBook.GetReservationByUsername(username);

        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }
    }
}
