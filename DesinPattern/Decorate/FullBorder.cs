using System;
using System.Text;

namespace DesinPattern.Decorate
{
    public class FullBorder : Border
    {
        public FullBorder(Display display) : base(display)
        {
        }

        public override int GetColumns()
        {
            return 1 + display.GetColumns() + 1;
        }

        public override int GetRows()
        {
            return 1 + display.GetRows() + 1;
        }

        public override string GetRowText(int row)
        {
            if (row == 0)
            {
                return "+" + MakeLine('-', display.GetColumns()) + "+";
            }
            else if (row == display.GetRows() + 1)
            {
                return "+" + MakeLine('-', display.GetColumns()) + "+";
            }
            else
            {
                return "|" + display.GetRowText(row - 1) + "|";
            }
        }

        private string MakeLine(char ch, int count)
        {
            var buf = new StringBuilder();
            for (var i = 0; i < count; i++)
            {
                buf.Append(ch);
            }
            return buf.ToString();
        }
    }
}
