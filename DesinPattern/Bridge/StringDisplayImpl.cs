using System;
namespace DesinPattern.Bridge
{
    public class StringDisplayImpl : DisplayImpl
    {
        private string st;
        private int width;
        public StringDisplayImpl(string st)
        {
            this.st = st;
            this.width = st.Length;
        }

        public override void RawClose()
        {
            PrintLine();
        }

        private void PrintLine()
        {
            Console.Write("+");
            for(var i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }

        public override void RawOpen()
        {   
            PrintLine();
        }

        public override void RawPrint()
        {
            Console.WriteLine("|" + st + "|");
        }
    }
}
