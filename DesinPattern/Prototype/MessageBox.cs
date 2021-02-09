using System;
namespace DesinPattern.Prototype
{
    public class MessageBox : Product
    {
        private char decochar;

        public MessageBox(char decochar)
        {
            this.decochar = decochar;
        }

        public override object Clone()
        {
            return new MessageBox(decochar);
        }

        public override void Use(string s)
        {
            var length = s.Length;
            for (var i = 0; i < length + 4; i++)
            {
                Console.Write(decochar);
            }

            Console.WriteLine("");

            Console.WriteLine(decochar + " " + s + " " + decochar);

            for (var i = 0; i < length + 4; i++)
            {
                Console.Write(decochar);
            }

            Console.WriteLine("");
        }
    }
}
