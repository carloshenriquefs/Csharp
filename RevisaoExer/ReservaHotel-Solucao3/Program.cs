using System;
using ReservaHotel_Solucao3.Entities;
using ReservaHotel_Solucao3.Entities.Exceptions;

namespace ReservaHotel_Solucao3 {
    class Program {
        static void Main (string[] args) {
            try {
                Console.Write ("Número do quarto: ");
                int numeroQuarto = int.Parse (Console.ReadLine ());
                Console.Write ("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse (Console.ReadLine ());
                Console.Write ("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse (Console.ReadLine ());

                Reservation reservation = new Reservation (numeroQuarto, checkin, checkout);
                Console.WriteLine ("Reservation: " + reservation);

                Console.WriteLine ();
                Console.WriteLine ("Enter data to update the reservation:");
                Console.Write ("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse (Console.ReadLine ());
                Console.Write ("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse (Console.ReadLine ());

                reservation.UpdateDates (checkin, checkout);

                Console.WriteLine ("Reservation: " + reservation);
            } catch (DomainException e) {
                Console.WriteLine ("Erro in reservation: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error: "+ e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error: "+ e.Message);
            }
        }
    }
}