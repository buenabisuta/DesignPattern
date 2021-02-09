using System;
namespace DesinPattern.Strategy
{
    public class ProbStratgy : Strategy
    {
        private Random random;
        private Hand prevHand;
        private bool won = false;

        public ProbStratgy()
        {
            this.random = new Random();
        }

        public override Hand NextHand()
        {
            prevHand = new Hand(random.Next(0,3));
            return prevHand;
        }

        public override void Study(bool win)
        {
            won = win;
        }
    }
}
