using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Avatar", 162);
            Movie movie2 = new Movie("Interstellar", 169); 
            Movie movie3 = new Movie("The Dark Knight", 152);

            List<Seat> seats1 = new List<Seat>();
            for (int i = 1; i <= 10; i++) { seats1.Add(new Seat(i)); }
            List<Seat> seats2 = new List<Seat>(); 
            for (int i = 1; i <= 10; i++) { seats2.Add(new Seat(i)); }
            List<Seat> seats3 = new List<Seat>(); 
            for (int i = 1; i <= 10; i++) { seats3.Add(new Seat(i)); }

            CinemaHall hall1 = new CinemaHall(movie1, seats1); 
            CinemaHall hall2 = new CinemaHall(movie2, seats2); 
            CinemaHall hall3 = new CinemaHall(movie3, seats3);

            List<CinemaHall> cinemaHalls = new List<CinemaHall>(); 

            cinemaHalls.Add(hall1); 
            cinemaHalls.Add(hall2); 
            cinemaHalls.Add(hall3);

            Console.WriteLine("Welcome to Cinema Booking System!"); 
            Console.Write("Enter your name: "); 
            string customerName = Console.ReadLine(); 
            Customer customer = new Customer(customerName); 
            BookingService bookingService = new BookingService();

            Console.WriteLine(); 
            Console.WriteLine("Available movies:"); 
            bookingService.ShowMovies(cinemaHalls);

            Console.WriteLine(); bookingService.Welcome(customer, cinemaHalls);
            Console.WriteLine(); 
            Console.WriteLine("Press any key to exit..."); 
            Console.ReadKey();

            Console.WriteLine(); 
            Console.WriteLine("========== FINAL HALL SCHEME =========="); 
            foreach (CinemaHall hall in cinemaHalls) { Console.WriteLine(); Console.WriteLine($"Movie: {hall.Tittle}"); hall.ShowSeatData(); }
            Console.WriteLine(); Console.WriteLine("Press any key to exit..."); 
            Console.ReadKey();
        }
    }

    public class Seat
    {
        private int id;
        private bool isBusy;

        public int Id
        {
            get => id;
        }
        public bool IsBusy
        {
            get => isBusy;
        }
        public Seat(int ID)
        {
            id = ID;
            isBusy = false;
        }
        public void Reserve()
        {
            if (isBusy)
            {
                throw new ArgumentException("Seat was already reserved");
            }
            else
            {
                isBusy = true;
            }
        }
        public void Cancel()
        {
            if(!isBusy)
            {
                throw new ArgumentException("Seat was not reserved");
            }
            else
            {
                isBusy = false;
            }
        }
        public override string ToString()
        {
            if(isBusy)
            {
                return ($"{id} - reserved");
            }
            else
            {
                return ($"{id} - free");
            }
        }
    }
    public class Movie
    {
        private string name;
        private int duration;

        public string Name
        {
            get => name;
        }
        public int Duration
        {
            get => duration;
        }
        public Movie(string NAME ,int DURATION)
        {
            name = NAME;
            duration = DURATION;
        }
        public override string ToString()
        {
            return ($"{name} - {duration}");
        }
    }
    public class Reservation
    {
        private Movie movie;
        private Seat seat;

        public Seat GetSeat
        {
            get => seat;
        }
        public Movie GetMovie
        {
            get => movie;
        }
        public Reservation(Movie MOVIE, Seat SEAT)
        {
            movie = MOVIE;
            seat = SEAT;
        }
        public override string ToString()
        {
            return ($"{movie.Name}-{seat.Id}");
        }
    }
    public class Customer
    {
        private List<Reservation> Reservations;
        private string name;

        public Customer(string NAME)
        {
            name = NAME;
            Reservations = new List<Reservation>();
        }
        public bool AddReservation(Movie MOVIE , Seat SEAT)
        {
            Reservation res = new Reservation(MOVIE, SEAT);
            Reservations.Add(res);
            return true;
        }
        public bool CancelReservation(string MovieName , int SeatId)
        {
            foreach(Reservation res in Reservations)
            {
                if(res.GetMovie.Name  == MovieName && res.GetSeat.Id == SeatId)
                {
                    Console.WriteLine($"Reservation {res.ToString()} for {name} was canceled");
                    Reservations.Remove(res);
                    return false;
                }
            }
            throw new ArgumentException($"{name} doesnt has this reservcation");
        }
    }

    public class CinemaHall
    {
        private List<Seat> hallSeats;
        private Movie tittle;

        public Movie Tittle
        {
            get => tittle;
        }
        public List<Seat> HallSeats
        {
            get => hallSeats;
        }
        public CinemaHall(Movie TITTLE , List<Seat> SEATS)
        {
            hallSeats = SEATS;
            tittle = TITTLE;
        }

        public void UpdateSeatData(int SeatId, bool Action)
        {
            if(Action)
            {
                foreach(Seat se in hallSeats)
                {
                    if(se.Id == SeatId){ se.Reserve(); return; }

                }
            }
            else
            {
                foreach (Seat se in hallSeats)
                {
                    if (se.Id == SeatId) { se.Cancel(); return; }

                }
            }
        }
        public void ShowSeatData()
        {
            foreach(Seat se in hallSeats)
            {
                Console.WriteLine(se.ToString());
            }
        }
    }
    public class BookingService
    {
        private Seat selectedSeat;
        private CinemaHall selectedHall;


        public void ShowMovies(List<CinemaHall> cinemaHalls)
        {
            foreach(CinemaHall hall in cinemaHalls)
            {
                Console.WriteLine(hall.Tittle.ToString());
            }
        }
        public void Welcome(Customer c, List<CinemaHall> cinemaHalls)
        {
            Console.WriteLine("Hello do you wish to get a seat or cancel reservation?");
            while (true)
            {
                string UserInput = Console.ReadLine();
                if(UserInput.ToLower() == "get")
                {
                    SelectMovie(c, cinemaHalls);
                    return;
                }
                else if(UserInput.ToLower() == "cancel")
                {
                    FinalCancel(c, cinemaHalls);
                    return;
                }
                else
                {
                    Console.WriteLine("Sorry I didnt got you");
                    Console.WriteLine("Please say it again");
                }
            }
        }
        public void SelectMovie(Customer c, List<CinemaHall> cinemaHalls)
        {
            Console.WriteLine("Great! Tell me what movie you want , for now we have:");
            ShowMovies(cinemaHalls);
            while(true)
            {
                string UserInput = Console.ReadLine();
                if( UserInput.ToLower() == "leave")
                {
                    throw new ArgumentException("You left cinema");
                }
                foreach(CinemaHall hall in cinemaHalls)
                {
                    if(hall.Tittle.Name == UserInput)
                    {
                        Console.WriteLine($"{UserInput}? Good choice !");
                        selectedHall = hall;
                        SelectSeat(c);
                        return;
                    }
                }
                Console.WriteLine("Sorry but we dont have this movie");
                Console.WriteLine("Could you please reapeat what you want? If you want to leave say it");
            }
        }
        public void SelectSeat(Customer c)
        {
            Console.WriteLine("Okay now we need to choose your seat");
            Console.WriteLine("In this hall this is the list of seats:");
            selectedHall.ShowSeatData();
            List<Seat> AvailableSeats = selectedHall.HallSeats;
            while(true)
            {
                string UserInput = Console.ReadLine();
                foreach(Seat s in AvailableSeats)
                {
                    if(s.Id == Convert.ToInt32(UserInput))
                    {
                        BookSeat(s, c);
                        return;
                    }
                }

                Console.WriteLine("Sorry but this seat doesnt exist");

            }
        }
        public void BookSeat(Seat seat , Customer c)
        {
            Console.WriteLine("Last thing I need to check if seat is free");
            if(!seat.IsBusy)
            {
                Console.WriteLine("Yes its available!");
                Console.WriteLine("So do you want to reserver this seat? or other?");
                while(true)
                {
                    string UserInput = Console.ReadLine() ;
                    if(UserInput.ToLower() == "yes")
                    {
                        selectedSeat = seat ;
                        FinalReserve(c);
                        return;
                    }
                    else if(UserInput.ToLower() == "no")
                    {
                        Console.WriteLine("Okay :(");
                        throw new ArgumentException("You left cinema");
                    }
                    else if(UserInput.ToLower() == "other")
                    {
                        Console.WriteLine("Okay , here we go again");
                        SelectSeat(c);
                    }
                    else
                    {
                        Console.WriteLine("Sorry I didnt get you");
                    }
                }
            }
        }
        public void FinalCancel(Customer customer, List<CinemaHall> cinemaHalls)
        {
            Console.WriteLine("Please tell me what do you want to cancel");
            Console.WriteLine("Tittle name");
            string TITTLE = Console.ReadLine() ;
            Console.WriteLine("Seat id");
            int SEATID = Convert.ToInt32(Console.ReadLine());
            foreach(CinemaHall hall in cinemaHalls)
            {
                if(hall.Tittle.Name == TITTLE)
                {
                    hall.UpdateSeatData(SEATID, customer.CancelReservation(TITTLE, SEATID));
                }
            }
            Console.WriteLine("Done!");
        }
        public void FinalReserve(Customer customer)
        {
            selectedHall.UpdateSeatData(selectedSeat.Id, customer.AddReservation(selectedHall.Tittle, selectedSeat));
            Console.WriteLine("Done!");
        }
    }
}
