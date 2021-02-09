using System;
using System.Collections.Generic;

namespace DesinPattern.Adapter
{
    public class Properties
    {
        private Dictionary<string, string> keyValues = new Dictionary<string, string>();

        public Properties()
        {
        }

        public void SetKeyValue(string key,string value)
        {
            keyValues.Add(key, value);
        }

        public Dictionary<string,string> GetKeyValues()
        {
            return keyValues;
        }
    }
}
