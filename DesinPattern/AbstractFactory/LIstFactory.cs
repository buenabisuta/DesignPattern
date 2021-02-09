using System;
namespace DesinPattern.AbstractFactory
{
    public class LIstFactory : Factory
    {
        public LIstFactory()
        {
        }

        public override Link CreateLink(string caption, string url)
        {
            return new ListLink(caption,url);
        }

        public override Page CreatePage(string title, string author)
        {
            return new ListPage(title, author);
        }

        public override Tray CreateTray(string caption)
        {
            return new ListTray(caption);
        }
    }
}
