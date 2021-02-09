using System;
namespace DesinPattern.Bridge
{
    public class CountDisplay : Display
    {
        public CountDisplay(DisplayImpl impl) : base(impl)
        {
        }

        public void MultiDisplay(int time)
        {
            Open();

            for(var i = 0; i < time; i++)
            {
                Print();
            }

            Close();
        }
    }
}
