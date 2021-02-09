using System;
using System.Collections.Generic;
using System.Text;

namespace DesinPattern.Builder
{
    public class TextBuilder : Builder
    {
        private StringBuilder sb = new StringBuilder();
        public TextBuilder()
        {
        }

        public void Close()
        {
            sb.Append("===========¥n");
        }

        public void MakeItems(IEnumerable<string> items)
        {
            foreach(var item in items)
            {
                sb.Append("・" + item + "¥n");
            }
        }

        public void MakeString(string str)
        {
            sb.Append("●" + str + "¥n");
            sb.Append("¥n");
        }

        public void MakeTitle(string title)
        {
            sb.Append("===========¥n");
            sb.Append("「" + title + "」¥n");
            sb.Append("¥n");
        }

        public string GetResult()
        {
            return sb.ToString();
        }
    }
}
