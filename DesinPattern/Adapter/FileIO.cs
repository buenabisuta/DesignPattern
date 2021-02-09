using System;
namespace DesinPattern.Adapter
{
    public interface FileIO
    {
        public void SetValue(string key, string name);
        public void WriteFromFile();
    }
}
