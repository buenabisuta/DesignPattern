using System;
namespace DesinPattern.Prototype
{
    public class UnderLinePen : Product
    {
        private char ulchar;

        public UnderLinePen(char ulchar)
        {
            this.ulchar = ulchar;
        }

        public override object Clone()
        {
            return new UnderLinePen(ulchar);
        }

        public override void Use(string s)
        {
            var length = s.Length;
            Console.WriteLine("¥" + s + "¥");
            Console.Write(" ");
            for(var i = 0; i < length; i++)
            {
                Console.Write(ulchar);
            }
            Console.WriteLine("");
        }
    }
}
