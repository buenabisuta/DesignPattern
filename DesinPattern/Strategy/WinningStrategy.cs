using System;
namespace DesinPattern.Strategy
{
    public class WinningStrategy : Strategy
    {
        private Random random;
        private bool won = false;
        private Hand prevHand;
        public WinningStrategy()
        {
            this.random = new Random();
        }

        public override Hand NextHand()
        {
            if (!won)
            {
                prevHand = Hand.GetHand(random.Next(0,3));
            }
            return prevHand;
        }

        public override void Study(bool win)
        {
            won = win;
        }
    }
}
