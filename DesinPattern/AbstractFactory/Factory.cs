using System;
namespace DesinPattern.AbstractFactory
{
    public abstract class Factory
    {
        public static Factory GetFactory(string className)
        {
            Factory factory = null;

            var type = Type.GetType(className);
            factory = (Factory)Activator.CreateInstance(type);
            return factory;
        }
        public abstract Link CreateLink(string caption, string url);
        public abstract Tray CreateTray(string caption);
        public abstract Page CreatePage(string title, string author);
    }
}
