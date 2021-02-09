using System;
namespace DesinPattern.Decorate
{
    public class SlideBorder : Border
    {
        private char ch;
        public SlideBorder(Display display,char ch) : base(display)
        {
            this.ch = ch;
        }

        public override int GetColumns()
        {
            return 1 + display.GetColumns() + 1;
        }

        public override int GetRows()
        {
            return display.GetRows();
        }

        public override string GetRowText(int row)
        {
            return ch + display.GetRowText(row) + ch;
        }
    }
}
