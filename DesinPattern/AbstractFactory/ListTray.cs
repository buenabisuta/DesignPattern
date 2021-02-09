using System;
using System.Text;

namespace DesinPattern.AbstractFactory
{
    public class ListTray : Tray
    {
        public ListTray(string caption) : base(caption)
        {
        }

        public override string MakeHtml()
        {
            var st = new StringBuilder();
            foreach(var item in tray)
            {
                st.Append(item.MakeHtml());
            }
            return st.ToString();
        }
    }
}
