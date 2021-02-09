using System;
using System.Collections.Generic;
using System.Text;

namespace DesinPattern.Builder
{
    public interface Builder
    {
        public abstract void MakeTitle(string title);
        public abstract void MakeString(string str);
        public abstract void MakeItems(IEnumerable<string> items);
        public abstract void Close();
        public string GetResult();
    }
}
