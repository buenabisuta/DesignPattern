using System;
using System.Collections.Generic;
using System.Text;

namespace DesinPattern.Builder
{
    public class HTMLBuilder : Builder
    {
        private StringBuilder sb = new StringBuilder();
        public HTMLBuilder()
        {
        }

        public void Close()
        {
            sb.Append("</body</html>>¥n");
        }

        public void MakeItems(IEnumerable<string> items)
        {
            sb.Append("<ul>¥n");
            foreach (var item in items)
            {
                sb.Append("<li>" + item + "</li>¥n");
            }
            sb.Append("</ul>¥n");
        }

        public void MakeString(string str)
        {
            sb.Append("<p>" + str + "</p>¥n");
        }

        public void MakeTitle(string title)
        {
            sb.Append("<html><body>¥n");
            sb.Append("<h1>" + title + "</h1>¥n");
        }

        public string GetResult()
        {
            return sb.ToString();
        }
    }
}
