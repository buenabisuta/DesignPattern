using System;
namespace DesinPattern.Bridge
{
    public class RandomDisplay : CountDisplay
    {
        public RandomDisplay(DisplayImpl impl) : base(impl)
        {
        }

        public void RandomDisp(int times)
        {
            var random = new Random();
            var count = random.Next(0, times);

            MultiDisplay(count);
        }
    }
}
