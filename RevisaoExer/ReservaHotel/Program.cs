using System;

namespace ReservaHotel {
    class Program {
        //Fazer um programa para ler os dados de uma reserva de hotel
        //(número do quarto, data de entrada e data de saída) e mostrar os dados
        //da reserva, inclusive sua duração em dias. Em seguida, ler novas datas
        //de entrada e saída, atualizar a reserva, e mostrar novamente a reserva
        //com os dados atualizados

        static void Main (string[] args) {
            Console.Write ("Número do quarto: ");
            int numeroQuarto = int.Parse (Console.ReadLine ());
            Console.Write ("Check-in date (dd/MM/yyyy): ");
            DateTime checkin = DateTime.Parse (Console.ReadLine ());
            Console.Write ("Check-out date (dd/MM/yyyy): ");
            DateTime checkout = DateTime.Parse (Console.ReadLine ());

            if (checkout <= checkin) {
                Console.WriteLine ("Error in reservation: Check-out date must be after check-in date ");
            } else {
                Reservation reservation = new Reservation (numeroQuarto, checkin, checkout);
                Console.WriteLine ("Reservation: " + reservation);

                Console.WriteLine ();
                Console.WriteLine ("Enter data to update the reservation:");
                Console.Write ("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse (Console.ReadLine ());
                Console.Write ("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse (Console.ReadLine ());

                DateTime now = DateTime.Now;
                if (checkin < now || checkout < now) {
                    Console.WriteLine ("Error in reservation: Reservation dates for update must be future dates");
                } else if (checkout <= checkin) {
                    Console.WriteLine ("Error in reservation: Check-out date must be after check-in date ");
                } else {
                    reservation.UpdateDates (checkin, checkout);
                    Console.WriteLine ("Reservation: " + reservation);
                }

            }
        }
    }
}