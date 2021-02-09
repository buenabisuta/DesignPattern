using System;
namespace DesinPattern.Singleton
{
    public class TicketMaker
    {
        private static int ticket = 100;

        private static TicketMaker ticketMaker = new TicketMaker();
        private TicketMaker()
        {
        }

        public static TicketMaker GetInstance()
        {
            return ticketMaker;
        }

        public int GetNextTicket()
        {
            return ticket++;
        }
    }
}
