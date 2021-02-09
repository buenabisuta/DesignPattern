using System;
using System.Linq;

namespace DesinPattern.Test
{
    public class test
    {
        public test()
        {
        }

        public int ShortTest(string st)
        {
            var stList = st.Split(' ');

            return stList.Min(x => x.Length);
        }
    }
}
