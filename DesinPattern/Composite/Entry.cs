using System;
using System.Text;

namespace DesinPattern.Composite
{
    public abstract class Entry
    {
        public Entry parent;
        public abstract string GetName();
        public abstract int GetSize();

        public virtual Entry Add(Entry entry)
        {
            throw new FieldAccessException();
        }

        public void PrintList()
        {
            PrintList("");
        }

        protected internal abstract void PrintList(string v);

        public override string ToString()
        {
            return GetName() + "(" + GetSize() + ")";
        }

        public string FullPath()
        {
            var sb = new StringBuilder();
            Entry parentObj = parent;

            while (parentObj != null)
            {
                sb.Append($"/{parentObj.GetName()}");

                // 親の親を取得
                parentObj = parentObj.parent;
            }

            sb.Append($"/{this.GetName()}");

            return sb.ToString();
        }
    }
}
