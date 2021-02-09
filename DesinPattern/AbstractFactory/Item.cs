﻿using System;
namespace DesinPattern.AbstractFactory
{
    public abstract class Item
    {
        protected string caption;
        public Item(string caption)
        {
            this.caption = caption;
        }

        public abstract string MakeHtml();
    }
}
