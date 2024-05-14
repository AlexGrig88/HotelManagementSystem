using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    public class RoomId
    {
        public int FloorNumber { get; }
        public int RoomNumber { get; }

        public RoomId(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }

        public override bool Equals(object? obj)
        {
            return obj is RoomId other && FloorNumber == other.FloorNumber && RoomNumber == other.RoomNumber;
        }

        public static bool operator ==(RoomId room1, RoomId room2)
        {
            if (ReferenceEquals(room1, null) && ReferenceEquals(room2, null) || ReferenceEquals(room1, room2)) { return true; }
            return !ReferenceEquals(room1, null) && room1.Equals(room2);
        }

        public static bool operator !=(RoomId room1, RoomId room2)
        {
            return !(room1 == room2);
        }

        public override int GetHashCode() => HashCode.Combine(FloorNumber, RoomNumber);

        public override string ToString() => $"RoomId<{FloorNumber}:{RoomNumber}>";
    }
}
