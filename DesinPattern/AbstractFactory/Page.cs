using System;
using System.Collections.Generic;

namespace DesinPattern.AbstractFactory
{
    public abstract class Page
    {
        protected string title;
        protected string author;
        protected List<Item> content = new List<Item>();
        public Page(string title,string author)
        {
            this.title = title;
            this.author = author;
        }

        public void Add(Item item)
        {
            content.Add(item);
        }

        public void OutPut()
        {
            this.MakeHtml();
            Console.WriteLine(title + "を作成しました。");
        }

        public abstract string MakeHtml(); 
    }
}
