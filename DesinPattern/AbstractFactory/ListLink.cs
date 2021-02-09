using System;

namespace DesinPattern.AbstractFactory
{
    internal class ListLink : Link
    {
        public ListLink(string caption, string url) : base(caption, url)
        {
        }

        public override string MakeHtml()
        {
            var st = "Link:" + caption + ":" + url;
            Console.WriteLine(st.ToString());
            return st;
        }
    }
}