using System;
namespace DesinPattern.Visitor
{
    public interface Element
    {
        public abstract void Accept(Visitor visitor);
    }
}
