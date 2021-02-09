using System;
namespace DesinPattern.Singleton
{
    public class Singleton
    {
        private static Singleton singleton = new Singleton();

        private Singleton()
        {
            Console.WriteLine("インスタンス生成");
        }

        public static Singleton GetSingleton()
        {
            return singleton;
        }
    }
}
