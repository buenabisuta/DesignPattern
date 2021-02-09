using System.Collections.Generic;

namespace DesinPattern.Visitor
{
    public class Directory : Entry
    {
        private string name;
        private List<Entry> entries = new List<Entry>();

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
            var size = 0;

            foreach(var item in entries)
            {
                size += item.GetSize();
            }

            return size;
        }

        public override Entry Add(Entry entry)
        {
            entries.Add(entry);

            return this;
        }

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public List<Entry> GetEntries()
        {
            return entries;
        }
    }
}