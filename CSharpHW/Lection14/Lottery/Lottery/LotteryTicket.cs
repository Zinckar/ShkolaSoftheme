using System;

namespace Lottery
{
    public class LotteryTicket
    {
        private int[] _ticket;

        public LotteryTicket(int ticketNumber)
        {
            _ticket = GenerateTicket(ticketNumber);
        }
        public int this[int index]
        {
            get
            {
                return _ticket[index];
            }
        }

        private int[] GenerateTicket(int numberQuantity)
        {
            var arr = new int[numberQuantity];
            Random random = new Random();

            for (int i = 0; i < numberQuantity; i++)
            {
                arr[i] = random.Next(1, 9);
            }

            return arr;
        }
    }
}