using System;
namespace DesinPattern.Iterator
{
    public interface Iterator
    {
        public abstract Boolean hasNext();
        public abstract Object next();
        public abstract void loop();
    }
}
