using System;
using System.Collections.Generic;
using System.Text;

namespace DesinPattern.Builder
{
    public class StrBuilder : Builder
    {
        public StrBuilder()
        {
        }

        public void Close()
        {
            Console.WriteLine("終了");
        }

        public string GetResult()
        {
            return string.Empty;
        }

        public void MakeItems(IEnumerable<string> items)
        {
            foreach(var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public void MakeString(string str)
        {
            Console.WriteLine("・" + str);
        }

        public void MakeTitle(string title)
        {
            Console.WriteLine("題名：" + title);
        }
    }
}
