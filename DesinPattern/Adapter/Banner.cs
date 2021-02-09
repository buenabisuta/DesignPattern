using System;
namespace DesinPattern.Adapter
{
    public class Banner
    {
        private string name;

        public Banner(string name)
        {
            this.name = name;
        }

        public void showWithParen()
        {
            Console.WriteLine("(" + name + ")");
        }

        public void showWithAster()
        {
            Console.WriteLine("*" + name + "*");
        }
    }
}
