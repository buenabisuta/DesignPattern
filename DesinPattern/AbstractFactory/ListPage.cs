using System;
using System.Text;

namespace DesinPattern.AbstractFactory
{
    public class ListPage : Page
    {
        public ListPage(string title,string author) : base(title,author)
        {
        }

        public override string MakeHtml()
        {
            var st = new StringBuilder();
            st.Append(title + ":" + author);
            foreach (var item in content)
            {
                st.Append(item.MakeHtml());
            }
            return st.ToString();
        }
    }
}
