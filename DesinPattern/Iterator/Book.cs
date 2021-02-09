using System;
namespace DesinPattern.Iterator
{
    public class Book
    {
        private string name { get; set; }

        public Book(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }
}
