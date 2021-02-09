using System;
using System.Collections.Generic;

namespace DesinPattern.Prototype
{
    public class Manager
    {
        private Dictionary<string,Product> showCase = new Dictionary<string, Product>();

        public void Register(string name,Product product)
        {
            showCase.Add(name, product);
        }

        public Product Create(string protoType)
        {
            var p = (Product)showCase.GetValueOrDefault(protoType);
            return p.CreateClone();
        }
    }
}
