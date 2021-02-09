using System;
namespace DesinPattern.Factory
{
    public abstract class Factory
    {
        public Factory()
        {
        }

        public Product Create(string owner)
        {
            var product = CreateProduct(owner);
            RegisterProduct(product);
            return product;
        }

        public abstract Product CreateProduct(string owner);
        public abstract void RegisterProduct(Product product);

    }
}
