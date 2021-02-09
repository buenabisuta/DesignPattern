using System;
namespace DesinPattern.Visitor
{
    public abstract class Entry : Element
    {
        public abstract string GetName();
        public abstract int GetSize();
        public virtual Entry Add(Entry entry)
        {
            throw new Exception();
        }

        public override string ToString()
        {
            return GetName() + "(" + GetSize() + ")";
        }

        public abstract void Accept(Visitor visitor);
    }
}
