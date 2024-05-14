using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.Exceptions;

namespace HotelManagementSystem.Models
{
    internal class ReservationBook
    {
        private readonly List<Reservation> _reservationList;

        public ReservationBook()
        {
            _reservationList = new List<Reservation>();
        }

        public IEnumerable<Reservation> GetReservationByUsername(string username) => _reservationList.Where(r => r.UserName == username);

        public void AddReservation(Reservation reservation)
        {
            foreach (var existingReserv in _reservationList) {
                if (existingReserv.Conflicts(reservation)) {
                    throw new ReservationConflictException(existingReserv, reservation);
                }
            }
            _reservationList.Add(reservation);
        }
    }
}
