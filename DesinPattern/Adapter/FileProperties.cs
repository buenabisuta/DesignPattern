using System;
using System.Linq;

namespace DesinPattern.Adapter
{
    public class FileProperties : Properties , FileIO
    {

        public FileProperties()
        {
        }

        public void SetValue(string key, string name)
        {
            SetKeyValue(key, name);
        }

        public void WriteFromFile()
        {
            var keyvalue = GetKeyValues();
            foreach(var item in keyvalue)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
        }
    }
}
