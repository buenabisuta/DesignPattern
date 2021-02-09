using System;
using System.Collections.Generic;
using System.Linq;

namespace DesinPattern.Composite
{
    public class Directory : Entry
    {
        private string name;
        private List<Entry> directories = new List<Entry>();

        public Directory(string name)
        {
            this.name = name;
        }

        public override string GetName()
        {
            return name;
        }

        public override int GetSize()
        {
            return directories.Sum(x => x.GetSize());
        }

        protected internal override void PrintList(string v)
        {
            Console.WriteLine($"{v}/{this.ToString()}");
            directories.ForEach(x =>
            {
                x.PrintList($"{v}/{name}");
            });
        }

        public override Entry Add(Entry entry)
        {
            directories.Add(entry);
            entry.parent = this;
            return this;
        }
    }
}
