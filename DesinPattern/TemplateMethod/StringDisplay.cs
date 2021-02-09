using System;
namespace DesinPattern.TemplateMethod
{
    public class StringDisplay : AbstractDisplay
    {
        private string st;
        private int width;

        public StringDisplay(string st)
        {
            this.st = st;
            this.width = st.Length;
        }

        protected override void Close()
        {
            PrintLine();
        }

        private void PrintLine()
        {
            Console.Write("+");
            for (var i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }

        protected override void Open()
        {
            PrintLine();
        }

        protected override void Print()
        {
            Console.WriteLine($"|{st}|");
        }
    }
}
