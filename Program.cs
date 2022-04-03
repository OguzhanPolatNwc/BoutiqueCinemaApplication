using System;
using Microsoft.VisualBasic;

namespace ButikSinemaUygulamasi_G020
{
    class Program
    {
        static Sinema Snm;

        static void Main(string[] args)
        {
            Application();
        }

        static void Test()
        {
            int Number1 = TakeNumber("Enter 1. number : ");
            int Number2 = TakeNumber("Enter w. number: ");

            Console.WriteLine("Sum of Number: " + (Number1 + Number2));
        }
        static void Application()
        {
            Setup();
            Console.WriteLine();
            Menu();
            Console.WriteLine();
            while (true)
            {
                string input = MakeaChoice();
                Console.WriteLine();
                switch (input)
                {
                    case "1":
                    case "S":
                        SellTicket();
                        break;
                    case "2":
                    case "R":
                        ReturnTicket();
                        break;
                    case "3":
                    case "D":
                        Information();
                        break;
                    case "4":
                    case "X":
                        return;
                }
                Console.WriteLine();
            }
        }
        static int TakeNumber(string text)
        {
            int number;
            while (true)
            {
                Console.Write(text);
                string input = Console.ReadLine();
                bool result = int.TryParse(input, out number);

                if (result != true)
                {
                    Console.WriteLine("Incorrect entry made.");
                }
                else
                {
                    return number;
                }
            }
        }
        static void Setup()
        {
            Console.WriteLine("-------Boutique Movie Theater-------");
            Console.Write("Movie Name ");
            string MovieName = Console.ReadLine();
            //Console.Write("Capacity: ");
            //int cap = int.Parse(Console.ReadLine());
            int capacity = TakeNumber("Capacity: ");

            //Console.Write("Full ticket price: ");
            //float full = float.Parse(Console.ReadLine());
            int Full = TakeNumber("Full ticket price: ");

            //Console.Write("Half ticket price: ");
            //float half = float.Parse(Console.ReadLine());
            int Discounted = TakeNumber("Discounted ticket price: ");

            Snm = new Sinema(MovieName, capacity, Full, Discounted);
        }
        static void Menu()
        {
            Console.WriteLine("1 - Sell Ticket(S)      ");
            Console.WriteLine("2 - Return Ticket(R)    ");
            Console.WriteLine("3 - State(D)            ");
            Console.WriteLine("4 - Exit(X)             ");
        }
        static void SellTicket()
        {
            Console.WriteLine("Sell Tickets:");
            Console.Write("Amount of Full Tickets: ");
            int FullAmount = int.Parse(Console.ReadLine());
            Console.Write("Amount of Discounted Tickets:");
            int DiscountedAmount = int.Parse(Console.ReadLine());
            Snm.SellTicket(FullAmount, DiscountedAmount);


        }
        static void ReturnTicket()
        {
            Console.WriteLine("Return Ticket:");
            Console.Write("Amount of Full Tickets: ");
            int FullAmount = int.Parse(Console.ReadLine());
            Console.Write("Amount of Discounted Tickets:");
            int DiscountedAmount = int.Parse(Console.ReadLine());
            Snm.ReturnTicket(FullAmount, DiscountedAmount);
        }
        static void Information()
        {
            Console.WriteLine("Status Information");
            Console.WriteLine("Movie: " + Snm.FilmName);
            Console.WriteLine("Capacity: " + Snm.Capacity);
            Console.WriteLine("Full Ticket Price : " + Snm.FullTicketPrice);
            Console.WriteLine("Half Ticket Price : " + Snm.HalfTicketPrice);
            Console.WriteLine("Total Number of Full Tickets: " + Snm.TotalFullTicketAmount);
            Console.WriteLine("Total Number of Half Tickets: " + Snm.TotalHalfTicketAmount);
            Console.WriteLine("Endorsement: " + Snm.Endorsement);
            Console.WriteLine("Number of Empty Seats: " + Snm.GetEmptySeatsAmount());//

        }


        static string MakeaChoice()
        {
            Console.Write("Your Choice: ");
            return Console.ReadLine().ToUpper();

        }


    }
}
