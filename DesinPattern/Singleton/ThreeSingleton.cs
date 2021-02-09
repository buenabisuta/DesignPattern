using System;
using System.Collections.Generic;

namespace DesinPattern.Singleton
{
    public class ThreeSingleton
    {
        private string name;

        private static List<ThreeSingleton> list = new List<ThreeSingleton>()
        {
            new ThreeSingleton("takashi"),
            new ThreeSingleton("taro"),
            new ThreeSingleton("ken"),
        };

        private ThreeSingleton(string name)
        {
            this.name = name;
        }

        public static ThreeSingleton GetInstance(int id)
        {
            if (id >= 3)
            {
                Console.WriteLine("から");
                return new ThreeSingleton(string.Empty);
            }
            return list[id];
        }

        public string GetName()
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("No Name");
                return string.Empty;
            }
            return name;
        }
    }
}
