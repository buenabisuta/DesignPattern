﻿using System;
namespace DesinPattern.Composite
{
    public class File : Entry
    {
        private string name;
        private int size;

        public File(string name,int size)
        {
            this.name = name;
            this.size = size;
        }

        public override string GetName()
        {
            return name;
        }

        public override int GetSize()
        {
            return size;
        }

        protected internal override void PrintList(string v)
        {
            Console.WriteLine($"{v}/{this}");
        }
    }
}
