using System;
namespace DesinPattern.Prototype
{
    public abstract class Product : ICloneable
    {
        public abstract void Use(string s);
        public Product CreateClone()
        {
            Product product = null;
            try
            {
                product = (Product)Clone();
            }
            catch
            {
                new Exception();
            }
            return product;
        }

        public abstract object Clone();
    }
}
