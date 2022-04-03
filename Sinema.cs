using System;
using System.Collections.Generic;
using System.Text;

namespace ButikSinemaUygulamasi_G020
{
    class Sinema
    {
        public string FilmName { get; set; }
        public int Capacity { get; }
        public float FullTicketPrice { get; }
        public float HalfTicketPrice { get; }
        public int TotalFullTicketAmount { get; private set; }
        public int TotalHalfTicketAmount { get; private set; }
        public float Endorsement
        {
            get
            {
                return this.TotalFullTicketAmount * this.FullTicketPrice + this.TotalHalfTicketAmount * this.HalfTicketPrice;
            }
        }
        public int EmptySeat
        {
            get
            {
                return this.Capacity - this.TotalFullTicketAmount - this.TotalHalfTicketAmount;
            }
        }
        public Sinema(string Moviename, int Capacity, float FullTicketPrice, float HalfTicketPrice)
        {
            this.FilmName = Moviename;
            this.Capacity = Capacity;
            this.FullTicketPrice = FullTicketPrice;
            this.HalfTicketPrice = HalfTicketPrice;
        }
        public void SellTicket(int FullTicketAmount, int HalfTicketAmount)
        {
            if (this.GetEmptySeatsAmount() >= (FullTicketAmount + HalfTicketAmount))
            {
                this.TotalFullTicketAmount += FullTicketAmount;
                this.TotalHalfTicketAmount += HalfTicketAmount;
                // CiroHesapla();
                Console.WriteLine("The operation ended succesfully");
            }
            else
            {
                Console.WriteLine("There are " + this.GetEmptySeatsAmount() + " tickets available for sale.");
                Console.WriteLine("The operation not ended succesfully.");
            }

        }


        public void ReturnTicket(int FullTicketAmount, int HalfTicketAmount)
        {
            if (FullTicketAmount <= this.TotalFullTicketAmount && HalfTicketAmount <= this.TotalHalfTicketAmount)
            {
                this.TotalFullTicketAmount -= FullTicketAmount;
                this.TotalHalfTicketAmount -= HalfTicketAmount;
                // Calculate Turnover();
                Console.WriteLine("The operation ended succesfully.");
            }
            else
            {
                Console.WriteLine("There are no tickets to be refunded.");
            }

        }
        public void ReturnTicketAlternative(int FullTicketAmount, int HalfTicketAmount)
        {
            if (FullTicketAmount > this.TotalFullTicketAmount)
            {
                Console.WriteLine("There are not enough full tickets to be refunded.");
            }
            else if (HalfTicketAmount > this.TotalHalfTicketAmount)
            {
                Console.WriteLine("There are not enough half tickets to be refunded.");
            }
            else
            {
                this.TotalFullTicketAmount -= FullTicketAmount;
                this.TotalHalfTicketAmount -= HalfTicketAmount;
                // Calculate Turnover();
                Console.WriteLine("The operation ended succesfully.");
            }

        }


        //private void Calculate Turnover()
        //{
        // this.Turnover = this.TotalFullTicketQty * this.FullTicketPrice + this.TotalHalfTicketQty * this.HalfTicketPrice;
        //}


        public int GetEmptySeatsAmount()
        {
            return this.Capacity - this.TotalFullTicketAmount - this.TotalHalfTicketAmount;
        }

    }
}
