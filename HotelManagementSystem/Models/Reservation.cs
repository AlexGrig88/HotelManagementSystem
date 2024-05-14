using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    public class Reservation
    {
        public RoomId TheRoomId { get; }
        public string UserName { get; set; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }

        public TimeSpan Length => EndTime.Subtract(StartTime); 

        public Reservation(RoomId theRoomId, string username, DateTime startTime, DateTime endTime)
        {
            TheRoomId = theRoomId;
            UserName = username;
            StartTime = startTime;
            EndTime = endTime;
        }

        internal bool Conflicts(Reservation reservation)
        {
            if (reservation.TheRoomId == TheRoomId) {
                return true;
            }
            return reservation.StartTime < EndTime && reservation.EndTime > StartTime;
        }
    }
}
