using HotelManagementSystem.Exceptions;
using HotelManagementSystem.Models;
using System.Configuration;
using System.Data;
using System.Windows;

namespace HotelManagementSystem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel TheHotel = new Hotel("Sea Ocean");

            try {
                TheHotel.MakeReservation(
                        new Reservation(new RoomId(1, 1), "Alex", new DateTime(2020, 2, 19), new DateTime(2020, 2, 27))
                        );
                TheHotel.MakeReservation(
                    new Reservation(new RoomId(1, 10), "John", new DateTime(2020, 2, 10), new DateTime(2020, 2, 15))
                    );
            }
            catch (ReservationConflictException ex) {
                throw;
            }

            base.OnStartup(e);
        }
    }

}
