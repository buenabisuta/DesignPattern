using System;
namespace DesinPattern.Strategy
{
    public abstract class Strategy
    {
        public abstract Hand NextHand();
        public abstract void Study(bool win);
    }
}
